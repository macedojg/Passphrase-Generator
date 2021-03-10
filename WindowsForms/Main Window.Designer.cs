
namespace WindowsForms
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
            this.Generate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.passphraseSize = new System.Windows.Forms.RichTextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.capitalizeBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(207, 63);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(169, 23);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Generate Password";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 16);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Choose the number of words in your passphrase:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // passphraseSize
            // 
            this.passphraseSize.Location = new System.Drawing.Point(272, 9);
            this.passphraseSize.MaxLength = 2;
            this.passphraseSize.Name = "passphraseSize";
            this.passphraseSize.Size = new System.Drawing.Size(30, 23);
            this.passphraseSize.TabIndex = 2;
            this.passphraseSize.Text = "";
            this.passphraseSize.TextChanged += new System.EventHandler(this.passphraseSize_TextChanged);
            // 
            // resultBox
            // 
            this.resultBox.AcceptsReturn = true;
            this.resultBox.Location = new System.Drawing.Point(85, 34);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(512, 23);
            this.resultBox.TabIndex = 3;
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 16);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Passphrase:";
            // 
            // capitalizeBox
            // 
            this.capitalizeBox.AutoSize = true;
            this.capitalizeBox.Location = new System.Drawing.Point(12, 67);
            this.capitalizeBox.Name = "capitalizeBox";
            this.capitalizeBox.Size = new System.Drawing.Size(77, 19);
            this.capitalizeBox.TabIndex = 5;
            this.capitalizeBox.Text = "Capitalize";
            this.capitalizeBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 95);
            this.Controls.Add(this.capitalizeBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.passphraseSize);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Generate);
            this.Name = "Form1";
            this.Text = "Passphrase Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox passphraseSize;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox capitalizeBox;
    }
}

