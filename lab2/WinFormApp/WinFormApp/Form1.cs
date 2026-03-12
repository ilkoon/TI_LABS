using System.Collections;
using System.Text;

namespace WinFormApp
{
    public partial class MainForm : Form
    {
        readonly StreamCipher streamCipher = new StreamCipher();
        public static int RegLen = 32;
        public MainForm()
        {
            InitializeComponent();
            FileHandler.IsFileOpened = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateCharCnt();
            UpdateView();
            toolStripMenuItemSave.Enabled = false;
        }

        private void UpdateView()
        {
            richTextBoxCipher.Text = "";
            richTextBoxGenKey.Text = "";
            
        }
        private void UpdateCharCnt()
        {
            labelCounter.Text = $"Количество символов: {richTextBoxRegister.Text.Length}";
        }

        private void richTextBoxRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1')
            {
                e.KeyChar = '\0';
            }

        }

        private bool checkStatesToHandle()
        {
            if (richTextBoxRegister.Text.Length != RegLen)
            {
                MessageBox.Show("Ошибка: Необходимо, чтобы регистр содержал 32 " +
                                "состояния(возможные значения состояния: [0, 1])",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            else if (!FileHandler.IsFileOpened)
            {
                MessageBox.Show("Ошибка: Необходимо открыть файл",
                               "Ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void labelRegText_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItemInstruction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Необходимо ввести в поле состояния" +
                "регисра 32 символа(0 или 1), затем открыть файл, и нажать кнопку " +
                "'Зашифровать/Дешифровать'", "Инструкция",
                MessageBoxButtons.OK);
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            string fileContent = FileHandler.OpenFile();
            if (FileHandler.IsFileOpened)
            {
                labelFileInfo.Text = $"Открыт файл: {FileHandler.CurrFilePath}";
                richTextBoxPlainText.Text = fileContent;
                UpdateView();
            }
            else
            {
                labelFileInfo.Text = "Не получилось открыть файл";
            }
        }

        private void buttonHandle_Click(object sender, EventArgs e)
        {
            if (checkStatesToHandle())
            {
                toolStripMenuItemSave.Enabled = true;

                string plainText = richTextBoxPlainText.Text;
                streamCipher.PlainText = new BitArray(plainText.Select(c => c == '1').ToArray());

                streamCipher.CreateBitRegester(richTextBoxRegister.Text);
                streamCipher.CreateBitKey(streamCipher.PlainText.Length);
                richTextBoxGenKey.Text = BitArrayToStr(streamCipher.BitKey);

                streamCipher.Cipher();
                richTextBoxCipher.Text = BitArrayToStr(streamCipher.CipherBit);

            }
            else
            {
                toolStripMenuItemSave.Enabled = false;
            }
        }

        public string BitArrayToStr(BitArray array)
        {
            StringBuilder temp = new();

            foreach (bool bit in array)
            {
                temp.Append(bit ? 1 : 0);
            }
            return temp.ToString();
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            if (FileHandler.SaveToFile(richTextBoxCipher.Text))
            {
                labelFileInfo.Text = $"Сохранено в файл: {FileHandler.CurrFilePath}";
            }
            else
            {
                labelFileInfo.Text = "Не получилось сохранить данные";
            }
        }
    }
}
