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
            btnViewAllUsers = new Button();
            btnViewDetails = new Button();
            lbUsers = new ListBox();
            tabAddUser = new TabPage();
            txbPassword = new TextBox();
            btnCreateUser = new Button();
            lblType = new Label();
            cmbType = new ComboBox();
            txbUsername = new TextBox();
            txbFirstName = new TextBox();
            tabEditUser = new TabPage();
            lblNewDifficulty = new Label();
            txbNewUsername = new TextBox();
            lbManageUser = new ListBox();
            btnEditUser = new Button();
            btnDeleteUser = new Button();
            tabTrainerLevel = new TabPage();
            numLevel = new NumericUpDown();
            cmbTrainerName = new ComboBox();
            btnSetLevel = new Button();
            tabConUsers.SuspendLayout();
            tabViewUsers.SuspendLayout();
            tabAddUser.SuspendLayout();
            tabEditUser.SuspendLayout();
            tabTrainerLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLevel).BeginInit();
            SuspendLayout();
            // 
            // tabConUsers
            // 
            tabConUsers.Controls.Add(tabViewUsers);
            tabConUsers.Controls.Add(tabAddUser);
            tabConUsers.Controls.Add(tabEditUser);
            tabConUsers.Controls.Add(tabTrainerLevel);
            tabConUsers.Location = new Point(12, 1);
            tabConUsers.Name = "tabConUsers";
            tabConUsers.SelectedIndex = 0;
            tabConUsers.Size = new Size(632, 357);
            tabConUsers.TabIndex = 1;
            // 
            // tabViewUsers
            // 
            tabViewUsers.Controls.Add(btnViewAllUsers);
            tabViewUsers.Controls.Add(btnViewDetails);
            tabViewUsers.Controls.Add(lbUsers);
            tabViewUsers.Location = new Point(4, 29);
            tabViewUsers.Name = "tabViewUsers";
            tabViewUsers.Padding = new Padding(3);
            tabViewUsers.Size = new Size(624, 324);
            tabViewUsers.TabIndex = 0;
            tabViewUsers.Text = "View All";
            tabViewUsers.UseVisualStyleBackColor = true;
            // 
            // btnViewAllUsers
            // 
            btnViewAllUsers.BackColor = Color.Violet;
            btnViewAllUsers.FlatStyle = FlatStyle.Flat;
            btnViewAllUsers.Location = new Point(409, 104);
            btnViewAllUsers.Name = "btnViewAllUsers";
            btnViewAllUsers.Size = new Size(94, 60);
            btnViewAllUsers.TabIndex = 2;
            btnViewAllUsers.Text = "View All Users";
            btnViewAllUsers.UseVisualStyleBackColor = false;
            btnViewAllUsers.Click += btnViewAllUsers_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.Violet;
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Location = new Point(409, 170);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(94, 60);
            btnViewDetails.TabIndex = 1;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // lbUsers
            // 
            lbUsers.DisplayMember = "Username";
            lbUsers.FormattingEnabled = true;
            lbUsers.ItemHeight = 20;
            lbUsers.Location = new Point(42, 25);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(253, 264);
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
            // tabEditUser
            // 
            tabEditUser.Controls.Add(lblNewDifficulty);
            tabEditUser.Controls.Add(txbNewUsername);
            tabEditUser.Controls.Add(lbManageUser);
            tabEditUser.Controls.Add(btnEditUser);
            tabEditUser.Controls.Add(btnDeleteUser);
            tabEditUser.Location = new Point(4, 29);
            tabEditUser.Name = "tabEditUser";
            tabEditUser.Padding = new Padding(3);
            tabEditUser.Size = new Size(624, 324);
            tabEditUser.TabIndex = 2;
            tabEditUser.Text = "Edit/Delete";
            tabEditUser.UseVisualStyleBackColor = true;
            // 
            // lblNewDifficulty
            // 
            lblNewDifficulty.AutoSize = true;
            lblNewDifficulty.Location = new Point(458, 56);
            lblNewDifficulty.Name = "lblNewDifficulty";
            lblNewDifficulty.Size = new Size(0, 20);
            lblNewDifficulty.TabIndex = 12;
            // 
            // txbNewUsername
            // 
            txbNewUsername.Location = new Point(370, 108);
            txbNewUsername.Name = "txbNewUsername";
            txbNewUsername.PlaceholderText = "New Username";
            txbNewUsername.Size = new Size(125, 27);
            txbNewUsername.TabIndex = 7;
            // 
            // lbManageUser
            // 
            lbManageUser.DisplayMember = "Username";
            lbManageUser.FormattingEnabled = true;
            lbManageUser.ItemHeight = 20;
            lbManageUser.Location = new Point(49, 39);
            lbManageUser.Name = "lbManageUser";
            lbManageUser.Size = new Size(187, 264);
            lbManageUser.TabIndex = 2;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.Violet;
            btnEditUser.FlatStyle = FlatStyle.Flat;
            btnEditUser.Location = new Point(314, 222);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(94, 44);
            btnEditUser.TabIndex = 1;
            btnEditUser.Text = "Edit";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.Violet;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Location = new Point(455, 222);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(94, 44);
            btnDeleteUser.TabIndex = 0;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // tabTrainerLevel
            // 
            tabTrainerLevel.Controls.Add(numLevel);
            tabTrainerLevel.Controls.Add(cmbTrainerName);
            tabTrainerLevel.Controls.Add(btnSetLevel);
            tabTrainerLevel.Location = new Point(4, 29);
            tabTrainerLevel.Name = "tabTrainerLevel";
            tabTrainerLevel.Padding = new Padding(3);
            tabTrainerLevel.Size = new Size(624, 324);
            tabTrainerLevel.TabIndex = 3;
            tabTrainerLevel.Text = "Trainer level";
            tabTrainerLevel.UseVisualStyleBackColor = true;
            // 
            // numLevel
            // 
            numLevel.Location = new Point(242, 142);
            numLevel.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numLevel.Name = "numLevel";
            numLevel.Size = new Size(150, 27);
            numLevel.TabIndex = 2;
            // 
            // cmbTrainerName
            // 
            cmbTrainerName.FormattingEnabled = true;
            cmbTrainerName.Location = new Point(241, 91);
            cmbTrainerName.Name = "cmbTrainerName";
            cmbTrainerName.Size = new Size(151, 28);
            cmbTrainerName.TabIndex = 1;
            // 
            // btnSetLevel
            // 
            btnSetLevel.BackColor = Color.Violet;
            btnSetLevel.FlatStyle = FlatStyle.Flat;
            btnSetLevel.ForeColor = SystemColors.ControlText;
            btnSetLevel.Location = new Point(271, 192);
            btnSetLevel.Name = "btnSetLevel";
            btnSetLevel.Size = new Size(94, 55);
            btnSetLevel.TabIndex = 0;
            btnSetLevel.Text = "Set level";
            btnSetLevel.UseVisualStyleBackColor = false;
            btnSetLevel.Click += btnSetLevel_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(673, 370);
            Controls.Add(tabConUsers);
            Name = "UserForm";
            Text = "UserForm";
            tabConUsers.ResumeLayout(false);
            tabViewUsers.ResumeLayout(false);
            tabAddUser.ResumeLayout(false);
            tabAddUser.PerformLayout();
            tabEditUser.ResumeLayout(false);
            tabEditUser.PerformLayout();
            tabTrainerLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numLevel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabConUsers;
        private TabPage tabViewUsers;
        private Button btnViewAllUsers;
        private Button btnViewDetails;
        private ListBox lbUsers;
        private TabPage tabAddUser;
        private Button btnCreateUser;
        private Label lblType;
        private ComboBox cmbType;
        private TextBox txbUsername;
        private TextBox txbFirstName;
        private TabPage tabEditUser;
        private Label lblNewDifficulty;
        private Label lblNewCalories;
        private ComboBox cmbNewDifficulty;
        private NumericUpDown numNewCalories;
        private TextBox txbNewPicURL;
        private TextBox txbNewUsername;
        private ListBox lbManageUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private TextBox txbPassword;
        private TabPage tabTrainerLevel;
        private ComboBox cmbTrainerName;
        private Button btnSetLevel;
        private NumericUpDown numLevel;
    }
}