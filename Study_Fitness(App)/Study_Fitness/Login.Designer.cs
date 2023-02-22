namespace Study_Fitness
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
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.txbEmail = new System.Windows.Forms.TextBox();
			this.txbPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(210, 215);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(81, 48);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcome.Location = new System.Drawing.Point(196, 61);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(95, 25);
			this.lblWelcome.TabIndex = 1;
			this.lblWelcome.Text = "Welcome";
			// 
			// txbEmail
			// 
			this.txbEmail.Location = new System.Drawing.Point(166, 116);
			this.txbEmail.Name = "txbEmail";
			this.txbEmail.Size = new System.Drawing.Size(164, 22);
			this.txbEmail.TabIndex = 2;
			// 
			// txbPassword
			// 
			this.txbPassword.Location = new System.Drawing.Point(166, 162);
			this.txbPassword.Name = "txbPassword";
			this.txbPassword.PasswordChar = '*';
			this.txbPassword.Size = new System.Drawing.Size(164, 22);
			this.txbPassword.TabIndex = 3;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 360);
			this.Controls.Add(this.txbPassword);
			this.Controls.Add(this.txbEmail);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.btnLogin);
			this.Name = "LoginForm";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.TextBox txbEmail;
		private System.Windows.Forms.TextBox txbPassword;
	}
}