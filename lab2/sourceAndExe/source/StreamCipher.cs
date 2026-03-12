using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WinFormApp
{
    internal class StreamCipher
    {
        public BitArray BitReg { get; set; }
        public BitArray BitKey { get; set; }
        public BitArray PlainText { get; set; }
        public BitArray CipherBit { get;  set; }

        public  void CreateBitRegester(string plainReg)
        {
            int len = plainReg.Length;
            BitReg = new BitArray(len);
            for(int i = 0; i < len; i++)
            {
                BitReg[i] = plainReg[i] == '1';
            }
        }

        public void CreateBitKey(int length)
        {
            // Многочлен: x^32 + x^28 + x^27 + x + 1
            BitKey = new BitArray(length);

            for (int i = 0; i < length; i++)
            {

                BitKey[i] = BitReg[0];

                // Сдвиг влево, младший бит - самый правый
                bool bit32 = BitReg[0];      
                bool bit28 = BitReg[3];      
                bool bit27 = BitReg[4];      
                bool bit1 = BitReg[31];      

                bool feedback = bit32 ^ bit28 ^ bit27 ^ bit1;

                for (int j = 0; j < BitReg.Length - 1; j++)
                {
                    BitReg[j] = BitReg[j + 1];  
                }

                BitReg[BitReg.Length - 1] = feedback;
            }
        }

        public void Cipher()
        {
            CipherBit = BitKey.Xor(PlainText);
        }
    }
}
