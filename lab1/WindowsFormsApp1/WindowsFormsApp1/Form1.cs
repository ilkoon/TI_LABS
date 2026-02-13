using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.MinimumSize = new Size(800, 600);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool CheckInpComponents(RichTextBox textBox1, RichTextBox textBox2,
                                        RadioButton[] radioButtons1, RadioButton[] radioButtons2)
        {
            return (!string.IsNullOrWhiteSpace(richTextBoxIn.Text.Trim()) &&
                !string.IsNullOrWhiteSpace(richTextBoxKey.Text.Trim()) &&
                radioButtons1.Any(rb => rb.Checked) && radioButtons2.Any(rb => rb.Checked));
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton[] gr1 = { radioButtonDecipher, radioButtonEncipher };
            RadioButton[] gr2 = { radioButtonRailway, radioButtonVigener };
            buttonProcess.Enabled = CheckInpComponents(richTextBoxIn, richTextBoxKey, gr1, gr2);
            richTextBoxOut.Text = "";
            saveFileToolStripMenuItem.Enabled = false;
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            RadioButton[] gr1 = { radioButtonDecipher, radioButtonEncipher };
            RadioButton[] gr2 = { radioButtonRailway, radioButtonVigener };
            buttonProcess.Enabled = CheckInpComponents(richTextBoxIn, richTextBoxKey, gr1, gr2);
            richTextBoxOut.Text = "";
            saveFileToolStripMenuItem.Enabled = false;
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (radioButtonRailway.Checked)
            {
                
                int key = RailwayFence.GetKey(richTextBoxKey.Text);
                if (key == -1)
                {
                    MessageBox.Show("Проверьте ваш ключ, чтобы он содержал цифры", "Неправильный ключ");
                    return;
                }

                richTextBoxKey.Text = key.ToString();
                string plainText = RailwayFence.GetPlainText(richTextBoxIn.Text);


                string cipher = "";

                if (radioButtonEncipher.Checked)
                {
                    cipher = RailwayFence.Encipher(plainText, key);
                }
                else if (radioButtonDecipher.Checked)
                {
                    cipher = RailwayFence.Decipher(plainText, key);
                }

                if (cipher != plainText)
                {
                    richTextBoxOut.Text = cipher;
                }
                
            }
            else if (radioButtonVigener.Checked)
            {
                string key = Vigener.GetPlainTextOrKey(richTextBoxKey.Text);
                if (key == "")
                {
                    MessageBox.Show("Проверьте ваш ключ, чтобы он содержал русские буквы", "Неправильный ключ");
                    return;
                }

                richTextBoxKey.Text = key.ToString();

                string res = "";
                if (radioButtonEncipher.Checked)
                {
                     res = Vigener.Encipher(richTextBoxIn.Text, key);
                }
                else if (radioButtonDecipher.Checked)
                {
                    res = Vigener.Decipher(richTextBoxIn.Text, key);
                }
                if (res == "")
                {
                    MessageBox.Show("Проверьте ваш вводимый текст, чтобы он содержал русские буквы", "Неправильный ключ");
                    return;
                }
                richTextBoxOut.Text = res;
            }

            saveFileToolStripMenuItem.Enabled = true;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxIn.Text = FileHandler.openFile();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileHandler.saveFile(richTextBoxOut.Text);
        }

        //.Net 9 check
    }
}
