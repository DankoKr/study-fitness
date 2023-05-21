namespace Study_Fitness_App_
{
    partial class CardioForm
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
            tabConCardio = new TabControl();
            tabViewCardio = new TabPage();
            btnViewAllCardios = new Button();
            btnViewDetails = new Button();
            lbCardios = new ListBox();
            tabAddCardio = new TabPage();
            btnSaveFileImage = new Button();
            btnBrowseImage = new Button();
            btnCreateCardio = new Button();
            lblDifficulty = new Label();
            lblCalories = new Label();
            cmbDifficulty = new ComboBox();
            numCalories = new NumericUpDown();
            txbPictureURL = new TextBox();
            txbName = new TextBox();
            tabEditCardio = new TabPage();
            lblNewDifficulty = new Label();
            lblNewCalories = new Label();
            cmbNewDifficulty = new ComboBox();
            numNewCalories = new NumericUpDown();
            txbNewPicURL = new TextBox();
            txbNewName = new TextBox();
            lbManageCardio = new ListBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txbSearchBar = new TextBox();
            tabConCardio.SuspendLayout();
            tabViewCardio.SuspendLayout();
            tabAddCardio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCalories).BeginInit();
            tabEditCardio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNewCalories).BeginInit();
            SuspendLayout();
            // 
            // tabConCardio
            // 
            tabConCardio.Controls.Add(tabViewCardio);
            tabConCardio.Controls.Add(tabAddCardio);
            tabConCardio.Controls.Add(tabEditCardio);
            tabConCardio.Location = new Point(12, 12);
            tabConCardio.Name = "tabConCardio";
            tabConCardio.SelectedIndex = 0;
            tabConCardio.Size = new Size(632, 346);
            tabConCardio.TabIndex = 0;
            // 
            // tabViewCardio
            // 
            tabViewCardio.Controls.Add(txbSearchBar);
            tabViewCardio.Controls.Add(btnSearch);
            tabViewCardio.Controls.Add(btnViewAllCardios);
            tabViewCardio.Controls.Add(btnViewDetails);
            tabViewCardio.Controls.Add(lbCardios);
            tabViewCardio.Location = new Point(4, 29);
            tabViewCardio.Name = "tabViewCardio";
            tabViewCardio.Padding = new Padding(3);
            tabViewCardio.Size = new Size(624, 313);
            tabViewCardio.TabIndex = 0;
            tabViewCardio.Text = "View All";
            tabViewCardio.UseVisualStyleBackColor = true;
            // 
            // btnViewAllCardios
            // 
            btnViewAllCardios.BackColor = Color.Violet;
            btnViewAllCardios.FlatStyle = FlatStyle.Flat;
            btnViewAllCardios.Location = new Point(409, 104);
            btnViewAllCardios.Name = "btnViewAllCardios";
            btnViewAllCardios.Size = new Size(94, 60);
            btnViewAllCardios.TabIndex = 2;
            btnViewAllCardios.Text = "View All Cardios";
            btnViewAllCardios.UseVisualStyleBackColor = false;
            btnViewAllCardios.Click += btnViewAllCardios_Click;
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
            // lbCardios
            // 
            lbCardios.DisplayMember = "Name";
            lbCardios.FormattingEnabled = true;
            lbCardios.ItemHeight = 20;
            lbCardios.Location = new Point(42, 25);
            lbCardios.Name = "lbCardios";
            lbCardios.Size = new Size(253, 264);
            lbCardios.TabIndex = 0;
            // 
            // tabAddCardio
            // 
            tabAddCardio.Controls.Add(btnSaveFileImage);
            tabAddCardio.Controls.Add(btnBrowseImage);
            tabAddCardio.Controls.Add(btnCreateCardio);
            tabAddCardio.Controls.Add(lblDifficulty);
            tabAddCardio.Controls.Add(lblCalories);
            tabAddCardio.Controls.Add(cmbDifficulty);
            tabAddCardio.Controls.Add(numCalories);
            tabAddCardio.Controls.Add(txbPictureURL);
            tabAddCardio.Controls.Add(txbName);
            tabAddCardio.Location = new Point(4, 29);
            tabAddCardio.Name = "tabAddCardio";
            tabAddCardio.Padding = new Padding(3);
            tabAddCardio.Size = new Size(624, 313);
            tabAddCardio.TabIndex = 1;
            tabAddCardio.Text = "Add";
            tabAddCardio.UseVisualStyleBackColor = true;
            // 
            // btnSaveFileImage
            // 
            btnSaveFileImage.BackColor = Color.Violet;
            btnSaveFileImage.FlatStyle = FlatStyle.Flat;
            btnSaveFileImage.Location = new Point(414, 198);
            btnSaveFileImage.Name = "btnSaveFileImage";
            btnSaveFileImage.Size = new Size(94, 54);
            btnSaveFileImage.TabIndex = 9;
            btnSaveFileImage.Text = "Save File Image";
            btnSaveFileImage.UseVisualStyleBackColor = false;
            btnSaveFileImage.Click += btnSaveFileImage_Click;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.BackColor = Color.Violet;
            btnBrowseImage.FlatStyle = FlatStyle.Flat;
            btnBrowseImage.Location = new Point(275, 198);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(94, 54);
            btnBrowseImage.TabIndex = 8;
            btnBrowseImage.Text = "Browse Image";
            btnBrowseImage.UseVisualStyleBackColor = false;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // btnCreateCardio
            // 
            btnCreateCardio.BackColor = Color.Violet;
            btnCreateCardio.FlatStyle = FlatStyle.Flat;
            btnCreateCardio.Location = new Point(130, 198);
            btnCreateCardio.Name = "btnCreateCardio";
            btnCreateCardio.Size = new Size(94, 54);
            btnCreateCardio.TabIndex = 7;
            btnCreateCardio.Text = "Create";
            btnCreateCardio.UseVisualStyleBackColor = false;
            btnCreateCardio.Click += btnCreateCardio_Click;
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Location = new Point(293, 71);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(76, 20);
            lblDifficulty.TabIndex = 6;
            lblDifficulty.Text = "Difficulty :";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Location = new Point(31, 126);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(69, 20);
            lblCalories.TabIndex = 5;
            lblCalories.Text = "Calories :";
            // 
            // cmbDifficulty
            // 
            cmbDifficulty.FormattingEnabled = true;
            cmbDifficulty.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced", "Athlete" });
            cmbDifficulty.Location = new Point(375, 67);
            cmbDifficulty.Name = "cmbDifficulty";
            cmbDifficulty.Size = new Size(151, 28);
            cmbDifficulty.TabIndex = 4;
            // 
            // numCalories
            // 
            numCalories.Location = new Point(106, 123);
            numCalories.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCalories.Name = "numCalories";
            numCalories.Size = new Size(150, 27);
            numCalories.TabIndex = 3;
            // 
            // txbPictureURL
            // 
            txbPictureURL.Location = new Point(375, 123);
            txbPictureURL.Name = "txbPictureURL";
            txbPictureURL.PlaceholderText = "PictureURL";
            txbPictureURL.Size = new Size(125, 27);
            txbPictureURL.TabIndex = 1;
            // 
            // txbName
            // 
            txbName.Location = new Point(106, 68);
            txbName.Name = "txbName";
            txbName.PlaceholderText = "Name";
            txbName.Size = new Size(125, 27);
            txbName.TabIndex = 0;
            // 
            // tabEditCardio
            // 
            tabEditCardio.Controls.Add(lblNewDifficulty);
            tabEditCardio.Controls.Add(lblNewCalories);
            tabEditCardio.Controls.Add(cmbNewDifficulty);
            tabEditCardio.Controls.Add(numNewCalories);
            tabEditCardio.Controls.Add(txbNewPicURL);
            tabEditCardio.Controls.Add(txbNewName);
            tabEditCardio.Controls.Add(lbManageCardio);
            tabEditCardio.Controls.Add(btnEdit);
            tabEditCardio.Controls.Add(btnDelete);
            tabEditCardio.Location = new Point(4, 29);
            tabEditCardio.Name = "tabEditCardio";
            tabEditCardio.Padding = new Padding(3);
            tabEditCardio.Size = new Size(624, 313);
            tabEditCardio.TabIndex = 2;
            tabEditCardio.Text = "Edit/Delete";
            tabEditCardio.UseVisualStyleBackColor = true;
            // 
            // lblNewDifficulty
            // 
            lblNewDifficulty.AutoSize = true;
            lblNewDifficulty.Location = new Point(455, 53);
            lblNewDifficulty.Name = "lblNewDifficulty";
            lblNewDifficulty.Size = new Size(110, 20);
            lblNewDifficulty.TabIndex = 12;
            lblNewDifficulty.Text = "New Difficulty :";
            // 
            // lblNewCalories
            // 
            lblNewCalories.AutoSize = true;
            lblNewCalories.Location = new Point(283, 126);
            lblNewCalories.Name = "lblNewCalories";
            lblNewCalories.Size = new Size(103, 20);
            lblNewCalories.TabIndex = 11;
            lblNewCalories.Text = "New Calories :";
            // 
            // cmbNewDifficulty
            // 
            cmbNewDifficulty.FormattingEnabled = true;
            cmbNewDifficulty.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced", "Athlete" });
            cmbNewDifficulty.Location = new Point(455, 76);
            cmbNewDifficulty.Name = "cmbNewDifficulty";
            cmbNewDifficulty.Size = new Size(125, 28);
            cmbNewDifficulty.TabIndex = 10;
            // 
            // numNewCalories
            // 
            numNewCalories.Location = new Point(283, 149);
            numNewCalories.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numNewCalories.Name = "numNewCalories";
            numNewCalories.Size = new Size(125, 27);
            numNewCalories.TabIndex = 9;
            // 
            // txbNewPicURL
            // 
            txbNewPicURL.Location = new Point(455, 149);
            txbNewPicURL.Name = "txbNewPicURL";
            txbNewPicURL.PlaceholderText = "PictureURL";
            txbNewPicURL.Size = new Size(125, 27);
            txbNewPicURL.TabIndex = 8;
            // 
            // txbNewName
            // 
            txbNewName.Location = new Point(283, 76);
            txbNewName.Name = "txbNewName";
            txbNewName.PlaceholderText = "Name";
            txbNewName.Size = new Size(125, 27);
            txbNewName.TabIndex = 7;
            // 
            // lbManageCardio
            // 
            lbManageCardio.DisplayMember = "Name";
            lbManageCardio.FormattingEnabled = true;
            lbManageCardio.ItemHeight = 20;
            lbManageCardio.Location = new Point(49, 39);
            lbManageCardio.Name = "lbManageCardio";
            lbManageCardio.Size = new Size(150, 264);
            lbManageCardio.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Violet;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(314, 222);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 44);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Violet;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(455, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 44);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Violet;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(503, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txbSearchBar
            // 
            txbSearchBar.Location = new Point(329, 38);
            txbSearchBar.Name = "txbSearchBar";
            txbSearchBar.Size = new Size(168, 27);
            txbSearchBar.TabIndex = 4;
            // 
            // CardioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(673, 370);
            Controls.Add(tabConCardio);
            Name = "CardioForm";
            Text = "CardioForm";
            tabConCardio.ResumeLayout(false);
            tabViewCardio.ResumeLayout(false);
            tabViewCardio.PerformLayout();
            tabAddCardio.ResumeLayout(false);
            tabAddCardio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCalories).EndInit();
            tabEditCardio.ResumeLayout(false);
            tabEditCardio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNewCalories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabConCardio;
        private TabPage tabViewCardio;
        private Button btnViewDetails;
        private ListBox lbCardios;
        private TabPage tabAddCardio;
        private TabPage tabEditCardio;
        private ComboBox cmbDifficulty;
        private NumericUpDown numCalories;
        private TextBox txbPictureURL;
        private TextBox txbName;
        private Button btnCreateCardio;
        private Label lblDifficulty;
        private Label lblCalories;
        private ListBox lbManageCardio;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblNewDifficulty;
        private Label lblNewCalories;
        private ComboBox cmbNewDifficulty;
        private NumericUpDown numNewCalories;
        private TextBox txbNewPicURL;
        private TextBox txbNewName;
        private Button btnViewAllCardios;
        private Button btnBrowseImage;
        private Button btnSaveFileImage;
        private Button btnSearch;
        private TextBox txbSearchBar;
    }
}