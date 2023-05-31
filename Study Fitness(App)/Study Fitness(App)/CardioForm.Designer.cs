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
            tabFunctions = new TabControl();
            tabViewDetailsAndDelete = new TabPage();
            btnDelete = new Button();
            btnViewDetails = new Button();
            tabEdit = new TabPage();
            btnEdit = new Button();
            lblNewDifficulty = new Label();
            lblNewCalories = new Label();
            cmbNewDifficulty = new ComboBox();
            numNewCalories = new NumericUpDown();
            txbNewPicURL = new TextBox();
            txbNewName = new TextBox();
            btnNext = new Button();
            btnPrevious = new Button();
            txbSearchBar = new TextBox();
            btnSearch = new Button();
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
            tabConCardio.SuspendLayout();
            tabViewCardio.SuspendLayout();
            tabFunctions.SuspendLayout();
            tabViewDetailsAndDelete.SuspendLayout();
            tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNewCalories).BeginInit();
            tabAddCardio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCalories).BeginInit();
            SuspendLayout();
            // 
            // tabConCardio
            // 
            tabConCardio.Controls.Add(tabViewCardio);
            tabConCardio.Controls.Add(tabAddCardio);
            tabConCardio.Location = new Point(12, 12);
            tabConCardio.Name = "tabConCardio";
            tabConCardio.SelectedIndex = 0;
            tabConCardio.Size = new Size(632, 346);
            tabConCardio.TabIndex = 0;
            // 
            // tabViewCardio
            // 
            tabViewCardio.Controls.Add(tabFunctions);
            tabViewCardio.Controls.Add(btnNext);
            tabViewCardio.Controls.Add(btnPrevious);
            tabViewCardio.Controls.Add(txbSearchBar);
            tabViewCardio.Controls.Add(btnSearch);
            tabViewCardio.Controls.Add(lbCardios);
            tabViewCardio.Location = new Point(4, 29);
            tabViewCardio.Name = "tabViewCardio";
            tabViewCardio.Padding = new Padding(3);
            tabViewCardio.Size = new Size(624, 313);
            tabViewCardio.TabIndex = 0;
            tabViewCardio.Text = "View All";
            tabViewCardio.UseVisualStyleBackColor = true;
            // 
            // tabFunctions
            // 
            tabFunctions.Controls.Add(tabViewDetailsAndDelete);
            tabFunctions.Controls.Add(tabEdit);
            tabFunctions.Location = new Point(332, 39);
            tabFunctions.Name = "tabFunctions";
            tabFunctions.SelectedIndex = 0;
            tabFunctions.Size = new Size(286, 245);
            tabFunctions.TabIndex = 9;
            // 
            // tabViewDetailsAndDelete
            // 
            tabViewDetailsAndDelete.Controls.Add(btnDelete);
            tabViewDetailsAndDelete.Controls.Add(btnViewDetails);
            tabViewDetailsAndDelete.Location = new Point(4, 29);
            tabViewDetailsAndDelete.Name = "tabViewDetailsAndDelete";
            tabViewDetailsAndDelete.Padding = new Padding(3);
            tabViewDetailsAndDelete.Size = new Size(278, 212);
            tabViewDetailsAndDelete.TabIndex = 0;
            tabViewDetailsAndDelete.Text = "Details/Delete";
            tabViewDetailsAndDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Violet;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(151, 79);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 60);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.Violet;
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Location = new Point(32, 79);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(94, 60);
            btnViewDetails.TabIndex = 1;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // tabEdit
            // 
            tabEdit.Controls.Add(btnEdit);
            tabEdit.Controls.Add(lblNewDifficulty);
            tabEdit.Controls.Add(lblNewCalories);
            tabEdit.Controls.Add(cmbNewDifficulty);
            tabEdit.Controls.Add(numNewCalories);
            tabEdit.Controls.Add(txbNewPicURL);
            tabEdit.Controls.Add(txbNewName);
            tabEdit.Location = new Point(4, 29);
            tabEdit.Name = "tabEdit";
            tabEdit.Padding = new Padding(3);
            tabEdit.Size = new Size(278, 212);
            tabEdit.TabIndex = 1;
            tabEdit.Text = "Edit";
            tabEdit.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Violet;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(191, 83);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(69, 44);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblNewDifficulty
            // 
            lblNewDifficulty.AutoSize = true;
            lblNewDifficulty.Location = new Point(26, 60);
            lblNewDifficulty.Name = "lblNewDifficulty";
            lblNewDifficulty.Size = new Size(110, 20);
            lblNewDifficulty.TabIndex = 18;
            lblNewDifficulty.Text = "New Difficulty :";
            // 
            // lblNewCalories
            // 
            lblNewCalories.AutoSize = true;
            lblNewCalories.Location = new Point(29, 114);
            lblNewCalories.Name = "lblNewCalories";
            lblNewCalories.Size = new Size(103, 20);
            lblNewCalories.TabIndex = 17;
            lblNewCalories.Text = "New Calories :";
            // 
            // cmbNewDifficulty
            // 
            cmbNewDifficulty.FormattingEnabled = true;
            cmbNewDifficulty.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced", "Athlete" });
            cmbNewDifficulty.Location = new Point(29, 83);
            cmbNewDifficulty.Name = "cmbNewDifficulty";
            cmbNewDifficulty.Size = new Size(125, 28);
            cmbNewDifficulty.TabIndex = 16;
            // 
            // numNewCalories
            // 
            numNewCalories.Location = new Point(29, 137);
            numNewCalories.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numNewCalories.Name = "numNewCalories";
            numNewCalories.Size = new Size(125, 27);
            numNewCalories.TabIndex = 15;
            // 
            // txbNewPicURL
            // 
            txbNewPicURL.Location = new Point(29, 170);
            txbNewPicURL.Name = "txbNewPicURL";
            txbNewPicURL.PlaceholderText = "PictureURL";
            txbNewPicURL.Size = new Size(125, 27);
            txbNewPicURL.TabIndex = 14;
            // 
            // txbNewName
            // 
            txbNewName.Location = new Point(26, 30);
            txbNewName.Name = "txbNewName";
            txbNewName.PlaceholderText = "Name";
            txbNewName.Size = new Size(125, 27);
            txbNewName.TabIndex = 13;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Violet;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Location = new Point(183, 264);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 34);
            btnNext.TabIndex = 8;
            btnNext.Text = "next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Violet;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Location = new Point(42, 264);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 34);
            btnPrevious.TabIndex = 7;
            btnPrevious.Text = "previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // txbSearchBar
            // 
            txbSearchBar.Location = new Point(33, 26);
            txbSearchBar.Name = "txbSearchBar";
            txbSearchBar.Size = new Size(164, 27);
            txbSearchBar.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Violet;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(203, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(83, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbCardios
            // 
            lbCardios.DisplayMember = "Name";
            lbCardios.FormattingEnabled = true;
            lbCardios.ItemHeight = 20;
            lbCardios.Location = new Point(33, 74);
            lbCardios.Name = "lbCardios";
            lbCardios.Size = new Size(253, 184);
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
            // CardioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(673, 370);
            Controls.Add(tabConCardio);
            Name = "CardioForm";
            Text = "CardioForm";
            tabConCardio.ResumeLayout(false);
            tabViewCardio.ResumeLayout(false);
            tabViewCardio.PerformLayout();
            tabFunctions.ResumeLayout(false);
            tabViewDetailsAndDelete.ResumeLayout(false);
            tabEdit.ResumeLayout(false);
            tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNewCalories).EndInit();
            tabAddCardio.ResumeLayout(false);
            tabAddCardio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCalories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabConCardio;
        private TabPage tabViewCardio;
        private Button btnViewDetails;
        private ListBox lbCardios;
        private TabPage tabAddCardio;
        private ComboBox cmbDifficulty;
        private NumericUpDown numCalories;
        private TextBox txbPictureURL;
        private TextBox txbName;
        private Button btnCreateCardio;
        private Label lblDifficulty;
        private Label lblCalories;
        private Button btnBrowseImage;
        private Button btnSaveFileImage;
        private Button btnSearch;
        private TextBox txbSearchBar;
        private Button btnNext;
        private Button btnPrevious;
        private TabControl tabFunctions;
        private TabPage tabViewDetailsAndDelete;
        private TabPage tabEdit;
        private Button btnEdit;
        private Label lblNewDifficulty;
        private Label lblNewCalories;
        private ComboBox cmbNewDifficulty;
        private NumericUpDown numNewCalories;
        private TextBox txbNewPicURL;
        private TextBox txbNewName;
        private Button btnDelete;
    }
}