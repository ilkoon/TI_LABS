namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            labelBytesCnt = new Label();
            richTextBoxCipherText = new RichTextBox();
            label6 = new Label();
            richTextBoxPlainText = new RichTextBox();
            label5 = new Label();
            buttonMainProc = new Button();
            radioButtonDecipher = new RadioButton();
            radioButtonCipher = new RadioButton();
            richTextBoxBConst = new RichTextBox();
            label4 = new Label();
            buttonCalculate = new Button();
            richTextBoxNConst = new RichTextBox();
            label3 = new Label();
            richTextBoxQConst = new RichTextBox();
            richTextBoxPConst = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(labelBytesCnt);
            panel1.Controls.Add(richTextBoxCipherText);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(richTextBoxPlainText);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonMainProc);
            panel1.Controls.Add(radioButtonDecipher);
            panel1.Controls.Add(radioButtonCipher);
            panel1.Controls.Add(richTextBoxBConst);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonCalculate);
            panel1.Controls.Add(richTextBoxNConst);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(richTextBoxQConst);
            panel1.Controls.Add(richTextBoxPConst);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1624, 1279);
            panel1.TabIndex = 0;
            // 
            // labelBytesCnt
            // 
            labelBytesCnt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelBytesCnt.AutoSize = true;
            labelBytesCnt.Location = new Point(976, 783);
            labelBytesCnt.Name = "labelBytesCnt";
            labelBytesCnt.Size = new Size(355, 43);
            labelBytesCnt.TabIndex = 21;
            labelBytesCnt.Text = "Количество байт: 0";
            // 
            // richTextBoxCipherText
            // 
            richTextBoxCipherText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            richTextBoxCipherText.Location = new Point(976, 841);
            richTextBoxCipherText.Name = "richTextBoxCipherText";
            richTextBoxCipherText.ReadOnly = true;
            richTextBoxCipherText.Size = new Size(610, 387);
            richTextBoxCipherText.TabIndex = 20;
            richTextBoxCipherText.Text = "";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(653, 844);
            label6.Name = "label6";
            label6.Size = new Size(248, 43);
            label6.TabIndex = 19;
            label6.Text = "Шифротекст:";
            // 
            // richTextBoxPlainText
            // 
            richTextBoxPlainText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            richTextBoxPlainText.Location = new Point(976, 405);
            richTextBoxPlainText.Name = "richTextBoxPlainText";
            richTextBoxPlainText.ReadOnly = true;
            richTextBoxPlainText.Size = new Size(610, 366);
            richTextBoxPlainText.TabIndex = 18;
            richTextBoxPlainText.Text = "";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(653, 405);
            label5.Name = "label5";
            label5.Size = new Size(306, 43);
            label5.TabIndex = 17;
            label5.Text = "Исходный текст:";
            // 
            // buttonMainProc
            // 
            buttonMainProc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonMainProc.Cursor = Cursors.Hand;
            buttonMainProc.Enabled = false;
            buttonMainProc.Location = new Point(105, 1034);
            buttonMainProc.Name = "buttonMainProc";
            buttonMainProc.Size = new Size(337, 71);
            buttonMainProc.TabIndex = 12;
            buttonMainProc.Text = "Зашифровать";
            buttonMainProc.UseVisualStyleBackColor = true;
            buttonMainProc.Click += buttonMainProc_Click;
            // 
            // radioButtonDecipher
            // 
            radioButtonDecipher.AutoSize = true;
            radioButtonDecipher.Cursor = Cursors.Hand;
            radioButtonDecipher.Location = new Point(105, 642);
            radioButtonDecipher.Name = "radioButtonDecipher";
            radioButtonDecipher.Size = new Size(298, 47);
            radioButtonDecipher.TabIndex = 11;
            radioButtonDecipher.Text = "Дешифровать";
            radioButtonDecipher.UseVisualStyleBackColor = true;
            radioButtonDecipher.CheckedChanged += radioButtonDecipher_CheckedChanged;
            // 
            // radioButtonCipher
            // 
            radioButtonCipher.AutoSize = true;
            radioButtonCipher.Checked = true;
            radioButtonCipher.Cursor = Cursors.Hand;
            radioButtonCipher.Location = new Point(105, 551);
            radioButtonCipher.Name = "radioButtonCipher";
            radioButtonCipher.Size = new Size(296, 47);
            radioButtonCipher.TabIndex = 10;
            radioButtonCipher.TabStop = true;
            radioButtonCipher.Text = "Зашифровать";
            radioButtonCipher.UseVisualStyleBackColor = true;
            radioButtonCipher.CheckedChanged += radioButtonCipher_CheckedChanged;
            // 
            // richTextBoxBConst
            // 
            richTextBoxBConst.Location = new Point(105, 287);
            richTextBoxBConst.Name = "richTextBoxBConst";
            richTextBoxBConst.Size = new Size(440, 50);
            richTextBoxBConst.TabIndex = 9;
            richTextBoxBConst.Text = "";
            richTextBoxBConst.TextChanged += richTextBoxUConst_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 290);
            label4.Name = "label4";
            label4.Size = new Size(55, 43);
            label4.TabIndex = 8;
            label4.Text = "B:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Cursor = Cursors.Hand;
            buttonCalculate.Location = new Point(105, 400);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(381, 48);
            buttonCalculate.TabIndex = 7;
            buttonCalculate.Text = "Рассчитать";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // richTextBoxNConst
            // 
            richTextBoxNConst.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            richTextBoxNConst.Location = new Point(1038, 70);
            richTextBoxNConst.Name = "richTextBoxNConst";
            richTextBoxNConst.ReadOnly = true;
            richTextBoxNConst.Size = new Size(440, 50);
            richTextBoxNConst.TabIndex = 6;
            richTextBoxNConst.Text = "";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(964, 77);
            label3.Name = "label3";
            label3.Size = new Size(57, 43);
            label3.TabIndex = 5;
            label3.Text = "N:";
            // 
            // richTextBoxQConst
            // 
            richTextBoxQConst.Location = new Point(105, 169);
            richTextBoxQConst.Name = "richTextBoxQConst";
            richTextBoxQConst.Size = new Size(440, 50);
            richTextBoxQConst.TabIndex = 4;
            richTextBoxQConst.Text = "";
            richTextBoxQConst.TextChanged += richTextBoxUConst_TextChanged;
            // 
            // richTextBoxPConst
            // 
            richTextBoxPConst.Location = new Point(105, 63);
            richTextBoxPConst.Name = "richTextBoxPConst";
            richTextBoxPConst.Size = new Size(440, 50);
            richTextBoxPConst.TabIndex = 3;
            richTextBoxPConst.Text = "";
            richTextBoxPConst.TextChanged += richTextBoxUConst_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 176);
            label2.Name = "label2";
            label2.Size = new Size(60, 43);
            label2.TabIndex = 2;
            label2.Text = "Q:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 63);
            label1.Name = "label1";
            label1.Size = new Size(55, 43);
            label1.TabIndex = 1;
            label1.Text = "P:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1624, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(90, 36);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = Properties.Resources.open_file;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(343, 44);
            openToolStripMenuItem.Text = "Открыть";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = Properties.Resources.downloads;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(343, 44);
            saveToolStripMenuItem.Text = "Сохранить";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(22F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1624, 1279);
            Controls.Add(panel1);
            Font = new Font("Arial", 14F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            MinimumSize = new Size(1650, 1350);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "lab3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBoxPConst;
        private RichTextBox richTextBoxQConst;
        private RichTextBox richTextBoxNConst;
        private Label label3;
        private Button buttonCalculate;
        private RichTextBox richTextBoxBConst;
        private Label label4;
        private RadioButton radioButtonDecipher;
        private RadioButton radioButtonCipher;
        private Button buttonMainProc;
        private Label label5;
        private RichTextBox richTextBoxPlainText;
        private RichTextBox richTextBoxCipherText;
        private Label label6;
        private Label labelBytesCnt;
    }
}
