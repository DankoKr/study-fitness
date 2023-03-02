namespace Study_Fitness
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
            this.tapconExercises = new System.Windows.Forms.TabControl();
            this.tabAllExercises = new System.Windows.Forms.TabPage();
            this.btnShowExercises = new System.Windows.Forms.Button();
            this.lblExName = new System.Windows.Forms.Label();
            this.txbWantedExercise = new System.Windows.Forms.TextBox();
            this.btnViewExercise = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearchBar = new System.Windows.Forms.TextBox();
            this.lbAllExercises = new System.Windows.Forms.ListBox();
            this.tabAddExercise = new System.Windows.Forms.TabPage();
            this.grbSpecifics = new System.Windows.Forms.GroupBox();
            this.txbSpecialty = new System.Windows.Forms.TextBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.grbInformation = new System.Windows.Forms.GroupBox();
            this.cmbTypeEx = new System.Windows.Forms.ComboBox();
            this.lblTypeEx = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txbRepsNum = new System.Windows.Forms.TextBox();
            this.txbWeight = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblRepsNum = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbDifficulty = new System.Windows.Forms.TextBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.txbEquipment = new System.Windows.Forms.TextBox();
            this.btnCreateExercise = new System.Windows.Forms.Button();
            this.tabManageExercises = new System.Windows.Forms.TabPage();
            this.tabconManageExercise = new System.Windows.Forms.TabControl();
            this.tabEditExercise = new System.Windows.Forms.TabPage();
            this.lblNewDifficulty = new System.Windows.Forms.Label();
            this.txbNewDifficulty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNewWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNewReps = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabDeleteExercise = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblManageExName = new System.Windows.Forms.Label();
            this.btnManageAllExercises = new System.Windows.Forms.Button();
            this.txbManageExercise = new System.Windows.Forms.TextBox();
            this.lbManageExercises = new System.Windows.Forms.ListBox();
            this.tabTrainerData = new System.Windows.Forms.TabPage();
            this.lblFuture = new System.Windows.Forms.Label();
            this.lblSelectAnExercise = new System.Windows.Forms.Label();
            this.tapconExercises.SuspendLayout();
            this.tabAllExercises.SuspendLayout();
            this.tabAddExercise.SuspendLayout();
            this.grbSpecifics.SuspendLayout();
            this.grbInformation.SuspendLayout();
            this.tabManageExercises.SuspendLayout();
            this.tabconManageExercise.SuspendLayout();
            this.tabEditExercise.SuspendLayout();
            this.tabDeleteExercise.SuspendLayout();
            this.tabTrainerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tapconExercises
            // 
            this.tapconExercises.Controls.Add(this.tabAllExercises);
            this.tapconExercises.Controls.Add(this.tabAddExercise);
            this.tapconExercises.Controls.Add(this.tabManageExercises);
            this.tapconExercises.Controls.Add(this.tabTrainerData);
            this.tapconExercises.Location = new System.Drawing.Point(12, 12);
            this.tapconExercises.Name = "tapconExercises";
            this.tapconExercises.SelectedIndex = 0;
            this.tapconExercises.Size = new System.Drawing.Size(776, 426);
            this.tapconExercises.TabIndex = 0;
            // 
            // tabAllExercises
            // 
            this.tabAllExercises.Controls.Add(this.btnShowExercises);
            this.tabAllExercises.Controls.Add(this.lblExName);
            this.tabAllExercises.Controls.Add(this.txbWantedExercise);
            this.tabAllExercises.Controls.Add(this.btnViewExercise);
            this.tabAllExercises.Controls.Add(this.btnSearch);
            this.tabAllExercises.Controls.Add(this.txbSearchBar);
            this.tabAllExercises.Controls.Add(this.lbAllExercises);
            this.tabAllExercises.Location = new System.Drawing.Point(4, 25);
            this.tabAllExercises.Name = "tabAllExercises";
            this.tabAllExercises.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllExercises.Size = new System.Drawing.Size(768, 397);
            this.tabAllExercises.TabIndex = 0;
            this.tabAllExercises.Text = "All Exercises";
            this.tabAllExercises.UseVisualStyleBackColor = true;
            // 
            // btnShowExercises
            // 
            this.btnShowExercises.Location = new System.Drawing.Point(153, 326);
            this.btnShowExercises.Name = "btnShowExercises";
            this.btnShowExercises.Size = new System.Drawing.Size(132, 36);
            this.btnShowExercises.TabIndex = 6;
            this.btnShowExercises.Text = "Show exercises";
            this.btnShowExercises.UseVisualStyleBackColor = true;
            this.btnShowExercises.Click += new System.EventHandler(this.btnShowExercises_Click);
            // 
            // lblExName
            // 
            this.lblExName.AutoSize = true;
            this.lblExName.Location = new System.Drawing.Point(467, 190);
            this.lblExName.Name = "lblExName";
            this.lblExName.Size = new System.Drawing.Size(65, 16);
            this.lblExName.TabIndex = 5;
            this.lblExName.Text = "Ex Name:";
            // 
            // txbWantedExercise
            // 
            this.txbWantedExercise.Location = new System.Drawing.Point(538, 187);
            this.txbWantedExercise.Name = "txbWantedExercise";
            this.txbWantedExercise.Size = new System.Drawing.Size(148, 22);
            this.txbWantedExercise.TabIndex = 4;
            // 
            // btnViewExercise
            // 
            this.btnViewExercise.Location = new System.Drawing.Point(553, 231);
            this.btnViewExercise.Name = "btnViewExercise";
            this.btnViewExercise.Size = new System.Drawing.Size(75, 58);
            this.btnViewExercise.TabIndex = 3;
            this.btnViewExercise.Text = "View exercise";
            this.btnViewExercise.UseVisualStyleBackColor = true;
            this.btnViewExercise.Click += new System.EventHandler(this.btnViewExercise_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(386, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 47);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearchBar
            // 
            this.txbSearchBar.Location = new System.Drawing.Point(82, 84);
            this.txbSearchBar.Name = "txbSearchBar";
            this.txbSearchBar.Size = new System.Drawing.Size(268, 22);
            this.txbSearchBar.TabIndex = 1;
            // 
            // lbAllExercises
            // 
            this.lbAllExercises.DisplayMember = "Name";
            this.lbAllExercises.FormattingEnabled = true;
            this.lbAllExercises.ItemHeight = 16;
            this.lbAllExercises.Location = new System.Drawing.Point(66, 141);
            this.lbAllExercises.Name = "lbAllExercises";
            this.lbAllExercises.Size = new System.Drawing.Size(305, 164);
            this.lbAllExercises.TabIndex = 0;
            // 
            // tabAddExercise
            // 
            this.tabAddExercise.Controls.Add(this.grbSpecifics);
            this.tabAddExercise.Controls.Add(this.grbInformation);
            this.tabAddExercise.Controls.Add(this.btnCreateExercise);
            this.tabAddExercise.Location = new System.Drawing.Point(4, 25);
            this.tabAddExercise.Name = "tabAddExercise";
            this.tabAddExercise.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddExercise.Size = new System.Drawing.Size(768, 397);
            this.tabAddExercise.TabIndex = 1;
            this.tabAddExercise.Text = "Add Exercise";
            this.tabAddExercise.UseVisualStyleBackColor = true;
            // 
            // grbSpecifics
            // 
            this.grbSpecifics.Controls.Add(this.txbSpecialty);
            this.grbSpecifics.Controls.Add(this.lblSpecialty);
            this.grbSpecifics.Location = new System.Drawing.Point(530, 26);
            this.grbSpecifics.Name = "grbSpecifics";
            this.grbSpecifics.Size = new System.Drawing.Size(200, 136);
            this.grbSpecifics.TabIndex = 14;
            this.grbSpecifics.TabStop = false;
            this.grbSpecifics.Text = "SPECIFICS";
            // 
            // txbSpecialty
            // 
            this.txbSpecialty.Location = new System.Drawing.Point(78, 58);
            this.txbSpecialty.Name = "txbSpecialty";
            this.txbSpecialty.Size = new System.Drawing.Size(116, 22);
            this.txbSpecialty.TabIndex = 3;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(6, 61);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(66, 16);
            this.lblSpecialty.TabIndex = 0;
            this.lblSpecialty.Text = "Specialty:";
            // 
            // grbInformation
            // 
            this.grbInformation.Controls.Add(this.cmbTypeEx);
            this.grbInformation.Controls.Add(this.lblTypeEx);
            this.grbInformation.Controls.Add(this.lblWeight);
            this.grbInformation.Controls.Add(this.txbRepsNum);
            this.grbInformation.Controls.Add(this.txbWeight);
            this.grbInformation.Controls.Add(this.txbName);
            this.grbInformation.Controls.Add(this.lblRepsNum);
            this.grbInformation.Controls.Add(this.lblName);
            this.grbInformation.Controls.Add(this.txbDifficulty);
            this.grbInformation.Controls.Add(this.lblDifficulty);
            this.grbInformation.Controls.Add(this.lblEquipment);
            this.grbInformation.Controls.Add(this.txbEquipment);
            this.grbInformation.Location = new System.Drawing.Point(26, 26);
            this.grbInformation.Name = "grbInformation";
            this.grbInformation.Size = new System.Drawing.Size(453, 164);
            this.grbInformation.TabIndex = 13;
            this.grbInformation.TabStop = false;
            this.grbInformation.Text = "INFORMATION";
            // 
            // cmbTypeEx
            // 
            this.cmbTypeEx.FormattingEnabled = true;
            this.cmbTypeEx.Items.AddRange(new object[] {
            "Upper body",
            "Lower body",
            "Complex"});
            this.cmbTypeEx.Location = new System.Drawing.Point(97, 34);
            this.cmbTypeEx.Name = "cmbTypeEx";
            this.cmbTypeEx.Size = new System.Drawing.Size(121, 24);
            this.cmbTypeEx.TabIndex = 13;
            // 
            // lblTypeEx
            // 
            this.lblTypeEx.AutoSize = true;
            this.lblTypeEx.Location = new System.Drawing.Point(32, 40);
            this.lblTypeEx.Name = "lblTypeEx";
            this.lblTypeEx.Size = new System.Drawing.Size(60, 16);
            this.lblTypeEx.TabIndex = 12;
            this.lblTypeEx.Text = "Type Ex:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(279, 117);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(52, 16);
            this.lblWeight.TabIndex = 10;
            this.lblWeight.Text = "Weight:";
            // 
            // txbRepsNum
            // 
            this.txbRepsNum.Location = new System.Drawing.Point(337, 75);
            this.txbRepsNum.Name = "txbRepsNum";
            this.txbRepsNum.Size = new System.Drawing.Size(100, 22);
            this.txbRepsNum.TabIndex = 2;
            // 
            // txbWeight
            // 
            this.txbWeight.Location = new System.Drawing.Point(337, 114);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(100, 22);
            this.txbWeight.TabIndex = 5;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(97, 75);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 22);
            this.txbName.TabIndex = 1;
            // 
            // lblRepsNum
            // 
            this.lblRepsNum.AutoSize = true;
            this.lblRepsNum.Location = new System.Drawing.Point(260, 78);
            this.lblRepsNum.Name = "lblRepsNum";
            this.lblRepsNum.Size = new System.Drawing.Size(71, 16);
            this.lblRepsNum.TabIndex = 9;
            this.lblRepsNum.Text = "NumReps:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // txbDifficulty
            // 
            this.txbDifficulty.Location = new System.Drawing.Point(97, 113);
            this.txbDifficulty.Name = "txbDifficulty";
            this.txbDifficulty.Size = new System.Drawing.Size(100, 22);
            this.txbDifficulty.TabIndex = 3;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(32, 116);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(59, 16);
            this.lblDifficulty.TabIndex = 7;
            this.lblDifficulty.Text = "Difficulty:";
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Location = new System.Drawing.Point(257, 37);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(74, 16);
            this.lblEquipment.TabIndex = 8;
            this.lblEquipment.Text = "Equipment:";
            // 
            // txbEquipment
            // 
            this.txbEquipment.Location = new System.Drawing.Point(337, 34);
            this.txbEquipment.Name = "txbEquipment";
            this.txbEquipment.Size = new System.Drawing.Size(100, 22);
            this.txbEquipment.TabIndex = 4;
            // 
            // btnCreateExercise
            // 
            this.btnCreateExercise.Location = new System.Drawing.Point(362, 242);
            this.btnCreateExercise.Name = "btnCreateExercise";
            this.btnCreateExercise.Size = new System.Drawing.Size(101, 67);
            this.btnCreateExercise.TabIndex = 0;
            this.btnCreateExercise.Text = "Create Exercise";
            this.btnCreateExercise.UseVisualStyleBackColor = true;
            this.btnCreateExercise.Click += new System.EventHandler(this.btnCreateExercise_Click);
            // 
            // tabManageExercises
            // 
            this.tabManageExercises.Controls.Add(this.lblSelectAnExercise);
            this.tabManageExercises.Controls.Add(this.tabconManageExercise);
            this.tabManageExercises.Controls.Add(this.lblManageExName);
            this.tabManageExercises.Controls.Add(this.btnManageAllExercises);
            this.tabManageExercises.Controls.Add(this.txbManageExercise);
            this.tabManageExercises.Controls.Add(this.lbManageExercises);
            this.tabManageExercises.Location = new System.Drawing.Point(4, 25);
            this.tabManageExercises.Name = "tabManageExercises";
            this.tabManageExercises.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageExercises.Size = new System.Drawing.Size(768, 397);
            this.tabManageExercises.TabIndex = 2;
            this.tabManageExercises.Text = "Manage Exercises";
            this.tabManageExercises.UseVisualStyleBackColor = true;
            // 
            // tabconManageExercise
            // 
            this.tabconManageExercise.Controls.Add(this.tabEditExercise);
            this.tabconManageExercise.Controls.Add(this.tabDeleteExercise);
            this.tabconManageExercise.Location = new System.Drawing.Point(469, 118);
            this.tabconManageExercise.Name = "tabconManageExercise";
            this.tabconManageExercise.SelectedIndex = 0;
            this.tabconManageExercise.Size = new System.Drawing.Size(200, 217);
            this.tabconManageExercise.TabIndex = 11;
            // 
            // tabEditExercise
            // 
            this.tabEditExercise.Controls.Add(this.lblNewDifficulty);
            this.tabEditExercise.Controls.Add(this.txbNewDifficulty);
            this.tabEditExercise.Controls.Add(this.label1);
            this.tabEditExercise.Controls.Add(this.txbNewWeight);
            this.tabEditExercise.Controls.Add(this.label2);
            this.tabEditExercise.Controls.Add(this.txbNewReps);
            this.tabEditExercise.Controls.Add(this.btnEdit);
            this.tabEditExercise.Location = new System.Drawing.Point(4, 25);
            this.tabEditExercise.Name = "tabEditExercise";
            this.tabEditExercise.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditExercise.Size = new System.Drawing.Size(192, 188);
            this.tabEditExercise.TabIndex = 0;
            this.tabEditExercise.Text = "Edit Ex";
            this.tabEditExercise.UseVisualStyleBackColor = true;
            // 
            // lblNewDifficulty
            // 
            this.lblNewDifficulty.AutoSize = true;
            this.lblNewDifficulty.Location = new System.Drawing.Point(10, 97);
            this.lblNewDifficulty.Name = "lblNewDifficulty";
            this.lblNewDifficulty.Size = new System.Drawing.Size(59, 16);
            this.lblNewDifficulty.TabIndex = 12;
            this.lblNewDifficulty.Text = "Difficulty:";
            // 
            // txbNewDifficulty
            // 
            this.txbNewDifficulty.Location = new System.Drawing.Point(86, 94);
            this.txbNewDifficulty.Name = "txbNewDifficulty";
            this.txbNewDifficulty.Size = new System.Drawing.Size(100, 22);
            this.txbNewDifficulty.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reps:";
            // 
            // txbNewWeight
            // 
            this.txbNewWeight.Location = new System.Drawing.Point(86, 53);
            this.txbNewWeight.Name = "txbNewWeight";
            this.txbNewWeight.Size = new System.Drawing.Size(100, 22);
            this.txbNewWeight.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Weight:";
            // 
            // txbNewReps
            // 
            this.txbNewReps.Location = new System.Drawing.Point(86, 19);
            this.txbNewReps.Name = "txbNewReps";
            this.txbNewReps.Size = new System.Drawing.Size(100, 22);
            this.txbNewReps.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(61, 139);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 43);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabDeleteExercise
            // 
            this.tabDeleteExercise.Controls.Add(this.btnDelete);
            this.tabDeleteExercise.Location = new System.Drawing.Point(4, 25);
            this.tabDeleteExercise.Name = "tabDeleteExercise";
            this.tabDeleteExercise.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeleteExercise.Size = new System.Drawing.Size(192, 188);
            this.tabDeleteExercise.TabIndex = 1;
            this.tabDeleteExercise.Text = "Delete Ex";
            this.tabDeleteExercise.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(60, 67);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 43);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblManageExName
            // 
            this.lblManageExName.AutoSize = true;
            this.lblManageExName.Location = new System.Drawing.Point(441, 58);
            this.lblManageExName.Name = "lblManageExName";
            this.lblManageExName.Size = new System.Drawing.Size(65, 16);
            this.lblManageExName.TabIndex = 6;
            this.lblManageExName.Text = "Ex Name:";
            // 
            // btnManageAllExercises
            // 
            this.btnManageAllExercises.Location = new System.Drawing.Point(142, 303);
            this.btnManageAllExercises.Name = "btnManageAllExercises";
            this.btnManageAllExercises.Size = new System.Drawing.Size(75, 51);
            this.btnManageAllExercises.TabIndex = 5;
            this.btnManageAllExercises.Text = "Show all exercises";
            this.btnManageAllExercises.UseVisualStyleBackColor = true;
            this.btnManageAllExercises.Click += new System.EventHandler(this.btnManageAllExercises_Click);
            // 
            // txbManageExercise
            // 
            this.txbManageExercise.Location = new System.Drawing.Point(512, 55);
            this.txbManageExercise.Name = "txbManageExercise";
            this.txbManageExercise.Size = new System.Drawing.Size(157, 22);
            this.txbManageExercise.TabIndex = 2;
            // 
            // lbManageExercises
            // 
            this.lbManageExercises.DisplayMember = "Name";
            this.lbManageExercises.FormattingEnabled = true;
            this.lbManageExercises.ItemHeight = 16;
            this.lbManageExercises.Location = new System.Drawing.Point(60, 52);
            this.lbManageExercises.Name = "lbManageExercises";
            this.lbManageExercises.Size = new System.Drawing.Size(250, 244);
            this.lbManageExercises.TabIndex = 1;
            // 
            // tabTrainerData
            // 
            this.tabTrainerData.Controls.Add(this.lblFuture);
            this.tabTrainerData.Location = new System.Drawing.Point(4, 25);
            this.tabTrainerData.Name = "tabTrainerData";
            this.tabTrainerData.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrainerData.Size = new System.Drawing.Size(768, 397);
            this.tabTrainerData.TabIndex = 3;
            this.tabTrainerData.Text = "Trainer data";
            this.tabTrainerData.UseVisualStyleBackColor = true;
            // 
            // lblFuture
            // 
            this.lblFuture.AutoSize = true;
            this.lblFuture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuture.Location = new System.Drawing.Point(284, 170);
            this.lblFuture.Name = "lblFuture";
            this.lblFuture.Size = new System.Drawing.Size(196, 25);
            this.lblFuture.TabIndex = 0;
            this.lblFuture.Text = "FOR THE FUTURE";
            // 
            // lblSelectAnExercise
            // 
            this.lblSelectAnExercise.AutoSize = true;
            this.lblSelectAnExercise.Location = new System.Drawing.Point(483, 19);
            this.lblSelectAnExercise.Name = "lblSelectAnExercise";
            this.lblSelectAnExercise.Size = new System.Drawing.Size(219, 16);
            this.lblSelectAnExercise.TabIndex = 12;
            this.lblSelectAnExercise.Text = "Select an exercise and edit/delete it";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tapconExercises);
            this.Name = "AppForm";
            this.Text = "AppForm";
            this.tapconExercises.ResumeLayout(false);
            this.tabAllExercises.ResumeLayout(false);
            this.tabAllExercises.PerformLayout();
            this.tabAddExercise.ResumeLayout(false);
            this.grbSpecifics.ResumeLayout(false);
            this.grbSpecifics.PerformLayout();
            this.grbInformation.ResumeLayout(false);
            this.grbInformation.PerformLayout();
            this.tabManageExercises.ResumeLayout(false);
            this.tabManageExercises.PerformLayout();
            this.tabconManageExercise.ResumeLayout(false);
            this.tabEditExercise.ResumeLayout(false);
            this.tabEditExercise.PerformLayout();
            this.tabDeleteExercise.ResumeLayout(false);
            this.tabTrainerData.ResumeLayout(false);
            this.tabTrainerData.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tapconExercises;
		private System.Windows.Forms.TabPage tabAllExercises;
		private System.Windows.Forms.TabPage tabAddExercise;
		private System.Windows.Forms.TabPage tabManageExercises;
		private System.Windows.Forms.TabPage tabTrainerData;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txbSearchBar;
		private System.Windows.Forms.ListBox lbAllExercises;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.TextBox txbManageExercise;
		private System.Windows.Forms.ListBox lbManageExercises;
		private System.Windows.Forms.Button btnCreateExercise;
		private System.Windows.Forms.TextBox txbWeight;
		private System.Windows.Forms.TextBox txbEquipment;
		private System.Windows.Forms.TextBox txbDifficulty;
		private System.Windows.Forms.TextBox txbRepsNum;
		private System.Windows.Forms.TextBox txbName;
		private System.Windows.Forms.Label lblWeight;
		private System.Windows.Forms.Label lblRepsNum;
		private System.Windows.Forms.Label lblEquipment;
		private System.Windows.Forms.Label lblDifficulty;
		private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFuture;
        private System.Windows.Forms.Button btnViewExercise;
        private System.Windows.Forms.Label lblExName;
        private System.Windows.Forms.TextBox txbWantedExercise;
        private System.Windows.Forms.GroupBox grbSpecifics;
        private System.Windows.Forms.GroupBox grbInformation;
        private System.Windows.Forms.Label lblTypeEx;
        private System.Windows.Forms.TextBox txbSpecialty;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.ComboBox cmbTypeEx;
        private System.Windows.Forms.Button btnShowExercises;
        private System.Windows.Forms.Button btnManageAllExercises;
        private System.Windows.Forms.Label lblManageExName;
        private System.Windows.Forms.TextBox txbNewWeight;
        private System.Windows.Forms.TextBox txbNewReps;
        private System.Windows.Forms.TabControl tabconManageExercise;
        private System.Windows.Forms.TabPage tabEditExercise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabDeleteExercise;
        private System.Windows.Forms.Label lblNewDifficulty;
        private System.Windows.Forms.TextBox txbNewDifficulty;
        private System.Windows.Forms.Label lblSelectAnExercise;
    }
}