using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MFASB.Classes
{
    class Hashing
    {
        /// <summary>
        /// Functia calculeaza hash-ul pentru o anumita valoare.
        /// </summary>
        /// <param name="value">valoarea pentru care se calculeaza hash-ul</param>
        /// <param name="hash">functia hash dorita (SHA256, 384, 512)</param>
        /// <param name="salt">valoarea salt-ului (la invocare este null)</param>
        /// <returns></returns>
        public string ComputeHash(string value, string hash, byte[] salt)
        {
            int minSaltLength = 4;
            int maxSaltLength = 16;

            byte[] SaltBytes = null;

            if (salt != null)
            {
                SaltBytes = salt;
            }
            else
            {
                Random r = new Random();
                int SaltLength = r.Next(minSaltLength, maxSaltLength);
                SaltBytes = new byte[SaltLength];
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(SaltBytes);
                rng.Dispose();
            }

            byte[] plainData = ASCIIEncoding.UTF8.GetBytes(value);
            byte[] plainDataAndSalt = new byte[plainData.Length + SaltBytes.Length];

            for (int x = 0; x < plainData.Length; x++)
                plainDataAndSalt[x] = plainData[x];

            for (int n = 0; n < SaltBytes.Length; n++)
                plainDataAndSalt[plainData.Length + n] = SaltBytes[n];

            byte[] hashValue = null;

            switch (hash)
            {
                case "SHA256":
                    SHA256Managed sha = new SHA256Managed();
                    hashValue = sha.ComputeHash(plainDataAndSalt);
                    break;
                case "SHA384":
                    SHA384Managed sha1 = new SHA384Managed();
                    hashValue = sha1.ComputeHash(plainDataAndSalt);
                    break;
                case "SHA512":
                    SHA512Managed sha2 = new SHA512Managed();
                    hashValue = sha2.ComputeHash(plainDataAndSalt);
                    break;
            }

            byte[] result = new byte[hashValue.Length + SaltBytes.Length];

            for (int x = 0; x < hashValue.Length; x++)
                result[x] = hashValue[x];
            for (int n = 0; n < SaltBytes.Length; n++)
                result[hashValue.Length + n] = SaltBytes[n];

            return Convert.ToBase64String(result);
        }

        /// <summary>
        /// Functia ajuta la confirmarea unui hash pentru o anumita valoare.
        /// </summary>
        /// <param name="plainText">textul pentru care se face hash-ul</param>
        /// <param name="hashValue">valoarea hash</param>
        /// <param name="hash">functia hash (SHA256, 384, 512)</param>
        /// <returns></returns>
        public bool Confirm(string plainText, string hashValue, string hash)
        {
            byte[] hashBytes = Convert.FromBase64String(hashValue);

            int hashSize = 0;

            switch (hash)
            {
                case "SHA256":
                    hashSize = 32;
                    break;
                case "SHA384":
                    hashSize = 48;
                    break;
                case "SHA512":
                    hashSize = 64;
                    break;
            }

            byte[] saltBytes = new byte[hashBytes.Length - hashSize];

            for (int x = 0; x < saltBytes.Length; x++)
                saltBytes[x] = hashBytes[hashSize + x];

            string newHash = ComputeHash(plainText, hash, saltBytes);

            return (hashValue == newHash);
        }
    }
}
