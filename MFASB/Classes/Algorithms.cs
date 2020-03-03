using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFASB.Classes
{
    class Algorithms
    {
        MillerRabinAlgorithm mra = new MillerRabinAlgorithm();

        public void AddPrimalityAlgorithms(ComboBox cboAlgorithms)
        {
            ArrayList alPrimalityAlgorithms = new ArrayList();
            alPrimalityAlgorithms.Add("Miller Rabin Algorithm");
            alPrimalityAlgorithms.Add("Solovay Strassen Algorithm");
            alPrimalityAlgorithms.Add("Fermat Algorithm");

            for (int i = 0; i < alPrimalityAlgorithms.Count; i++)
            {
                cboAlgorithms.Items.Add(alPrimalityAlgorithms[i].ToString());
            }
        }

        public int GenerateNumber(int lower_limit, int upper_limit)
        {
            //int generated_number = 0;
            Random rnd = new Random();
            int randomIndex = 0;

            ArrayList allPrimes = new ArrayList();

            //** If lowerLimit is even, it is not eventually prime, so we start searching prime numbers beginning with
            if (lower_limit % 2 == 0)
                lower_limit = lower_limit + 1;

            //** We start with an odd number and the incrementation step is 2 (there are selected just odd numbers).
            for (int i = lower_limit; i < upper_limit; i = i + 2)
            {
                if (mra.MillerRabin((ulong)i))
                    allPrimes.Add(i);
            }

            randomIndex = rnd.Next(0, allPrimes.Count);

            return Convert.ToInt32(allPrimes[randomIndex]);
        }

        public string GeneratePassCode(int lungime, string caractere_pentru_generare = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789")
        {
            if (lungime < 0)
                throw new ArgumentOutOfRangeException("length", "lungimea nu poate sa fie mai mica de 0.");
            if (string.IsNullOrEmpty(caractere_pentru_generare))
                throw new ArgumentException("caractere_pentru_generare nu poate sa fie gol.");

            const int byteSize = 0x100;
            var set_caractere_permis = new HashSet<char>(caractere_pentru_generare).ToArray();
            if (byteSize < set_caractere_permis.Length)
                throw new ArgumentException(String.Format("caractere_pentru_generare poate sa contina nu mai mult de {0} caractere.", byteSize));

            using (var rng = new RNGCryptoServiceProvider())
            {
                var result = new StringBuilder();
                var buf = new byte[128];
                while (result.Length < lungime)
                {
                    rng.GetBytes(buf);
                    for (var i = 0; i < buf.Length && result.Length < lungime; ++i)
                    {                        
                        var outOfRangeStart = byteSize - (byteSize % set_caractere_permis.Length);
                        if (outOfRangeStart <= buf[i]) continue;
                        result.Append(set_caractere_permis[buf[i] % set_caractere_permis.Length]);
                    }
                }
                return result.ToString();
            }
        }
    }
    
}
