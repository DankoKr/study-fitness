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
            cmbSelectedEx = new ComboBox();
            lblExName = new Label();
            btnViewExercise = new Button();
            btnShowExercises = new Button();
            lbAllExercises = new ListBox();
            btnSearch = new Button();
            txbSearchBar = new TextBox();
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
            tabManageExercises = new TabPage();
            lblManageEx = new Label();
            cmbManageEx = new ComboBox();
            tabconManageExercise = new TabControl();
            tabEditExercise = new TabPage();
            cmbNewDifficulty = new ComboBox();
            btnEdit = new Button();
            txbNewWeight = new TextBox();
            txbNewReps = new TextBox();
            tabDeletExercise = new TabPage();
            btnDelete = new Button();
            btnManageAllExercises = new Button();
            lbManageExercises = new ListBox();
            tabCompareExercises = new TabPage();
            btnSortDescendingName = new Button();
            btnSortExName = new Button();
            btnCustomCompare = new Button();
            lbExerciseSorted = new ListBox();
            tabconExercises.SuspendLayout();
            tabAllExercises.SuspendLayout();
            tabAddExercise.SuspendLayout();
            grbSpecifics.SuspendLayout();
            grbInformation.SuspendLayout();
            tabManageExercises.SuspendLayout();
            tabconManageExercise.SuspendLayout();
            tabEditExercise.SuspendLayout();
            tabDeletExercise.SuspendLayout();
            tabCompareExercises.SuspendLayout();
            SuspendLayout();
            // 
            // tabconExercises
            // 
            tabconExercises.Controls.Add(tabAllExercises);
            tabconExercises.Controls.Add(tabAddExercise);
            tabconExercises.Controls.Add(tabManageExercises);
            tabconExercises.Controls.Add(tabCompareExercises);
            tabconExercises.Location = new Point(12, 12);
            tabconExercises.Name = "tabconExercises";
            tabconExercises.SelectedIndex = 0;
            tabconExercises.Size = new Size(649, 351);
            tabconExercises.TabIndex = 0;
            // 
            // tabAllExercises
            // 
            tabAllExercises.Controls.Add(cmbSelectedEx);
            tabAllExercises.Controls.Add(lblExName);
            tabAllExercises.Controls.Add(btnViewExercise);
            tabAllExercises.Controls.Add(btnShowExercises);
            tabAllExercises.Controls.Add(lbAllExercises);
            tabAllExercises.Controls.Add(btnSearch);
            tabAllExercises.Controls.Add(txbSearchBar);
            tabAllExercises.Location = new Point(4, 29);
            tabAllExercises.Name = "tabAllExercises";
            tabAllExercises.Padding = new Padding(3);
            tabAllExercises.Size = new Size(641, 318);
            tabAllExercises.TabIndex = 0;
            tabAllExercises.Text = "All Exercises";
            tabAllExercises.UseVisualStyleBackColor = true;
            // 
            // cmbSelectedEx
            // 
            cmbSelectedEx.FormattingEnabled = true;
            cmbSelectedEx.Location = new Point(447, 115);
            cmbSelectedEx.Name = "cmbSelectedEx";
            cmbSelectedEx.Size = new Size(151, 28);
            cmbSelectedEx.TabIndex = 6;
            // 
            // lblExName
            // 
            lblExName.AutoSize = true;
            lblExName.Location = new Point(366, 118);
            lblExName.Name = "lblExName";
            lblExName.Size = new Size(75, 20);
            lblExName.TabIndex = 5;
            lblExName.Text = "Select Ex :";
            // 
            // btnViewExercise
            // 
            btnViewExercise.BackColor = Color.Violet;
            btnViewExercise.FlatStyle = FlatStyle.Flat;
            btnViewExercise.Location = new Point(461, 165);
            btnViewExercise.Name = "btnViewExercise";
            btnViewExercise.Size = new Size(115, 29);
            btnViewExercise.TabIndex = 4;
            btnViewExercise.Text = "View Exercise";
            btnViewExercise.UseVisualStyleBackColor = false;
            btnViewExercise.Click += btnViewExercise_Click;
            // 
            // btnShowExercises
            // 
            btnShowExercises.BackColor = Color.Violet;
            btnShowExercises.FlatStyle = FlatStyle.Flat;
            btnShowExercises.Location = new Point(91, 263);
            btnShowExercises.Name = "btnShowExercises";
            btnShowExercises.Size = new Size(128, 29);
            btnShowExercises.TabIndex = 3;
            btnShowExercises.Text = "Show Exercises";
            btnShowExercises.UseVisualStyleBackColor = false;
            btnShowExercises.Click += btnShowExercises_Click;
            // 
            // lbAllExercises
            // 
            lbAllExercises.DisplayMember = "Name";
            lbAllExercises.FormattingEnabled = true;
            lbAllExercises.ItemHeight = 20;
            lbAllExercises.Location = new Point(43, 84);
            lbAllExercises.Name = "lbAllExercises";
            lbAllExercises.Size = new Size(214, 164);
            lbAllExercises.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Violet;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(268, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txbSearchBar
            // 
            txbSearchBar.Location = new Point(66, 37);
            txbSearchBar.Name = "txbSearchBar";
            txbSearchBar.Size = new Size(168, 27);
            txbSearchBar.TabIndex = 0;
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
            // tabManageExercises
            // 
            tabManageExercises.Controls.Add(lblManageEx);
            tabManageExercises.Controls.Add(cmbManageEx);
            tabManageExercises.Controls.Add(tabconManageExercise);
            tabManageExercises.Controls.Add(btnManageAllExercises);
            tabManageExercises.Controls.Add(lbManageExercises);
            tabManageExercises.Location = new Point(4, 29);
            tabManageExercises.Name = "tabManageExercises";
            tabManageExercises.Padding = new Padding(3);
            tabManageExercises.Size = new Size(641, 318);
            tabManageExercises.TabIndex = 2;
            tabManageExercises.Text = "Manage Exercises";
            tabManageExercises.UseVisualStyleBackColor = true;
            // 
            // lblManageEx
            // 
            lblManageEx.AutoSize = true;
            lblManageEx.Location = new Point(264, 43);
            lblManageEx.Name = "lblManageEx";
            lblManageEx.Size = new Size(75, 20);
            lblManageEx.TabIndex = 5;
            lblManageEx.Text = "Select Ex :";
            // 
            // cmbManageEx
            // 
            cmbManageEx.FormattingEnabled = true;
            cmbManageEx.Location = new Point(345, 40);
            cmbManageEx.Name = "cmbManageEx";
            cmbManageEx.Size = new Size(151, 28);
            cmbManageEx.TabIndex = 4;
            // 
            // tabconManageExercise
            // 
            tabconManageExercise.Controls.Add(tabEditExercise);
            tabconManageExercise.Controls.Add(tabDeletExercise);
            tabconManageExercise.Location = new Point(264, 93);
            tabconManageExercise.Name = "tabconManageExercise";
            tabconManageExercise.SelectedIndex = 0;
            tabconManageExercise.Size = new Size(337, 189);
            tabconManageExercise.TabIndex = 3;
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
            tabEditExercise.Size = new Size(329, 156);
            tabEditExercise.TabIndex = 0;
            tabEditExercise.Text = "Edit";
            tabEditExercise.UseVisualStyleBackColor = true;
            // 
            // cmbNewDifficulty
            // 
            cmbNewDifficulty.FormattingEnabled = true;
            cmbNewDifficulty.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced", "Athlete" });
            cmbNewDifficulty.Location = new Point(39, 94);
            cmbNewDifficulty.Name = "cmbNewDifficulty";
            cmbNewDifficulty.Size = new Size(125, 28);
            cmbNewDifficulty.TabIndex = 4;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Violet;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(202, 53);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 43);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txbNewWeight
            // 
            txbNewWeight.Location = new Point(39, 61);
            txbNewWeight.Name = "txbNewWeight";
            txbNewWeight.PlaceholderText = "New Weight";
            txbNewWeight.Size = new Size(125, 27);
            txbNewWeight.TabIndex = 1;
            // 
            // txbNewReps
            // 
            txbNewReps.Location = new Point(39, 28);
            txbNewReps.Name = "txbNewReps";
            txbNewReps.PlaceholderText = "New Reps";
            txbNewReps.Size = new Size(125, 27);
            txbNewReps.TabIndex = 0;
            // 
            // tabDeletExercise
            // 
            tabDeletExercise.Controls.Add(btnDelete);
            tabDeletExercise.Location = new Point(4, 29);
            tabDeletExercise.Name = "tabDeletExercise";
            tabDeletExercise.Padding = new Padding(3);
            tabDeletExercise.Size = new Size(329, 156);
            tabDeletExercise.TabIndex = 1;
            tabDeletExercise.Text = "Delete";
            tabDeletExercise.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Violet;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(124, 50);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 52);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnManageAllExercises
            // 
            btnManageAllExercises.BackColor = Color.Violet;
            btnManageAllExercises.FlatStyle = FlatStyle.Flat;
            btnManageAllExercises.Location = new Point(24, 271);
            btnManageAllExercises.Name = "btnManageAllExercises";
            btnManageAllExercises.Size = new Size(150, 41);
            btnManageAllExercises.TabIndex = 2;
            btnManageAllExercises.Text = "Show all exercises";
            btnManageAllExercises.UseVisualStyleBackColor = false;
            btnManageAllExercises.Click += btnManageAllExercises_Click;
            // 
            // lbManageExercises
            // 
            lbManageExercises.DisplayMember = "Name";
            lbManageExercises.FormattingEnabled = true;
            lbManageExercises.ItemHeight = 20;
            lbManageExercises.Location = new Point(6, 21);
            lbManageExercises.Name = "lbManageExercises";
            lbManageExercises.Size = new Size(174, 244);
            lbManageExercises.TabIndex = 1;
            // 
            // tabCompareExercises
            // 
            tabCompareExercises.Controls.Add(btnSortDescendingName);
            tabCompareExercises.Controls.Add(btnSortExName);
            tabCompareExercises.Controls.Add(btnCustomCompare);
            tabCompareExercises.Controls.Add(lbExerciseSorted);
            tabCompareExercises.Location = new Point(4, 29);
            tabCompareExercises.Name = "tabCompareExercises";
            tabCompareExercises.Padding = new Padding(3);
            tabCompareExercises.Size = new Size(641, 318);
            tabCompareExercises.TabIndex = 3;
            tabCompareExercises.Text = "Compare";
            tabCompareExercises.UseVisualStyleBackColor = true;
            // 
            // btnSortDescendingName
            // 
            btnSortDescendingName.BackColor = Color.Violet;
            btnSortDescendingName.FlatStyle = FlatStyle.Flat;
            btnSortDescendingName.Location = new Point(424, 186);
            btnSortDescendingName.Name = "btnSortDescendingName";
            btnSortDescendingName.Size = new Size(109, 51);
            btnSortDescendingName.TabIndex = 5;
            btnSortDescendingName.Text = "Sort by Name (desc)";
            btnSortDescendingName.UseVisualStyleBackColor = false;
            btnSortDescendingName.Click += btnSortDescendingName_Click;
            // 
            // btnSortExName
            // 
            btnSortExName.BackColor = Color.Violet;
            btnSortExName.FlatStyle = FlatStyle.Flat;
            btnSortExName.Location = new Point(424, 72);
            btnSortExName.Name = "btnSortExName";
            btnSortExName.Size = new Size(109, 51);
            btnSortExName.TabIndex = 4;
            btnSortExName.Text = "Sort by Name";
            btnSortExName.UseVisualStyleBackColor = false;
            btnSortExName.Click += btnSortExName_Click;
            // 
            // btnCustomCompare
            // 
            btnCustomCompare.BackColor = Color.Violet;
            btnCustomCompare.FlatStyle = FlatStyle.Flat;
            btnCustomCompare.Location = new Point(424, 129);
            btnCustomCompare.Name = "btnCustomCompare";
            btnCustomCompare.Size = new Size(109, 51);
            btnCustomCompare.TabIndex = 3;
            btnCustomCompare.Text = "Sort by Weight";
            btnCustomCompare.UseVisualStyleBackColor = false;
            btnCustomCompare.Click += btnCustomCompare_Click;
            // 
            // lbExerciseSorted
            // 
            lbExerciseSorted.DisplayMember = "Name";
            lbExerciseSorted.FormattingEnabled = true;
            lbExerciseSorted.ItemHeight = 20;
            lbExerciseSorted.Location = new Point(98, 27);
            lbExerciseSorted.Name = "lbExerciseSorted";
            lbExerciseSorted.Size = new Size(242, 264);
            lbExerciseSorted.TabIndex = 1;
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
            tabAddExercise.ResumeLayout(false);
            grbSpecifics.ResumeLayout(false);
            grbSpecifics.PerformLayout();
            grbInformation.ResumeLayout(false);
            grbInformation.PerformLayout();
            tabManageExercises.ResumeLayout(false);
            tabManageExercises.PerformLayout();
            tabconManageExercise.ResumeLayout(false);
            tabEditExercise.ResumeLayout(false);
            tabEditExercise.PerformLayout();
            tabDeletExercise.ResumeLayout(false);
            tabCompareExercises.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabconExercises;
        private TabPage tabAllExercises;
        private Label lblExName;
        private Button btnViewExercise;
        private Button btnShowExercises;
        private ListBox lbAllExercises;
        private Button btnSearch;
        private TextBox txbSearchBar;
        private TabPage tabAddExercise;
        private TabPage tabManageExercises;
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
        private TabControl tabconManageExercise;
        private TabPage tabEditExercise;
        private Button btnEdit;
        private TextBox txbNewWeight;
        private TextBox txbNewReps;
        private TabPage tabDeletExercise;
        private Button btnDelete;
        private Button btnManageAllExercises;
        private ListBox lbManageExercises;
        private ComboBox cmbNewDifficulty;
        private TabPage tabCompareExercises;
        private ListBox lbExerciseSorted;
        private TextBox txbPicture;
        private ComboBox cmbSelectedEx;
        private Label lblManageEx;
        private ComboBox cmbManageEx;
        private Button btnCustomCompare;
        private Button btnSortExName;
        private Button btnSortDescendingName;
    }
}