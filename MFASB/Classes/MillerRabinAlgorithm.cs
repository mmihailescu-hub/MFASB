using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MFASB.Classes
{
    class MillerRabinAlgorithm
    {
        public bool MillerRabin(ulong n)
        {
            ulong[] ar;
            if (n < 4759123141) ar = new ulong[] { 2, 7, 61 };
            else if (n < 341550071728321) ar = new ulong[] { 2, 3, 5, 7, 11, 13, 17 };
            else ar = new ulong[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
            ulong d = n - 1;
            int s = 0;
            while ((d & 1) == 0) { d >>= 1; s++; }
            int i, j;
            for (i = 0; i < ar.Length; i++)
            {
                ulong a = Math.Min(n - 2, ar[i]);
                ulong now = pow(a, d, n);
                if (now == 1) continue;
                if (now == n - 1) continue;
                for (j = 1; j < s; j++)
                {
                    now = mul(now, now, n);
                    if (now == n - 1) break;
                }
                if (j == s) return false;
            }
            return true;
        }

        ulong mul(ulong a, ulong b, ulong mod)
        {
            int i;
            ulong now = 0;
            for (i = 63; i >= 0; i--) if (((a >> i) & 1) == 1) break;
            for (; i >= 0; i--)
            {
                now <<= 1;
                while (now > mod) now -= mod;
                if (((a >> i) & 1) == 1) now += b;
                while (now > mod) now -= mod;
            }
            return now;
        }

        ulong pow(ulong a, ulong p, ulong mod)
        {
            if (p == 0) return 1;
            if (p % 2 == 0) return pow(mul(a, a, mod), p / 2, mod);
            return mul(pow(a, p - 1, mod), a, mod);
        }
    }
}
