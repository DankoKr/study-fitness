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
            txbPassword = new TextBox();
            txbUsername = new TextBox();
            btnLogin = new Button();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(152, 154);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.PlaceholderText = "Password";
            txbPassword.Size = new Size(149, 27);
            txbPassword.TabIndex = 1;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(152, 97);
            txbUsername.Name = "txbUsername";
            txbUsername.PlaceholderText = "Username";
            txbUsername.Size = new Size(149, 27);
            txbUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Violet;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(180, 213);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 54);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblLogin.Location = new Point(200, 39);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(62, 28);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(444, 310);
            Controls.Add(lblLogin);
            Controls.Add(txbPassword);
            Controls.Add(btnLogin);
            Controls.Add(txbUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txbPassword;
        private TextBox txbUsername;
        private Button btnLogin;
        private Label lblLogin;
    }
}