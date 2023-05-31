namespace Study_Fitness_App_
{
    partial class UserForm
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
            tabConUsers = new TabControl();
            tabViewUsers = new TabPage();
            tabFunctions = new TabControl();
            tabViewDetails = new TabPage();
            btnViewDetails = new Button();
            tabModify = new TabPage();
            txbNewUsername = new TextBox();
            btnEditUser = new Button();
            btnDeleteUser = new Button();
            tabTrainer = new TabPage();
            btnSetLevel = new Button();
            numLevel = new NumericUpDown();
            btnNext = new Button();
            btnPrevious = new Button();
            lbUsers = new ListBox();
            tabAddUser = new TabPage();
            txbPassword = new TextBox();
            btnCreateUser = new Button();
            lblType = new Label();
            cmbType = new ComboBox();
            txbUsername = new TextBox();
            txbFirstName = new TextBox();
            tabConUsers.SuspendLayout();
            tabViewUsers.SuspendLayout();
            tabFunctions.SuspendLayout();
            tabViewDetails.SuspendLayout();
            tabModify.SuspendLayout();
            tabTrainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLevel).BeginInit();
            tabAddUser.SuspendLayout();
            SuspendLayout();
            // 
            // tabConUsers
            // 
            tabConUsers.Controls.Add(tabViewUsers);
            tabConUsers.Controls.Add(tabAddUser);
            tabConUsers.Location = new Point(12, 1);
            tabConUsers.Name = "tabConUsers";
            tabConUsers.SelectedIndex = 0;
            tabConUsers.Size = new Size(632, 357);
            tabConUsers.TabIndex = 1;
            // 
            // tabViewUsers
            // 
            tabViewUsers.Controls.Add(tabFunctions);
            tabViewUsers.Controls.Add(btnNext);
            tabViewUsers.Controls.Add(btnPrevious);
            tabViewUsers.Controls.Add(lbUsers);
            tabViewUsers.Location = new Point(4, 29);
            tabViewUsers.Name = "tabViewUsers";
            tabViewUsers.Padding = new Padding(3);
            tabViewUsers.Size = new Size(624, 324);
            tabViewUsers.TabIndex = 0;
            tabViewUsers.Text = "View All";
            tabViewUsers.UseVisualStyleBackColor = true;
            // 
            // tabFunctions
            // 
            tabFunctions.Controls.Add(tabViewDetails);
            tabFunctions.Controls.Add(tabModify);
            tabFunctions.Controls.Add(tabTrainer);
            tabFunctions.Location = new Point(349, 54);
            tabFunctions.Name = "tabFunctions";
            tabFunctions.SelectedIndex = 0;
            tabFunctions.Size = new Size(250, 192);
            tabFunctions.TabIndex = 5;
            // 
            // tabViewDetails
            // 
            tabViewDetails.Controls.Add(btnViewDetails);
            tabViewDetails.Location = new Point(4, 29);
            tabViewDetails.Name = "tabViewDetails";
            tabViewDetails.Padding = new Padding(3);
            tabViewDetails.Size = new Size(242, 159);
            tabViewDetails.TabIndex = 0;
            tabViewDetails.Text = "Details";
            tabViewDetails.UseVisualStyleBackColor = true;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.Violet;
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Location = new Point(70, 39);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(93, 50);
            btnViewDetails.TabIndex = 1;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // tabModify
            // 
            tabModify.Controls.Add(txbNewUsername);
            tabModify.Controls.Add(btnEditUser);
            tabModify.Controls.Add(btnDeleteUser);
            tabModify.Location = new Point(4, 29);
            tabModify.Name = "tabModify";
            tabModify.Padding = new Padding(3);
            tabModify.Size = new Size(242, 159);
            tabModify.TabIndex = 1;
            tabModify.Text = "Edit/Delete";
            tabModify.UseVisualStyleBackColor = true;
            // 
            // txbNewUsername
            // 
            txbNewUsername.Location = new Point(50, 19);
            txbNewUsername.Name = "txbNewUsername";
            txbNewUsername.PlaceholderText = "New Username";
            txbNewUsername.Size = new Size(125, 27);
            txbNewUsername.TabIndex = 8;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.Violet;
            btnEditUser.FlatStyle = FlatStyle.Flat;
            btnEditUser.Location = new Point(70, 52);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(94, 44);
            btnEditUser.TabIndex = 3;
            btnEditUser.Text = "Edit";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.Violet;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Location = new Point(70, 102);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(94, 44);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // tabTrainer
            // 
            tabTrainer.Controls.Add(btnSetLevel);
            tabTrainer.Controls.Add(numLevel);
            tabTrainer.Location = new Point(4, 29);
            tabTrainer.Name = "tabTrainer";
            tabTrainer.Padding = new Padding(3);
            tabTrainer.Size = new Size(242, 159);
            tabTrainer.TabIndex = 2;
            tabTrainer.Text = "Trainer Level";
            tabTrainer.UseVisualStyleBackColor = true;
            // 
            // btnSetLevel
            // 
            btnSetLevel.BackColor = Color.Violet;
            btnSetLevel.FlatStyle = FlatStyle.Flat;
            btnSetLevel.Location = new Point(70, 81);
            btnSetLevel.Name = "btnSetLevel";
            btnSetLevel.Size = new Size(93, 50);
            btnSetLevel.TabIndex = 6;
            btnSetLevel.Text = "Set Level";
            btnSetLevel.UseVisualStyleBackColor = false;
            btnSetLevel.Click += btnSetLevel_Click;
            // 
            // numLevel
            // 
            numLevel.Location = new Point(47, 34);
            numLevel.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numLevel.Name = "numLevel";
            numLevel.Size = new Size(150, 27);
            numLevel.TabIndex = 5;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Violet;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Location = new Point(186, 252);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 34);
            btnNext.TabIndex = 4;
            btnNext.Text = "next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Violet;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Location = new Point(57, 252);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 34);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lbUsers
            // 
            lbUsers.DisplayMember = "Username";
            lbUsers.FormattingEnabled = true;
            lbUsers.ItemHeight = 20;
            lbUsers.Location = new Point(40, 45);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(253, 184);
            lbUsers.TabIndex = 0;
            // 
            // tabAddUser
            // 
            tabAddUser.Controls.Add(txbPassword);
            tabAddUser.Controls.Add(btnCreateUser);
            tabAddUser.Controls.Add(lblType);
            tabAddUser.Controls.Add(cmbType);
            tabAddUser.Controls.Add(txbUsername);
            tabAddUser.Controls.Add(txbFirstName);
            tabAddUser.Location = new Point(4, 29);
            tabAddUser.Name = "tabAddUser";
            tabAddUser.Padding = new Padding(3);
            tabAddUser.Size = new Size(624, 324);
            tabAddUser.TabIndex = 1;
            tabAddUser.Text = "Add";
            tabAddUser.UseVisualStyleBackColor = true;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(107, 137);
            txbPassword.Name = "txbPassword";
            txbPassword.PlaceholderText = "Password";
            txbPassword.Size = new Size(125, 27);
            txbPassword.TabIndex = 8;
            // 
            // btnCreateUser
            // 
            btnCreateUser.BackColor = Color.Violet;
            btnCreateUser.FlatStyle = FlatStyle.Flat;
            btnCreateUser.Location = new Point(259, 196);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(94, 54);
            btnCreateUser.TabIndex = 7;
            btnCreateUser.Text = "Create";
            btnCreateUser.UseVisualStyleBackColor = false;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(325, 140);
            lblType.Name = "lblType";
            lblType.Size = new Size(47, 20);
            lblType.TabIndex = 6;
            lblType.Text = "Type :";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Admin", "Trainer", "Member" });
            cmbType.Location = new Point(378, 137);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(126, 28);
            cmbType.TabIndex = 4;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(107, 85);
            txbUsername.Name = "txbUsername";
            txbUsername.PlaceholderText = "Username";
            txbUsername.Size = new Size(125, 27);
            txbUsername.TabIndex = 1;
            // 
            // txbFirstName
            // 
            txbFirstName.Location = new Point(379, 86);
            txbFirstName.Name = "txbFirstName";
            txbFirstName.PlaceholderText = "First Name";
            txbFirstName.Size = new Size(125, 27);
            txbFirstName.TabIndex = 0;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(673, 370);
            Controls.Add(tabConUsers);
            Name = "UserForm";
            Text = "UserForm";
            tabConUsers.ResumeLayout(false);
            tabViewUsers.ResumeLayout(false);
            tabFunctions.ResumeLayout(false);
            tabViewDetails.ResumeLayout(false);
            tabModify.ResumeLayout(false);
            tabModify.PerformLayout();
            tabTrainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numLevel).EndInit();
            tabAddUser.ResumeLayout(false);
            tabAddUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabConUsers;
        private TabPage tabViewUsers;
        private Button btnViewDetails;
        private ListBox lbUsers;
        private TabPage tabAddUser;
        private Button btnCreateUser;
        private Label lblType;
        private ComboBox cmbType;
        private TextBox txbUsername;
        private TextBox txbFirstName;
        private Label lblNewCalories;
        private ComboBox cmbNewDifficulty;
        private NumericUpDown numNewCalories;
        private TextBox txbNewPicURL;
        private TextBox txbPassword;
        private Button btnNext;
        private Button btnPrevious;
        private TabControl tabFunctions;
        private TabPage tabViewDetails;
        private TabPage tabModify;
        private TextBox txbNewUsername;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private TabPage tabTrainer;
        private NumericUpDown numLevel;
        private Button btnSetLevel;
    }
}