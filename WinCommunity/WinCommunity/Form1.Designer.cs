namespace WinCommunity
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
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(269, 38);
            label1.TabIndex = 0;
            label1.Text = "Електронна Пошта";
            label1.Click += label1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.Location = new Point(21, 50);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 31);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(117, 38);
            label2.TabIndex = 0;
            label2.Text = "Пароль";
            label2.Click += label1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13F);
            txtPassword.Location = new Point(21, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(260, 31);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientActiveCaption;
            btnLogin.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(64, 64, 64);
            btnLogin.Location = new Point(21, 189);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(118, 46);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Увійти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.GradientActiveCaption;
            btnRegister.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            btnRegister.ForeColor = Color.FromArgb(64, 64, 64);
            btnRegister.Location = new Point(154, 189);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(118, 46);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Почати";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(300, 261);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
    }
}
