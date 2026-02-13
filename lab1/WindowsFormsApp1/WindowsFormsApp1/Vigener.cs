using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Vigener
    {

        private const string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public const int LetterCount = 33;

        public static string GetPlainTextOrKey(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char symbol in str)
            {
                char upperSymbol = char.ToUpper(symbol);
                if (Alphabet.Contains(upperSymbol))
                    sb.Append(upperSymbol);
            }
            return sb.ToString();
        }

        public static string CleanText(string str)
        {
            if (string.IsNullOrEmpty(str))
                return "";

            StringBuilder sb = new StringBuilder();
            foreach (char symbol in str)
            {
                char upperSymbol = char.ToUpper(symbol);
                if (Alphabet.Contains(upperSymbol))
                    sb.Append(upperSymbol);
            }
            return sb.ToString();
        }

        private static string GetProgressiveKey(string plainText, string originalKey)
        {
            StringBuilder resultKey = new StringBuilder();
            int keyLength = plainText.Length;
            string currentKey = originalKey.ToUpper();
            while (resultKey.Length < keyLength)
            {
                resultKey.Append(currentKey);
                char[] shiftedKey = new char[currentKey.Length];
                for (int i = 0; i < currentKey.Length; i++)
                {
                    int index = Alphabet.IndexOf(currentKey[i]);
                    int newIndex = (index + 1) % LetterCount;
                    shiftedKey[i] = Alphabet[newIndex];
                }

                currentKey = new string(shiftedKey);
            }

            string generatedKey = resultKey.ToString().Substring(0, keyLength);

            return generatedKey;
        }

        public static string Encipher(string plainText, string key)
        {
            if (string.IsNullOrEmpty(plainText) || string.IsNullOrEmpty(key))
                return "";

            string cleanPlainText = CleanText(plainText);
            string cleanKey = CleanText(key);

            if (string.IsNullOrEmpty(cleanPlainText) || string.IsNullOrEmpty(cleanKey))
                return "";

            StringBuilder sbCipherText = new StringBuilder();

            string fullKey = GetProgressiveKey(cleanPlainText, cleanKey);

            for (int i = 0; i < cleanPlainText.Length; i++)
            {
                int plainCharIndex = Alphabet.IndexOf(cleanPlainText[i]);
                int keyCharIndex = Alphabet.IndexOf(fullKey[i]);
                int cipherIndex = (plainCharIndex + keyCharIndex) % LetterCount;

                sbCipherText.Append(Alphabet[cipherIndex]);
            }

            return sbCipherText.ToString();
        }

        public static string Decipher(string cipher, string key)
        {
            if (string.IsNullOrEmpty(cipher) || string.IsNullOrEmpty(key))
                return "";

            string cleanPlainText = CleanText(cipher);
            string cleanKey = CleanText(key);

            if (string.IsNullOrEmpty(cleanPlainText) || string.IsNullOrEmpty(cleanKey))
                return "";

            StringBuilder sbCipherText = new StringBuilder();

            string fullKey = GetProgressiveKey(cleanPlainText, cleanKey);

            for (int i = 0; i < cleanPlainText.Length; i++)
            {
                int plainCharIndex = Alphabet.IndexOf(cleanPlainText[i]);
                int keyCharIndex = Alphabet.IndexOf(fullKey[i]);
                int cipherIndex = (plainCharIndex - keyCharIndex + LetterCount) % LetterCount;

                sbCipherText.Append(Alphabet[cipherIndex]);
            }

            return sbCipherText.ToString();
        }

       
    }
}