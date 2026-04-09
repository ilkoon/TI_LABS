using System;
using System.Collections.Generic;
using System.Text;


namespace WinFormsApp
{
    public class Rabin
    {

        public int NConst { get; set; }
        public int BConst { get; set; }
        public byte[] PlainBytes { get; set; }
        public int[] CipherNums { get; set; }
        public int[] Candidates { get; set; }

        public int MainCandidate;


        #region Helper fuctions

        private (int gcd, int x, int y) ExtendedEuclidean(int a, int b)
        {
            if (b == 0)
                return (a, 1, 0);

            var (gcd, x1, y1) = ExtendedEuclidean(b, a % b);
            int x = y1;
            int y = x1 - (a / b) * y1;

            return (gcd, x, y);
        }

        private int ModPow(int baseValue, int exponent, int modulus)
        {
            if (modulus == 1) return 0;

            long result = 1;
            long b = baseValue % modulus;
            int exp = exponent;

            while (exp > 0)
            {
                if ((exp & 1) == 1)
                    result = (result * b) % modulus;

                b = (b * b) % modulus;
                exp >>= 1;
            }

            return (int)result;
        }

        private int SqrtModPrime(int d, int p)
        {
            return ModPow(d, (p + 1) / 4, p);
        }
        public bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        public bool CheckRemainder(int num)
        {
            return ((num % 4) == 3);
        }

        #endregion

        public void EncryptRabbin()
        {
            CipherNums = new int[PlainBytes.Length];

            for (int i = 0; i < PlainBytes.Length; i++)
            {
                int m = PlainBytes[i];

                long temp = (long)m * (m + BConst);
                CipherNums[i] = (int)(temp % NConst);
            }
        }


        public void DecryptRabbin(int p, int q)
        {
            byte[] plainBytes = new byte[CipherNums.Length];

            var (_, yp, yq) = ExtendedEuclidean(p, q);

            for (int i = 0; i < CipherNums.Length; i++)
            {
                int c = CipherNums[i];

                long discriminant = ((long)BConst * BConst + 4L * c) % NConst;
                if (discriminant < 0) discriminant += NConst;
                int D = (int)discriminant;

                int mp = SqrtModPrime(D, p);
                int mq = SqrtModPrime(D, q);

                int mp2 = (p - mp) % p;
                int mq2 = (q - mq) % q;

                while (yp < 0) yp += NConst;
                while (yq < 0) yq += NConst;


                long term1 = (long)yp * p;
                long term2 = (long)yq * q;

                long d1_raw = (term1 * mq + term2 * mp) % NConst;
                long d3_raw = (term1 * mq - term2 * mp) % NConst;

                int d1 = (int)((d1_raw + NConst) % NConst);
                int d2 = (NConst - d1) % NConst;
                int d3 = (int)((d3_raw + NConst) % NConst);
                int d4 = (NConst - d3) % NConst;

                int[] roots = { d1, d2, d3, d4 };

 
                int[] candidates = new int[4];
                for (int j = 0; j < 4; j++)
                {
                    int di = roots[j];

                    long numerator = -BConst + di;
                    numerator = numerator % NConst;
                    if (numerator < 0) numerator += NConst;

                    if (numerator % 2 != 0)
                        numerator += NConst;

                    long candidate = (numerator / 2) % NConst;
                    if (candidate < 0) candidate += NConst;

                    candidates[j] = (int)candidate;
                }

                int correctByte = FindCorrectByte(candidates);

                if (correctByte == -1)
                {
                    throw new Exception($"Не найден корректный байт для блока {i}.\n" +
                        $"c={c}, D={D}, mp={mp}, mq={mq}\n" +
                        $"roots: [{string.Join(", ", roots)}]\n" +
                        $"candidates: [{string.Join(", ", candidates)}]");
                }

                plainBytes[i] = (byte)correctByte;
            }

            PlainBytes = plainBytes;

            
        }


        private int FindCorrectByte(int[] candidates)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (int candidate in candidates)
            {
                if (frequency.ContainsKey(candidate))
                    frequency[candidate]++;
                else
                    frequency[candidate] = 1;
            }


            foreach (var kvp in frequency)
            {
                int candidate = kvp.Key;
                int count = kvp.Value;

                if (candidate >= 0 && candidate < 256 && (count == 2 || count == 4))
                {
                    return candidate;
                }
            }

            foreach (int candidate in candidates)
            {
                if (candidate >= 0 && candidate < 256)
                {
                    return candidate;
                }
            }

            return -1;
        }

    }
}
