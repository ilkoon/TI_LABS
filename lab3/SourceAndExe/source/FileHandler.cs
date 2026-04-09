using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp
{
    public class FileHandler
    {

        #region For encrypce
        public static byte[] OpenFilePlainText()
        {

            using OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "Все файлы (*.*)|*.*";
            openFileDialog.CheckFileExists = true;
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] fileBytes = File.ReadAllBytes(openFileDialog.FileName);

                    return fileBytes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Ошибка при чтении файла: {ex.Message}",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return null;
                }
            }

            return null;
        }


        public static bool SaveCipherToFileWithDialog(int[] cipherNumbers)
        {

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Сохранить зашифрованный файл";
                saveFileDialog.Filter = "Все файлы (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                            foreach (int number in cipherNumbers)
                            {
                                byte[] bytes = BitConverter.GetBytes(number);
                                fileStream.Write(bytes, 0, bytes.Length);
                            }
                        }

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении: {ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return false; 
        }

        #endregion

        #region For decipher

        public static int[] ReadCipherFromFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите зашифрованный файл";
                openFileDialog.Filter = "Все файлы (*.*)|*.*";
                openFileDialog.CheckFileExists = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] allBytes = File.ReadAllBytes(openFileDialog.FileName);

                        
                        if (allBytes.Length % 4 != 0)
                        {
                            MessageBox.Show("Файл не корректен: размер не кратен 4 байтам!\n" +
                                $"Размер файла: {allBytes.Length} байт",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }

                        int[] cipherNumbers = new int[allBytes.Length / 4];

                        for (int i = 0; i < cipherNumbers.Length; i++)
                        {
                            cipherNumbers[i] = BitConverter.ToInt32(allBytes, i * 4);
                        }


                        return cipherNumbers;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при чтении файла: {ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }

            return null; 
        }

        public static bool SaveDecryptedBytes(byte[] plainBytes)
        {

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Сохранить расшифрованный файл";
                saveFileDialog.Filter = "Все файлы (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, plainBytes);

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return false; 
        }

        #endregion

    }
}
