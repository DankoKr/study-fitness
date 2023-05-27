namespace Study_Fitness_App_
{
    partial class AppForm
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
            tabconExercises = new TabControl();
            tabAllExercises = new TabPage();
            txbSearchBar = new TextBox();
            tabconManageExercise = new TabControl();
            tabEditExercise = new TabPage();
            cmbNewDifficulty = new ComboBox();
            btnEdit = new Button();
            txbNewWeight = new TextBox();
            txbNewReps = new TextBox();
            tabDeleteAndViewExercise = new TabPage();
            btnDelete = new Button();
            btnViewDetails = new Button();
            tabSortExercises = new TabPage();
            btnSortDescendingName = new Button();
            btnSortExName = new Button();
            btnCustomCompare = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            lbExercises = new ListBox();
            btnSearch = new Button();
            tabAddExercise = new TabPage();
            btnCreateExercise = new Button();
            grbSpecifics = new GroupBox();
            txbPicture = new TextBox();
            txbSpecialty = new TextBox();
            grbInformation = new GroupBox();
            lblDifficulty = new Label();
            lblTypeEx = new Label();
            txbWeight = new TextBox();
            txbNumReps = new TextBox();
            txbEquipment = new TextBox();
            txbName = new TextBox();
            cmbDifficulty = new ComboBox();
            cmbTypeEx = new ComboBox();
            tabconExercises.SuspendLayout();
            tabAllExercises.SuspendLayout();
            tabconManageExercise.SuspendLayout();
            tabEditExercise.SuspendLayout();
            tabDeleteAndViewExercise.SuspendLayout();
            tabSortExercises.SuspendLayout();
            tabAddExercise.SuspendLayout();
            grbSpecifics.SuspendLayout();
            grbInformation.SuspendLayout();
            SuspendLayout();
            // 
            // tabconExercises
            // 
            tabconExercises.Controls.Add(tabAllExercises);
            tabconExercises.Controls.Add(tabAddExercise);
            tabconExercises.Location = new Point(12, 12);
            tabconExercises.Name = "tabconExercises";
            tabconExercises.SelectedIndex = 0;
            tabconExercises.Size = new Size(649, 351);
            tabconExercises.TabIndex = 0;
            // 
            // tabAllExercises
            // 
            tabAllExercises.Controls.Add(txbSearchBar);
            tabAllExercises.Controls.Add(tabconManageExercise);
            tabAllExercises.Controls.Add(btnNext);
            tabAllExercises.Controls.Add(btnPrevious);
            tabAllExercises.Controls.Add(lbExercises);
            tabAllExercises.Controls.Add(btnSearch);
            tabAllExercises.Location = new Point(4, 29);
            tabAllExercises.Name = "tabAllExercises";
            tabAllExercises.Padding = new Padding(3);
            tabAllExercises.Size = new Size(641, 318);
            tabAllExercises.TabIndex = 0;
            tabAllExercises.Text = "All Exercises";
            tabAllExercises.UseVisualStyleBackColor = true;
            // 
            // txbSearchBar
            // 
            txbSearchBar.AllowDrop = true;
            txbSearchBar.Location = new Point(24, 19);
            txbSearchBar.Multiline = true;
            txbSearchBar.Name = "txbSearchBar";
            txbSearchBar.PlaceholderText = "Name/Weight/Difficulty";
            txbSearchBar.ScrollBars = ScrollBars.Vertical;
            txbSearchBar.Size = new Size(168, 59);
            txbSearchBar.TabIndex = 12;
            // 
            // tabconManageExercise
            // 
            tabconManageExercise.Controls.Add(tabEditExercise);
            tabconManageExercise.Controls.Add(tabDeleteAndViewExercise);
            tabconManageExercise.Controls.Add(tabSortExercises);
            tabconManageExercise.Location = new Point(332, 38);
            tabconManageExercise.Name = "tabconManageExercise";
            tabconManageExercise.SelectedIndex = 0;
            tabconManageExercise.Size = new Size(275, 210);
            tabconManageExercise.TabIndex = 11;
            // 
            // tabEditExercise
            // 
            tabEditExercise.Controls.Add(cmbNewDifficulty);
            tabEditExercise.Controls.Add(btnEdit);
            tabEditExercise.Controls.Add(txbNewWeight);
            tabEditExercise.Controls.Add(txbNewReps);
            tabEditExercise.Location = new Point(4, 29);
            tabEditExercise.Name = "tabEditExercise";
            tabEditExercise.Padding = new Padding(3);
            tabEditExercise.Size = new Size(267, 177);
            tabEditExercise.TabIndex = 0;
            tabEditExercise.Text = "Edit";
            tabEditExercise.UseVisualStyleBackColor = true;
            // 
            // cmbNewDifficulty
            // 
            cmbNewDifficulty.FormattingEnabled = true;
            cmbNewDifficulty.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced", "Athlete" });
            cmbNewDifficulty.Location = new Point(35, 104);
            cmbNewDifficulty.Name = "cmbNewDifficulty";
            cmbNewDifficulty.Size = new Size(125, 28);
            cmbNewDifficulty.TabIndex = 4;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Violet;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(185, 67);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(66, 35);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txbNewWeight
            // 
            txbNewWeight.Location = new Point(35, 71);
            txbNewWeight.Name = "txbNewWeight";
            txbNewWeight.PlaceholderText = "New Weight";
            txbNewWeight.Size = new Size(125, 27);
            txbNewWeight.TabIndex = 1;
            // 
            // txbNewReps
            // 
            txbNewReps.Location = new Point(35, 38);
            txbNewReps.Name = "txbNewReps";
            txbNewReps.PlaceholderText = "New Reps";
            txbNewReps.Size = new Size(125, 27);
            txbNewReps.TabIndex = 0;
            // 
            // tabDeleteAndViewExercise
            // 
            tabDeleteAndViewExercise.Controls.Add(btnDelete);
            tabDeleteAndViewExercise.Controls.Add(btnViewDetails);
            tabDeleteAndViewExercise.Location = new Point(4, 29);
            tabDeleteAndViewExercise.Name = "tabDeleteAndViewExercise";
            tabDeleteAndViewExercise.Padding = new Padding(3);
            tabDeleteAndViewExercise.Size = new Size(267, 177);
            tabDeleteAndViewExercise.TabIndex = 1;
            tabDeleteAndViewExercise.Text = "View/Delete";
            tabDeleteAndViewExercise.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Violet;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(151, 54);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 58);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.Violet;
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Location = new Point(40, 54);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(75, 58);
            btnViewDetails.TabIndex = 4;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewExercise_Click;
            // 
            // tabSortExercises
            // 
            tabSortExercises.Controls.Add(btnSortDescendingName);
            tabSortExercises.Controls.Add(btnSortExName);
            tabSortExercises.Controls.Add(btnCustomCompare);
            tabSortExercises.Location = new Point(4, 29);
            tabSortExercises.Name = "tabSortExercises";
            tabSortExercises.Padding = new Padding(3);
            tabSortExercises.Size = new Size(267, 177);
            tabSortExercises.TabIndex = 2;
            tabSortExercises.Text = "Sort ex";
            tabSortExercises.UseVisualStyleBackColor = true;
            // 
            // btnSortDescendingName
            // 
            btnSortDescendingName.BackColor = Color.Violet;
            btnSortDescendingName.FlatStyle = FlatStyle.Flat;
            btnSortDescendingName.Location = new Point(59, 110);
            btnSortDescendingName.Name = "btnSortDescendingName";
            btnSortDescendingName.Size = new Size(156, 35);
            btnSortDescendingName.TabIndex = 8;
            btnSortDescendingName.Text = "Sort by Name (desc)";
            btnSortDescendingName.UseVisualStyleBackColor = false;
            btnSortDescendingName.Click += btnSortDescendingName_Click;
            // 
            // btnSortExName
            // 
            btnSortExName.BackColor = Color.Violet;
            btnSortExName.FlatStyle = FlatStyle.Flat;
            btnSortExName.Location = new Point(59, 28);
            btnSortExName.Name = "btnSortExName";
            btnSortExName.Size = new Size(156, 35);
            btnSortExName.TabIndex = 7;
            btnSortExName.Text = "Sort by Name";
            btnSortExName.UseVisualStyleBackColor = false;
            btnSortExName.Click += btnSortExName_Click;
            // 
            // btnCustomCompare
            // 
            btnCustomCompare.BackColor = Color.Violet;
            btnCustomCompare.FlatStyle = FlatStyle.Flat;
            btnCustomCompare.Location = new Point(59, 69);
            btnCustomCompare.Name = "btnCustomCompare";
            btnCustomCompare.Size = new Size(156, 35);
            btnCustomCompare.TabIndex = 6;
            btnCustomCompare.Text = "Sort by Weight";
            btnCustomCompare.UseVisualStyleBackColor = false;
            btnCustomCompare.Click += btnCustomCompare_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Violet;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Location = new Point(167, 264);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 34);
            btnNext.TabIndex = 10;
            btnNext.Text = "next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Violet;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Location = new Point(33, 264);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 34);
            btnPrevious.TabIndex = 9;
            btnPrevious.Text = "previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lbExercises
            // 
            lbExercises.DisplayMember = "Name";
            lbExercises.FormattingEnabled = true;
            lbExercises.ItemHeight = 20;
            lbExercises.Location = new Point(24, 84);
            lbExercises.Name = "lbExercises";
            lbExercises.Size = new Size(246, 164);
            lbExercises.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Violet;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(207, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(72, 32);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tabAddExercise
            // 
            tabAddExercise.Controls.Add(btnCreateExercise);
            tabAddExercise.Controls.Add(grbSpecifics);
            tabAddExercise.Controls.Add(grbInformation);
            tabAddExercise.Location = new Point(4, 29);
            tabAddExercise.Name = "tabAddExercise";
            tabAddExercise.Padding = new Padding(3);
            tabAddExercise.Size = new Size(641, 318);
            tabAddExercise.TabIndex = 1;
            tabAddExercise.Text = "Add Exercise";
            tabAddExercise.UseVisualStyleBackColor = true;
            // 
            // btnCreateExercise
            // 
            btnCreateExercise.BackColor = Color.Violet;
            btnCreateExercise.FlatStyle = FlatStyle.Flat;
            btnCreateExercise.Location = new Point(286, 210);
            btnCreateExercise.Name = "btnCreateExercise";
            btnCreateExercise.Size = new Size(94, 59);
            btnCreateExercise.TabIndex = 2;
            btnCreateExercise.Text = "Create Exercise";
            btnCreateExercise.UseVisualStyleBackColor = false;
            btnCreateExercise.Click += btnCreateExercise_Click;
            // 
            // grbSpecifics
            // 
            grbSpecifics.Controls.Add(txbPicture);
            grbSpecifics.Controls.Add(txbSpecialty);
            grbSpecifics.Location = new Point(386, 20);
            grbSpecifics.Name = "grbSpecifics";
            grbSpecifics.Size = new Size(235, 160);
            grbSpecifics.TabIndex = 1;
            grbSpecifics.TabStop = false;
            grbSpecifics.Text = "SPECIFICS";
            // 
            // txbPicture
            // 
            txbPicture.Location = new Point(62, 84);
            txbPicture.Name = "txbPicture";
            txbPicture.PlaceholderText = "Pic Url";
            txbPicture.Size = new Size(125, 27);
            txbPicture.TabIndex = 1;
            // 
            // txbSpecialty
            // 
            txbSpecialty.Location = new Point(62, 38);
            txbSpecialty.Name = "txbSpecialty";
            txbSpecialty.PlaceholderText = "Specialty";
            txbSpecialty.Size = new Size(125, 27);
            txbSpecialty.TabIndex = 0;
            // 
            // grbInformation
            // 
            grbInformation.Controls.Add(lblDifficulty);
            grbInformation.Controls.Add(lblTypeEx);
            grbInformation.Controls.Add(txbWeight);
            grbInformation.Controls.Add(txbNumReps);
            grbInformation.Controls.Add(txbEquipment);
            grbInformation.Controls.Add(txbName);
            grbInformation.Controls.Add(cmbDifficulty);
            grbInformation.Controls.Add(cmbTypeEx);
            grbInformation.Location = new Point(15, 20);
            grbInformation.Name = "grbInformation";
            grbInformation.Size = new Size(365, 160);
            grbInformation.TabIndex = 0;
            grbInformation.TabStop = false;
            grbInformation.Text = "INFORMATION";
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Location = new Point(0, 101);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(72, 20);
            lblDifficulty.TabIndex = 7;
            lblDifficulty.Text = "Difficulty:";
            // 
            // lblTypeEx
            // 
            lblTypeEx.AutoSize = true;
            lblTypeEx.Location = new Point(6, 34);
            lblTypeEx.Name = "lblTypeEx";
            lblTypeEx.Size = new Size(62, 20);
            lblTypeEx.TabIndex = 6;
            lblTypeEx.Text = "Type Ex:";
            // 
            // txbWeight
            // 
            txbWeight.Location = new Point(229, 102);
            txbWeight.Name = "txbWeight";
            txbWeight.PlaceholderText = "Weight";
            txbWeight.Size = new Size(125, 27);
            txbWeight.TabIndex = 5;
            // 
            // txbNumReps
            // 
            txbNumReps.Location = new Point(229, 65);
            txbNumReps.Name = "txbNumReps";
            txbNumReps.PlaceholderText = "Num Reps";
            txbNumReps.Size = new Size(125, 27);
            txbNumReps.TabIndex = 4;
            // 
            // txbEquipment
            // 
            txbEquipment.Location = new Point(229, 31);
            txbEquipment.Name = "txbEquipment";
            txbEquipment.PlaceholderText = "Equipment";
            txbEquipment.Size = new Size(125, 27);
            txbEquipment.TabIndex = 3;
            // 
            // txbName
            // 
            txbName.Location = new Point(74, 65);
            txbName.Name = "txbName";
            txbName.PlaceholderText = "Exercise Name";
            txbName.Size = new Size(125, 27);
            txbName.TabIndex = 2;
            // 
            // cmbDifficulty
            // 
            cmbDifficulty.FormattingEnabled = true;
            cmbDifficulty.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced", "Athlete" });
            cmbDifficulty.Location = new Point(74, 98);
            cmbDifficulty.Name = "cmbDifficulty";
            cmbDifficulty.Size = new Size(125, 28);
            cmbDifficulty.TabIndex = 1;
            // 
            // cmbTypeEx
            // 
            cmbTypeEx.FormattingEnabled = true;
            cmbTypeEx.Items.AddRange(new object[] { "Arm", "Back", "Chest", "Core", "Legs", "Neck", "Shoulder" });
            cmbTypeEx.Location = new Point(74, 31);
            cmbTypeEx.Name = "cmbTypeEx";
            cmbTypeEx.Size = new Size(125, 28);
            cmbTypeEx.TabIndex = 0;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(673, 370);
            Controls.Add(tabconExercises);
            Name = "AppForm";
            Text = "AppForm";
            tabconExercises.ResumeLayout(false);
            tabAllExercises.ResumeLayout(false);
            tabAllExercises.PerformLayout();
            tabconManageExercise.ResumeLayout(false);
            tabEditExercise.ResumeLayout(false);
            tabEditExercise.PerformLayout();
            tabDeleteAndViewExercise.ResumeLayout(false);
            tabSortExercises.ResumeLayout(false);
            tabAddExercise.ResumeLayout(false);
            grbSpecifics.ResumeLayout(false);
            grbSpecifics.PerformLayout();
            grbInformation.ResumeLayout(false);
            grbInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabconExercises;
        private TabPage tabAllExercises;
        private Label lblExName;
        private Button btnViewDetails;
        private ListBox lbExercises;
        private Button btnSearch;
        private TabPage tabAddExercise;
        private Button btnCreateExercise;
        private GroupBox grbSpecifics;
        private GroupBox grbInformation;
        private Label lblDifficulty;
        private Label lblTypeEx;
        private TextBox txbWeight;
        private TextBox txbNumReps;
        private TextBox txbEquipment;
        private TextBox txbName;
        private ComboBox cmbDifficulty;
        private ComboBox cmbTypeEx;
        private TextBox txbSpecialty;
        private TextBox txbPicture;
        private ComboBox cmbSelectedEx;
        private Button btnNext;
        private Button btnPrevious;
        private TabControl tabconManageExercise;
        private TabPage tabEditExercise;
        private ComboBox cmbNewDifficulty;
        private Button btnEdit;
        private TextBox txbNewWeight;
        private TextBox txbNewReps;
        private TabPage tabDeleteAndViewExercise;
        private Button btnDelete;
        private TabPage tabSortExercises;
        private Button btnSortDescendingName;
        private Button btnSortExName;
        private Button btnCustomCompare;
        private TextBox txbSearchBar;
    }
}