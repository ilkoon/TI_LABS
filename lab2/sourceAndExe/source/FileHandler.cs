using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace WinFormApp
{
    internal class FileHandler
    {
        public static bool IsFileOpened { get; set; }
        public static string CurrFilePath = "";

        public static string OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = "Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "Выберите файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        CurrFilePath = openFileDialog.FileName;

                        byte[] fileBytes = File.ReadAllBytes(CurrFilePath);

                        StringBuilder binStr = new StringBuilder(fileBytes.Length * 8);

                        foreach (byte b in fileBytes)
                        {
                            binStr.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
                        }

                        IsFileOpened = true;
                        return binStr.ToString();
                    }
                    catch(Exception e) {
                        IsFileOpened=false;
                        MessageBox.Show($"Ошибка при открытии файла: {e.Message}",
                                       "Ошибка",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    }
                }
            }

            return "";
        }

        public static bool SaveToFile(string content)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Все файлы (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Title = "Сохранить файл";
                saveFileDialog.OverwritePrompt = false;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        CurrFilePath = saveFileDialog.FileName; 
                        string cleanBinary = new string(content
                                                       .Where(c => c == '0' || c == '1')
                                                       .ToArray());

                        byte[] fileBytes = new byte[cleanBinary.Length / 8];

                        for (int i = 0; i < fileBytes.Length; i++)
                        {
                            string byteString = cleanBinary.Substring(i * 8, 8);
                            fileBytes[i] = Convert.ToByte(byteString, 2);
                        }

                        File.WriteAllBytes(CurrFilePath, fileBytes);

                        MessageBox.Show("Файл успешно сохранен!", "Сохранение",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}",
                                       "Ошибка",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                        return false;
                    }
                }

                return false;
            
            }
        }
        
    }
}
