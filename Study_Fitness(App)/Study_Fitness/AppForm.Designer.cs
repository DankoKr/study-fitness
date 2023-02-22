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
			this.tabAddExercise = new System.Windows.Forms.TabPage();
			this.tabManageExercises = new System.Windows.Forms.TabPage();
			this.tabTrainerData = new System.Windows.Forms.TabPage();
			this.lbAllExercises = new System.Windows.Forms.ListBox();
			this.txbSearchBar = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnSearchManageExercises = new System.Windows.Forms.Button();
			this.lbManageExercises = new System.Windows.Forms.ListBox();
			this.txbSearchManageExercise = new System.Windows.Forms.TextBox();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreateExercise = new System.Windows.Forms.Button();
			this.txbName = new System.Windows.Forms.TextBox();
			this.txbRepsNum = new System.Windows.Forms.TextBox();
			this.txbDifficulty = new System.Windows.Forms.TextBox();
			this.txbEquipment = new System.Windows.Forms.TextBox();
			this.txbWeight = new System.Windows.Forms.TextBox();
			this.lbName = new System.Windows.Forms.Label();
			this.lbDifficulty = new System.Windows.Forms.Label();
			this.lbEquipment = new System.Windows.Forms.Label();
			this.lbRepsNum = new System.Windows.Forms.Label();
			this.lbWeight = new System.Windows.Forms.Label();
			this.tapconExercises.SuspendLayout();
			this.tabAllExercises.SuspendLayout();
			this.tabAddExercise.SuspendLayout();
			this.tabManageExercises.SuspendLayout();
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
			// tabAddExercise
			// 
			this.tabAddExercise.Controls.Add(this.lbWeight);
			this.tabAddExercise.Controls.Add(this.lbRepsNum);
			this.tabAddExercise.Controls.Add(this.lbEquipment);
			this.tabAddExercise.Controls.Add(this.lbDifficulty);
			this.tabAddExercise.Controls.Add(this.lbName);
			this.tabAddExercise.Controls.Add(this.txbWeight);
			this.tabAddExercise.Controls.Add(this.txbEquipment);
			this.tabAddExercise.Controls.Add(this.txbDifficulty);
			this.tabAddExercise.Controls.Add(this.txbRepsNum);
			this.tabAddExercise.Controls.Add(this.txbName);
			this.tabAddExercise.Controls.Add(this.btnCreateExercise);
			this.tabAddExercise.Location = new System.Drawing.Point(4, 25);
			this.tabAddExercise.Name = "tabAddExercise";
			this.tabAddExercise.Padding = new System.Windows.Forms.Padding(3);
			this.tabAddExercise.Size = new System.Drawing.Size(768, 397);
			this.tabAddExercise.TabIndex = 1;
			this.tabAddExercise.Text = "Add Exercise";
			this.tabAddExercise.UseVisualStyleBackColor = true;
			// 
			// tabManageExercises
			// 
			this.tabManageExercises.Controls.Add(this.btnDelete);
			this.tabManageExercises.Controls.Add(this.btnEdit);
			this.tabManageExercises.Controls.Add(this.txbSearchManageExercise);
			this.tabManageExercises.Controls.Add(this.lbManageExercises);
			this.tabManageExercises.Controls.Add(this.btnSearchManageExercises);
			this.tabManageExercises.Location = new System.Drawing.Point(4, 25);
			this.tabManageExercises.Name = "tabManageExercises";
			this.tabManageExercises.Padding = new System.Windows.Forms.Padding(3);
			this.tabManageExercises.Size = new System.Drawing.Size(768, 397);
			this.tabManageExercises.TabIndex = 2;
			this.tabManageExercises.Text = "Manage Exercises";
			this.tabManageExercises.UseVisualStyleBackColor = true;
			// 
			// tabTrainerData
			// 
			this.tabTrainerData.Location = new System.Drawing.Point(4, 25);
			this.tabTrainerData.Name = "tabTrainerData";
			this.tabTrainerData.Padding = new System.Windows.Forms.Padding(3);
			this.tabTrainerData.Size = new System.Drawing.Size(768, 397);
			this.tabTrainerData.TabIndex = 3;
			this.tabTrainerData.Text = "Trainer data";
			this.tabTrainerData.UseVisualStyleBackColor = true;
			// 
			// lbAllExercises
			// 
			this.lbAllExercises.FormattingEnabled = true;
			this.lbAllExercises.ItemHeight = 16;
			this.lbAllExercises.Location = new System.Drawing.Point(147, 123);
			this.lbAllExercises.Name = "lbAllExercises";
			this.lbAllExercises.Size = new System.Drawing.Size(492, 228);
			this.lbAllExercises.TabIndex = 0;
			// 
			// txbSearchBar
			// 
			this.txbSearchBar.Location = new System.Drawing.Point(201, 59);
			this.txbSearchBar.Name = "txbSearchBar";
			this.txbSearchBar.Size = new System.Drawing.Size(288, 22);
			this.txbSearchBar.TabIndex = 1;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(537, 47);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 47);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// btnSearchManageExercises
			// 
			this.btnSearchManageExercises.Location = new System.Drawing.Point(512, 63);
			this.btnSearchManageExercises.Name = "btnSearchManageExercises";
			this.btnSearchManageExercises.Size = new System.Drawing.Size(75, 47);
			this.btnSearchManageExercises.TabIndex = 0;
			this.btnSearchManageExercises.Text = "Search";
			this.btnSearchManageExercises.UseVisualStyleBackColor = true;
			// 
			// lbManageExercises
			// 
			this.lbManageExercises.FormattingEnabled = true;
			this.lbManageExercises.ItemHeight = 16;
			this.lbManageExercises.Location = new System.Drawing.Point(60, 132);
			this.lbManageExercises.Name = "lbManageExercises";
			this.lbManageExercises.Size = new System.Drawing.Size(642, 148);
			this.lbManageExercises.TabIndex = 1;
			// 
			// txbSearchManageExercise
			// 
			this.txbSearchManageExercise.Location = new System.Drawing.Point(221, 75);
			this.txbSearchManageExercise.Name = "txbSearchManageExercise";
			this.txbSearchManageExercise.Size = new System.Drawing.Size(252, 22);
			this.txbSearchManageExercise.TabIndex = 2;
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(265, 329);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 43);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(417, 329);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 43);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnCreateExercise
			// 
			this.btnCreateExercise.Location = new System.Drawing.Point(347, 296);
			this.btnCreateExercise.Name = "btnCreateExercise";
			this.btnCreateExercise.Size = new System.Drawing.Size(75, 43);
			this.btnCreateExercise.TabIndex = 0;
			this.btnCreateExercise.Text = "Create";
			this.btnCreateExercise.UseVisualStyleBackColor = true;
			// 
			// txbName
			// 
			this.txbName.Location = new System.Drawing.Point(121, 104);
			this.txbName.Name = "txbName";
			this.txbName.Size = new System.Drawing.Size(100, 22);
			this.txbName.TabIndex = 1;
			// 
			// txbRepsNum
			// 
			this.txbRepsNum.Location = new System.Drawing.Point(441, 104);
			this.txbRepsNum.Name = "txbRepsNum";
			this.txbRepsNum.Size = new System.Drawing.Size(100, 22);
			this.txbRepsNum.TabIndex = 2;
			// 
			// txbDifficulty
			// 
			this.txbDifficulty.Location = new System.Drawing.Point(121, 155);
			this.txbDifficulty.Name = "txbDifficulty";
			this.txbDifficulty.Size = new System.Drawing.Size(100, 22);
			this.txbDifficulty.TabIndex = 3;
			// 
			// txbEquipment
			// 
			this.txbEquipment.Location = new System.Drawing.Point(121, 196);
			this.txbEquipment.Name = "txbEquipment";
			this.txbEquipment.Size = new System.Drawing.Size(100, 22);
			this.txbEquipment.TabIndex = 4;
			// 
			// txbWeight
			// 
			this.txbWeight.Location = new System.Drawing.Point(441, 146);
			this.txbWeight.Name = "txbWeight";
			this.txbWeight.Size = new System.Drawing.Size(100, 22);
			this.txbWeight.TabIndex = 5;
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Location = new System.Drawing.Point(68, 107);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(47, 16);
			this.lbName.TabIndex = 6;
			this.lbName.Text = "Name:";
			// 
			// lbDifficulty
			// 
			this.lbDifficulty.AutoSize = true;
			this.lbDifficulty.Location = new System.Drawing.Point(56, 158);
			this.lbDifficulty.Name = "lbDifficulty";
			this.lbDifficulty.Size = new System.Drawing.Size(59, 16);
			this.lbDifficulty.TabIndex = 7;
			this.lbDifficulty.Text = "Difficulty:";
			// 
			// lbEquipment
			// 
			this.lbEquipment.AutoSize = true;
			this.lbEquipment.Location = new System.Drawing.Point(41, 199);
			this.lbEquipment.Name = "lbEquipment";
			this.lbEquipment.Size = new System.Drawing.Size(74, 16);
			this.lbEquipment.TabIndex = 8;
			this.lbEquipment.Text = "Equipment:";
			// 
			// lbRepsNum
			// 
			this.lbRepsNum.AutoSize = true;
			this.lbRepsNum.Location = new System.Drawing.Point(392, 107);
			this.lbRepsNum.Name = "lbRepsNum";
			this.lbRepsNum.Size = new System.Drawing.Size(43, 16);
			this.lbRepsNum.TabIndex = 9;
			this.lbRepsNum.Text = "Reps:";
			// 
			// lbWeight
			// 
			this.lbWeight.AutoSize = true;
			this.lbWeight.Location = new System.Drawing.Point(383, 149);
			this.lbWeight.Name = "lbWeight";
			this.lbWeight.Size = new System.Drawing.Size(52, 16);
			this.lbWeight.TabIndex = 10;
			this.lbWeight.Text = "Weight:";
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
			this.tabAddExercise.PerformLayout();
			this.tabManageExercises.ResumeLayout(false);
			this.tabManageExercises.PerformLayout();
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
		private System.Windows.Forms.TextBox txbSearchManageExercise;
		private System.Windows.Forms.ListBox lbManageExercises;
		private System.Windows.Forms.Button btnSearchManageExercises;
		private System.Windows.Forms.Button btnCreateExercise;
		private System.Windows.Forms.TextBox txbWeight;
		private System.Windows.Forms.TextBox txbEquipment;
		private System.Windows.Forms.TextBox txbDifficulty;
		private System.Windows.Forms.TextBox txbRepsNum;
		private System.Windows.Forms.TextBox txbName;
		private System.Windows.Forms.Label lbWeight;
		private System.Windows.Forms.Label lbRepsNum;
		private System.Windows.Forms.Label lbEquipment;
		private System.Windows.Forms.Label lbDifficulty;
		private System.Windows.Forms.Label lbName;
	}
}