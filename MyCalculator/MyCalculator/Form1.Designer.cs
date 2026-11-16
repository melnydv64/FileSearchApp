namespace MyCalculator
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
            BtnOk = new Button();
            txtFileContent = new TextBox();
            label1 = new Label();
            txtFilePath = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(312, 29);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(207, 57);
            BtnOk.TabIndex = 0;
            BtnOk.Text = "Нажми мене!";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(12, 103);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.Size = new Size(776, 335);
            txtFileContent.TabIndex = 1;
            txtFileContent.TextChanged += txtMyInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Шлях до файлу";
            label1.Click += label1_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(12, 47);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(256, 23);
            txtFilePath.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 4;
            label2.Text = "Вміст файлу";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtFilePath);
            Controls.Add(label1);
            Controls.Add(txtFileContent);
            Controls.Add(BtnOk);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnOk;
        private TextBox txtFileContent;
        private Label label1;
        private TextBox txtFilePath;
        private Label label2;
    }
}
