namespace WinFormApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelRegister = new Panel();
            buttonHandle = new Button();
            labelCounter = new Label();
            richTextBoxRegister = new RichTextBox();
            labelRegText = new Label();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemOpen = new ToolStripMenuItem();
            toolStripMenuItemSave = new ToolStripMenuItem();
            toolStripMenuItemInstruction = new ToolStripMenuItem();
            panelResults = new Panel();
            label1 = new Label();
            richTextBoxCipher = new RichTextBox();
            labelFileInfo = new Label();
            labelPlainText = new Label();
            richTextBoxPlainText = new RichTextBox();
            labelGenKey = new Label();
            richTextBoxGenKey = new RichTextBox();
            panelRegister.SuspendLayout();
            menuStrip1.SuspendLayout();
            panelResults.SuspendLayout();
            SuspendLayout();
            // 
            // panelRegister
            // 
            panelRegister.BackColor = SystemColors.AppWorkspace;
            panelRegister.Controls.Add(buttonHandle);
            panelRegister.Controls.Add(labelCounter);
            panelRegister.Controls.Add(richTextBoxRegister);
            panelRegister.Controls.Add(labelRegText);
            panelRegister.Controls.Add(menuStrip1);
            panelRegister.Dock = DockStyle.Top;
            panelRegister.Location = new Point(0, 0);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(1574, 425);
            panelRegister.TabIndex = 0;
            // 
            // buttonHandle
            // 
            buttonHandle.Anchor = AnchorStyles.Top;
            buttonHandle.Cursor = Cursors.Hand;
            buttonHandle.Location = new Point(980, 315);
            buttonHandle.Name = "buttonHandle";
            buttonHandle.Size = new Size(491, 78);
            buttonHandle.TabIndex = 4;
            buttonHandle.Text = "Зашифровать/Дешифровать";
            buttonHandle.UseVisualStyleBackColor = true;
            buttonHandle.Click += buttonHandle_Click;
            // 
            // labelCounter
            // 
            labelCounter.Anchor = AnchorStyles.Top;
            labelCounter.AutoSize = true;
            labelCounter.Location = new Point(43, 293);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(141, 45);
            labelCounter.TabIndex = 3;
            labelCounter.Text = "Счетчик";
            // 
            // richTextBoxRegister
            // 
            richTextBoxRegister.Anchor = AnchorStyles.Top;
            richTextBoxRegister.Location = new Point(171, 158);
            richTextBoxRegister.MaxLength = 32;
            richTextBoxRegister.Name = "richTextBoxRegister";
            richTextBoxRegister.Size = new Size(1300, 108);
            richTextBoxRegister.TabIndex = 2;
            richTextBoxRegister.Text = "";
            richTextBoxRegister.TextChanged += richTextBox1_TextChanged;
            richTextBoxRegister.KeyPress += richTextBoxRegister_KeyPress;
            // 
            // labelRegText
            // 
            labelRegText.Anchor = AnchorStyles.Top;
            labelRegText.AutoSize = true;
            labelRegText.BackColor = SystemColors.Info;
            labelRegText.Location = new Point(513, 79);
            labelRegText.Name = "labelRegText";
            labelRegText.Size = new Size(598, 45);
            labelRegText.TabIndex = 1;
            labelRegText.Text = "Состояние регистра(32 состояния[0, 1])";
            labelRegText.Click += labelRegText_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, toolStripMenuItemInstruction });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1574, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemOpen, toolStripMenuItemSave });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(90, 38);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // toolStripMenuItemOpen
            // 
            toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            toolStripMenuItemOpen.ShortcutKeys = Keys.Control | Keys.O;
            toolStripMenuItemOpen.Size = new Size(359, 44);
            toolStripMenuItemOpen.Text = "Открыть";
            toolStripMenuItemOpen.Click += toolStripMenuItemOpen_Click;
            // 
            // toolStripMenuItemSave
            // 
            toolStripMenuItemSave.Enabled = false;
            toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            toolStripMenuItemSave.ShortcutKeys = Keys.Control | Keys.S;
            toolStripMenuItemSave.Size = new Size(359, 44);
            toolStripMenuItemSave.Text = "Сохранить";
            toolStripMenuItemSave.Click += toolStripMenuItemSave_Click;
            // 
            // toolStripMenuItemInstruction
            // 
            toolStripMenuItemInstruction.Name = "toolStripMenuItemInstruction";
            toolStripMenuItemInstruction.Size = new Size(165, 38);
            toolStripMenuItemInstruction.Text = "Инструкция";
            toolStripMenuItemInstruction.Click += toolStripMenuItemInstruction_Click;
            // 
            // panelResults
            // 
            panelResults.BackColor = SystemColors.ControlDark;
            panelResults.Controls.Add(label1);
            panelResults.Controls.Add(richTextBoxCipher);
            panelResults.Controls.Add(labelFileInfo);
            panelResults.Controls.Add(labelPlainText);
            panelResults.Controls.Add(richTextBoxPlainText);
            panelResults.Controls.Add(labelGenKey);
            panelResults.Controls.Add(richTextBoxGenKey);
            panelResults.Dock = DockStyle.Fill;
            panelResults.Location = new Point(0, 425);
            panelResults.Name = "panelResults";
            panelResults.Size = new Size(1574, 804);
            panelResults.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Location = new Point(864, 43);
            label1.Name = "label1";
            label1.Size = new Size(203, 45);
            label1.TabIndex = 6;
            label1.Text = "Шифротекст";
            // 
            // richTextBoxCipher
            // 
            richTextBoxCipher.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            richTextBoxCipher.Location = new Point(864, 110);
            richTextBoxCipher.Name = "richTextBoxCipher";
            richTextBoxCipher.ReadOnly = true;
            richTextBoxCipher.Size = new Size(674, 393);
            richTextBoxCipher.TabIndex = 5;
            richTextBoxCipher.Text = "";
            // 
            // labelFileInfo
            // 
            labelFileInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelFileInfo.AutoSize = true;
            labelFileInfo.Font = new Font("Arial", 8F);
            labelFileInfo.Location = new Point(12, 770);
            labelFileInfo.Name = "labelFileInfo";
            labelFileInfo.Size = new Size(318, 25);
            labelFileInfo.TabIndex = 4;
            labelFileInfo.Text = "Информация: Файл не открыт";
            // 
            // labelPlainText
            // 
            labelPlainText.AutoSize = true;
            labelPlainText.BackColor = SystemColors.Info;
            labelPlainText.Location = new Point(43, 43);
            labelPlainText.Name = "labelPlainText";
            labelPlainText.Size = new Size(254, 45);
            labelPlainText.TabIndex = 3;
            labelPlainText.Text = "Исходный текст";
            // 
            // richTextBoxPlainText
            // 
            richTextBoxPlainText.Location = new Point(43, 110);
            richTextBoxPlainText.Name = "richTextBoxPlainText";
            richTextBoxPlainText.ReadOnly = true;
            richTextBoxPlainText.Size = new Size(627, 284);
            richTextBoxPlainText.TabIndex = 2;
            richTextBoxPlainText.Text = "";
            // 
            // labelGenKey
            // 
            labelGenKey.AutoSize = true;
            labelGenKey.BackColor = SystemColors.Info;
            labelGenKey.Location = new Point(43, 440);
            labelGenKey.Name = "labelGenKey";
            labelGenKey.Size = new Size(377, 45);
            labelGenKey.TabIndex = 1;
            labelGenKey.Text = "Сгенерированный ключ";
            // 
            // richTextBoxGenKey
            // 
            richTextBoxGenKey.Location = new Point(43, 505);
            richTextBoxGenKey.Name = "richTextBoxGenKey";
            richTextBoxGenKey.ReadOnly = true;
            richTextBoxGenKey.Size = new Size(627, 232);
            richTextBoxGenKey.TabIndex = 0;
            richTextBoxGenKey.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 1229);
            Controls.Add(panelResults);
            Controls.Add(panelRegister);
            Font = new Font("Segoe UI", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MinimumSize = new Size(1600, 1250);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LAB2";
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelResults.ResumeLayout(false);
            panelResults.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRegister;
        private Panel panelResults;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemOpen;
        private ToolStripMenuItem toolStripMenuItemSave;
        private Label labelRegText;
        private RichTextBox richTextBoxRegister;
        private Label labelCounter;
        private Button buttonHandle;
        private RichTextBox richTextBoxGenKey;
        private Label labelGenKey;
        private Label labelPlainText;
        private RichTextBox richTextBoxPlainText;
        private ToolStripMenuItem toolStripMenuItemInstruction;
        private Label labelFileInfo;
        private Label label1;
        private RichTextBox richTextBoxCipher;
    }
}
