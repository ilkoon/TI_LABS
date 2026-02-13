namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBoxIn = new System.Windows.Forms.RichTextBox();
            this.richTextBoxKey = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOut = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonRailway = new System.Windows.Forms.RadioButton();
            this.radioButtonVigener = new System.Windows.Forms.RadioButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonEncipher = new System.Windows.Forms.RadioButton();
            this.radioButtonDecipher = new System.Windows.Forms.RadioButton();
            this.buttonProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxIn
            // 
            this.richTextBoxIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxIn.Location = new System.Drawing.Point(28, 196);
            this.richTextBoxIn.Name = "richTextBoxIn";
            this.richTextBoxIn.Size = new System.Drawing.Size(1078, 228);
            this.richTextBoxIn.TabIndex = 0;
            this.richTextBoxIn.Text = "";
            this.richTextBoxIn.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // richTextBoxKey
            // 
            this.richTextBoxKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.richTextBoxKey.Location = new System.Drawing.Point(28, 532);
            this.richTextBoxKey.Name = "richTextBoxKey";
            this.richTextBoxKey.Size = new System.Drawing.Size(470, 142);
            this.richTextBoxKey.TabIndex = 1;
            this.richTextBoxKey.Text = "";
            this.richTextBoxKey.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // richTextBoxOut
            // 
            this.richTextBoxOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxOut.Location = new System.Drawing.Point(28, 792);
            this.richTextBoxOut.Name = "richTextBoxOut";
            this.richTextBoxOut.ReadOnly = true;
            this.richTextBoxOut.Size = new System.Drawing.Size(1078, 282);
            this.richTextBoxOut.TabIndex = 2;
            this.richTextBoxOut.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ключ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 717);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат";
            // 
            // radioButtonRailway
            // 
            this.radioButtonRailway.AutoSize = true;
            this.radioButtonRailway.Checked = true;
            this.radioButtonRailway.Location = new System.Drawing.Point(28, 40);
            this.radioButtonRailway.Name = "radioButtonRailway";
            this.radioButtonRailway.Size = new System.Drawing.Size(374, 33);
            this.radioButtonRailway.TabIndex = 1;
            this.radioButtonRailway.TabStop = true;
            this.radioButtonRailway.Text = "Железнодорожная изгородь";
            this.radioButtonRailway.UseVisualStyleBackColor = true;
            this.radioButtonRailway.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonVigener
            // 
            this.radioButtonVigener.AutoSize = true;
            this.radioButtonVigener.Location = new System.Drawing.Point(506, 40);
            this.radioButtonVigener.Name = "radioButtonVigener";
            this.radioButtonVigener.Size = new System.Drawing.Size(408, 33);
            this.radioButtonVigener.TabIndex = 2;
            this.radioButtonVigener.Text = "Виженер (прогрессивный ключ)";
            this.radioButtonVigener.UseVisualStyleBackColor = true;
            this.radioButtonVigener.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainerMain.Panel1.Controls.Add(this.radioButtonRailway);
            this.splitContainerMain.Panel1.Controls.Add(this.radioButtonVigener);
            this.splitContainerMain.Panel1.Controls.Add(this.richTextBoxIn);
            this.splitContainerMain.Panel1.Controls.Add(this.richTextBoxKey);
            this.splitContainerMain.Panel1.Controls.Add(this.label3);
            this.splitContainerMain.Panel1.Controls.Add(this.label1);
            this.splitContainerMain.Panel1.Controls.Add(this.richTextBoxOut);
            this.splitContainerMain.Panel1.Controls.Add(this.label2);
            this.splitContainerMain.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.radioButtonEncipher);
            this.splitContainerMain.Panel2.Controls.Add(this.radioButtonDecipher);
            this.splitContainerMain.Panel2.Controls.Add(this.buttonProcess);
            this.splitContainerMain.Size = new System.Drawing.Size(1747, 1135);
            this.splitContainerMain.SplitterDistance = 1154;
            this.splitContainerMain.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1154, 42);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(90, 38);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.openFileToolStripMenuItem.Text = "Открыть";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Enabled = false;
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.saveFileToolStripMenuItem.Text = "Сохранить";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // radioButtonEncipher
            // 
            this.radioButtonEncipher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonEncipher.AutoSize = true;
            this.radioButtonEncipher.Checked = true;
            this.radioButtonEncipher.Location = new System.Drawing.Point(71, 40);
            this.radioButtonEncipher.Name = "radioButtonEncipher";
            this.radioButtonEncipher.Size = new System.Drawing.Size(208, 33);
            this.radioButtonEncipher.TabIndex = 1;
            this.radioButtonEncipher.TabStop = true;
            this.radioButtonEncipher.Text = "Зашифровать";
            this.radioButtonEncipher.UseVisualStyleBackColor = true;
            this.radioButtonEncipher.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonDecipher
            // 
            this.radioButtonDecipher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDecipher.AutoSize = true;
            this.radioButtonDecipher.Location = new System.Drawing.Point(71, 120);
            this.radioButtonDecipher.Name = "radioButtonDecipher";
            this.radioButtonDecipher.Size = new System.Drawing.Size(212, 33);
            this.radioButtonDecipher.TabIndex = 2;
            this.radioButtonDecipher.TabStop = true;
            this.radioButtonDecipher.Text = "Дешифровать";
            this.radioButtonDecipher.UseVisualStyleBackColor = true;
            this.radioButtonDecipher.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // buttonProcess
            // 
            this.buttonProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcess.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonProcess.Enabled = false;
            this.buttonProcess.Location = new System.Drawing.Point(82, 232);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(328, 102);
            this.buttonProcess.TabIndex = 0;
            this.buttonProcess.Text = "Обработать";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1747, 1135);
            this.Controls.Add(this.splitContainerMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1773, 1159);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAB1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxOut;
        private System.Windows.Forms.RichTextBox richTextBoxIn;
        private System.Windows.Forms.RadioButton radioButtonVigener;
        private System.Windows.Forms.RadioButton radioButtonRailway;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.RadioButton radioButtonEncipher;
        private System.Windows.Forms.RadioButton radioButtonDecipher;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
    }
}

