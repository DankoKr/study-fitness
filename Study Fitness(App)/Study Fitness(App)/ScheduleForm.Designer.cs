namespace Study_Fitness_App_
{
    partial class ScheduleForm
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
            btnViewAllSchedules = new Button();
            btnViewDetails = new Button();
            lbSchedule = new ListBox();
            tabAddCardio = new TabPage();
            btnCreateSchedule = new Button();
            lblTrainer = new Label();
            lblCalories = new Label();
            cmbTrainer = new ComboBox();
            numTime = new NumericUpDown();
            txbDescription = new TextBox();
            txbTitle = new TextBox();
            tabEditCardio = new TabPage();
            lblNewTrainer = new Label();
            lblNewCalories = new Label();
            cmbNewTrainer = new ComboBox();
            numNewTime = new NumericUpDown();
            txbNewDescription = new TextBox();
            txbNewTitle = new TextBox();
            lbManageSchedule = new ListBox();
            btnEdit = new Button();
            btnDelete = new Button();
            tabConCardio.SuspendLayout();
            tabViewCardio.SuspendLayout();
            tabAddCardio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTime).BeginInit();
            tabEditCardio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNewTime).BeginInit();
            SuspendLayout();
            // 
            // tabConCardio
            // 
            tabConCardio.Controls.Add(tabViewCardio);
            tabConCardio.Controls.Add(tabAddCardio);
            tabConCardio.Controls.Add(tabEditCardio);
            tabConCardio.Location = new Point(12, 5);
            tabConCardio.Name = "tabConCardio";
            tabConCardio.SelectedIndex = 0;
            tabConCardio.Size = new Size(632, 368);
            tabConCardio.TabIndex = 1;
            // 
            // tabViewCardio
            // 
            tabViewCardio.Controls.Add(btnViewAllSchedules);
            tabViewCardio.Controls.Add(btnViewDetails);
            tabViewCardio.Controls.Add(lbSchedule);
            tabViewCardio.Location = new Point(4, 29);
            tabViewCardio.Name = "tabViewCardio";
            tabViewCardio.Padding = new Padding(3);
            tabViewCardio.Size = new Size(624, 335);
            tabViewCardio.TabIndex = 0;
            tabViewCardio.Text = "View All";
            tabViewCardio.UseVisualStyleBackColor = true;
            // 
            // btnViewAllSchedules
            // 
            btnViewAllSchedules.Location = new Point(409, 104);
            btnViewAllSchedules.Name = "btnViewAllSchedules";
            btnViewAllSchedules.Size = new Size(94, 60);
            btnViewAllSchedules.TabIndex = 2;
            btnViewAllSchedules.Text = "View All Cardios";
            btnViewAllSchedules.UseVisualStyleBackColor = true;
            btnViewAllSchedules.Click += btnViewAllSchedules_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Location = new Point(409, 170);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(94, 60);
            btnViewDetails.TabIndex = 1;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // lbSchedule
            // 
            lbSchedule.DisplayMember = "Name";
            lbSchedule.FormattingEnabled = true;
            lbSchedule.ItemHeight = 20;
            lbSchedule.Location = new Point(42, 25);
            lbSchedule.Name = "lbSchedule";
            lbSchedule.Size = new Size(253, 264);
            lbSchedule.TabIndex = 0;
            // 
            // tabAddCardio
            // 
            tabAddCardio.Controls.Add(btnCreateSchedule);
            tabAddCardio.Controls.Add(lblTrainer);
            tabAddCardio.Controls.Add(lblCalories);
            tabAddCardio.Controls.Add(cmbTrainer);
            tabAddCardio.Controls.Add(numTime);
            tabAddCardio.Controls.Add(txbDescription);
            tabAddCardio.Controls.Add(txbTitle);
            tabAddCardio.Location = new Point(4, 29);
            tabAddCardio.Name = "tabAddCardio";
            tabAddCardio.Padding = new Padding(3);
            tabAddCardio.Size = new Size(624, 335);
            tabAddCardio.TabIndex = 1;
            tabAddCardio.Text = "Add";
            tabAddCardio.UseVisualStyleBackColor = true;
            // 
            // btnCreateSchedule
            // 
            btnCreateSchedule.Location = new Point(259, 196);
            btnCreateSchedule.Name = "btnCreateSchedule";
            btnCreateSchedule.Size = new Size(94, 54);
            btnCreateSchedule.TabIndex = 7;
            btnCreateSchedule.Text = "Create";
            btnCreateSchedule.UseVisualStyleBackColor = true;
            btnCreateSchedule.Click += btnCreateSchedule_Click;
            // 
            // lblTrainer
            // 
            lblTrainer.AutoSize = true;
            lblTrainer.Location = new Point(308, 70);
            lblTrainer.Name = "lblTrainer";
            lblTrainer.Size = new Size(61, 20);
            lblTrainer.TabIndex = 6;
            lblTrainer.Text = "Trainer :";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Location = new Point(51, 125);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(49, 20);
            lblCalories.TabIndex = 5;
            lblCalories.Text = "Time :";
            // 
            // cmbTrainer
            // 
            cmbTrainer.FormattingEnabled = true;
            cmbTrainer.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced", "Athlete" });
            cmbTrainer.Location = new Point(375, 67);
            cmbTrainer.Name = "cmbTrainer";
            cmbTrainer.Size = new Size(151, 28);
            cmbTrainer.TabIndex = 4;
            // 
            // numTime
            // 
            numTime.Location = new Point(106, 123);
            numTime.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numTime.Name = "numTime";
            numTime.Size = new Size(150, 27);
            numTime.TabIndex = 3;
            // 
            // txbDescription
            // 
            txbDescription.Location = new Point(375, 123);
            txbDescription.Name = "txbDescription";
            txbDescription.PlaceholderText = "Description";
            txbDescription.Size = new Size(125, 27);
            txbDescription.TabIndex = 1;
            // 
            // txbTitle
            // 
            txbTitle.Location = new Point(106, 68);
            txbTitle.Name = "txbTitle";
            txbTitle.PlaceholderText = "Title";
            txbTitle.Size = new Size(125, 27);
            txbTitle.TabIndex = 0;
            // 
            // tabEditCardio
            // 
            tabEditCardio.Controls.Add(lblNewTrainer);
            tabEditCardio.Controls.Add(lblNewCalories);
            tabEditCardio.Controls.Add(cmbNewTrainer);
            tabEditCardio.Controls.Add(numNewTime);
            tabEditCardio.Controls.Add(txbNewDescription);
            tabEditCardio.Controls.Add(txbNewTitle);
            tabEditCardio.Controls.Add(lbManageSchedule);
            tabEditCardio.Controls.Add(btnEdit);
            tabEditCardio.Controls.Add(btnDelete);
            tabEditCardio.Location = new Point(4, 29);
            tabEditCardio.Name = "tabEditCardio";
            tabEditCardio.Padding = new Padding(3);
            tabEditCardio.Size = new Size(624, 335);
            tabEditCardio.TabIndex = 2;
            tabEditCardio.Text = "Edit/Delete";
            tabEditCardio.UseVisualStyleBackColor = true;
            // 
            // lblNewTrainer
            // 
            lblNewTrainer.AutoSize = true;
            lblNewTrainer.Location = new Point(455, 53);
            lblNewTrainer.Name = "lblNewTrainer";
            lblNewTrainer.Size = new Size(95, 20);
            lblNewTrainer.TabIndex = 12;
            lblNewTrainer.Text = "New Trainer :";
            // 
            // lblNewCalories
            // 
            lblNewCalories.AutoSize = true;
            lblNewCalories.Location = new Point(283, 126);
            lblNewCalories.Name = "lblNewCalories";
            lblNewCalories.Size = new Size(45, 20);
            lblNewCalories.TabIndex = 11;
            lblNewCalories.Text = "Title :";
            // 
            // cmbNewTrainer
            // 
            cmbNewTrainer.FormattingEnabled = true;
            cmbNewTrainer.Items.AddRange(new object[] { "Beginner", "Intermediate", "Advanced", "Athlete" });
            cmbNewTrainer.Location = new Point(455, 76);
            cmbNewTrainer.Name = "cmbNewTrainer";
            cmbNewTrainer.Size = new Size(125, 28);
            cmbNewTrainer.TabIndex = 10;
            // 
            // numNewTime
            // 
            numNewTime.Location = new Point(283, 149);
            numNewTime.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numNewTime.Name = "numNewTime";
            numNewTime.Size = new Size(125, 27);
            numNewTime.TabIndex = 9;
            // 
            // txbNewDescription
            // 
            txbNewDescription.Location = new Point(455, 149);
            txbNewDescription.Name = "txbNewDescription";
            txbNewDescription.PlaceholderText = "Description";
            txbNewDescription.Size = new Size(125, 27);
            txbNewDescription.TabIndex = 8;
            // 
            // txbNewTitle
            // 
            txbNewTitle.Location = new Point(283, 76);
            txbNewTitle.Name = "txbNewTitle";
            txbNewTitle.PlaceholderText = "Title";
            txbNewTitle.Size = new Size(125, 27);
            txbNewTitle.TabIndex = 7;
            // 
            // lbManageSchedule
            // 
            lbManageSchedule.DisplayMember = "Name";
            lbManageSchedule.FormattingEnabled = true;
            lbManageSchedule.ItemHeight = 20;
            lbManageSchedule.Location = new Point(49, 39);
            lbManageSchedule.Name = "lbManageSchedule";
            lbManageSchedule.Size = new Size(150, 264);
            lbManageSchedule.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(314, 222);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 44);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(455, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 44);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 381);
            Controls.Add(tabConCardio);
            Name = "ScheduleForm";
            Text = "ScheduleForm";
            tabConCardio.ResumeLayout(false);
            tabViewCardio.ResumeLayout(false);
            tabAddCardio.ResumeLayout(false);
            tabAddCardio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTime).EndInit();
            tabEditCardio.ResumeLayout(false);
            tabEditCardio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNewTime).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabConCardio;
        private TabPage tabViewCardio;
        private Button btnViewAllSchedules;
        private Button btnViewDetails;
        private ListBox lbSchedule;
        private TabPage tabAddCardio;
        private Button btnCreateSchedule;
        private Label lblTrainer;
        private Label lblCalories;
        private ComboBox cmbTrainer;
        private NumericUpDown numTime;
        private TextBox txbDescription;
        private TextBox txbTitle;
        private TabPage tabEditCardio;
        private Label lblNewTrainer;
        private Label lblNewCalories;
        private ComboBox cmbNewTrainer;
        private NumericUpDown numNewTime;
        private TextBox txbNewDescription;
        private TextBox txbNewTitle;
        private ListBox lbManageSchedule;
        private Button btnEdit;
        private Button btnDelete;
    }
}