namespace Study_Fitness_App_
{
    partial class LoginForm
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
            grbLogin = new GroupBox();
            txbPassword = new TextBox();
            txbEmail = new TextBox();
            btnLogin = new Button();
            grbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // grbLogin
            // 
            grbLogin.Controls.Add(txbPassword);
            grbLogin.Controls.Add(txbEmail);
            grbLogin.Location = new Point(90, 52);
            grbLogin.Name = "grbLogin";
            grbLogin.Size = new Size(250, 136);
            grbLogin.TabIndex = 0;
            grbLogin.TabStop = false;
            grbLogin.Text = "Sign in";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(50, 83);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(149, 27);
            txbPassword.TabIndex = 1;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(50, 36);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(149, 27);
            txbEmail.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(164, 214);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 54);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 310);
            Controls.Add(btnLogin);
            Controls.Add(grbLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            grbLogin.ResumeLayout(false);
            grbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbLogin;
        private TextBox txbPassword;
        private TextBox txbEmail;
        private Button btnLogin;
    }
}