using System.Runtime.CompilerServices;


namespace WinFormsApp
{
    public partial class Form1 : Form
    {

        private Rabin rabinProccess;
        private bool FieldState { get; set; }
        private bool FileState { get; set; }
        int P;
        int Q;
        
        public Form1()
        {
            InitializeComponent();
            rabinProccess = new Rabin();
            FieldState = false;
            FileState = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (radioButtonCipher.Checked)
            {
                rabinProccess.PlainBytes = FileHandler.OpenFilePlainText();
                if (rabinProccess.PlainBytes != null)
                {
                    richTextBoxPlainText.Text = string.Join(" ", rabinProccess.PlainBytes);
                    labelBytesCnt.Text = $"Количество байт: {rabinProccess.PlainBytes.Length}";
                    FileState = true;
                }
                else
                {
                    richTextBoxPlainText.Text = "";
                    labelBytesCnt.Text = $"Количество байт: 0";
                    FileState = false;
                }
            }
            else
            {
                rabinProccess.CipherNums = FileHandler.ReadCipherFromFile();
                if (rabinProccess.CipherNums != null)
                {
                    richTextBoxPlainText.Text = string.Join(" ", rabinProccess.CipherNums);
                    labelBytesCnt.Text = $"Количество байт: {rabinProccess.CipherNums.Length}";
                    FileState = true;
                }
                else
                {
                    richTextBoxPlainText.Text = "";
                    labelBytesCnt.Text = $"Количество байт: 0";
                    FileState = false;
                }
            }

            richTextBoxCipherText.Text = "";
            buttonMainProc.Enabled = FileState & FieldState;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (radioButtonCipher.Checked)
            {
                FileHandler.SaveCipherToFileWithDialog(rabinProccess.CipherNums);
            }
            else
            {
                FileHandler.SaveDecryptedBytes(rabinProccess.PlainBytes);
            }
        }

        private bool CheckConstField(string val, string name, out int castedVal)
        {
            if (!int.TryParse(val, out castedVal)
                || !rabinProccess.IsPrime(castedVal)
                || !rabinProccess.CheckRemainder(castedVal))
            {
                MessageBox.Show($"Значение константы {name} должно быть простым числом и при делении на 4 давать остаток 3");
                return false;
            }

            return true;
        }

        private bool CheckBField(string val, int nCnst, out int castedVal)
        {
            if (!int.TryParse(val, out castedVal) ||
                (castedVal < 0) || (castedVal >= nCnst))
            {
                MessageBox.Show("Значение константы B должно быть в диапазоне от 0 до P*Q");
                return false;
            }
            return true;
        }

        private void BadStateControls()
        {
            buttonMainProc.Enabled = false;
            richTextBoxNConst.Text = "";
            richTextBoxCipherText.Text = "";
        }

        private int ProccessN(int p, int q)
        {
            int n = p * q;

            richTextBoxNConst.Text = n.ToString();
            rabinProccess.NConst = n;

            return n;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int qConst = -1;

            FieldState = true;

            if (!CheckConstField(richTextBoxPConst.Text, "P", out int pConst)
                || !CheckConstField(richTextBoxQConst.Text, "Q", out qConst))
            {
                FieldState = false;
            }

            if (!FieldState)
            {
                BadStateControls();
            }
            else
            {
                int n = ProccessN(pConst, qConst);
                P = pConst;
                Q = qConst;

                if (!CheckBField(richTextBoxBConst.Text, n, out int bConst))
                {
                    FieldState = false;
                }
                else
                {
                    rabinProccess.BConst = bConst;
                }
            }

            buttonMainProc.Enabled = FieldState & FileState;

        }


        private void radioButtonCipher_CheckedChanged(object sender, EventArgs e)
        {
            buttonMainProc.Text = "Зашифровать";
            richTextBoxCipherText.Text = "";
        }

        private void radioButtonDecipher_CheckedChanged(object sender, EventArgs e)
        {
            buttonMainProc.Text = "Дешифровать";
            richTextBoxCipherText.Text = "";
        }

        private void richTextBoxUConst_TextChanged(object sender, EventArgs e)
        {
            BadStateControls();
        }

        private void buttonMainProc_Click(object sender, EventArgs e)
        {
            if (radioButtonCipher.Checked)
            {
                rabinProccess.EncryptRabbin();
                richTextBoxCipherText.Text = string.Join(" ", rabinProccess.CipherNums);
            }
            else
            {
                rabinProccess.DecryptRabbin(P, Q);
                richTextBoxCipherText.Text = string.Join(" ", rabinProccess.PlainBytes);
            }
        }
    }
}
