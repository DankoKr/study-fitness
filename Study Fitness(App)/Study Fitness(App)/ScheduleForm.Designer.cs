﻿namespace Study_Fitness_App_
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
            dateTime = new DateTimePicker();
            btnCreateSchedule = new Button();
            lblTrainer = new Label();
            lblTime = new Label();
            cmbTrainer = new ComboBox();
            txbDescription = new TextBox();
            txbTitle = new TextBox();
            tabEditCardio = new TabPage();
            dateNewTime = new DateTimePicker();
            lblNewTrainer = new Label();
            lblNewTime = new Label();
            cmbNewTrainer = new ComboBox();
            txbNewDescription = new TextBox();
            txbNewTitle = new TextBox();
            lbManageSchedule = new ListBox();
            btnEdit = new Button();
            btnDelete = new Button();
            tabTrainerSchedule = new TabPage();
            btnViewTrainerSchedule = new Button();
            btnShowTrainerSchedules = new Button();
            cmbTrainerId = new ComboBox();
            lbScheduleTrainer = new ListBox();
            tabConCardio.SuspendLayout();
            tabViewCardio.SuspendLayout();
            tabAddCardio.SuspendLayout();
            tabEditCardio.SuspendLayout();
            tabTrainerSchedule.SuspendLayout();
            SuspendLayout();
            // 
            // tabConCardio
            // 
            tabConCardio.Controls.Add(tabViewCardio);
            tabConCardio.Controls.Add(tabAddCardio);
            tabConCardio.Controls.Add(tabEditCardio);
            tabConCardio.Controls.Add(tabTrainerSchedule);
            tabConCardio.Location = new Point(12, 2);
            tabConCardio.Name = "tabConCardio";
            tabConCardio.SelectedIndex = 0;
            tabConCardio.Size = new Size(632, 356);
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
            tabViewCardio.Size = new Size(624, 323);
            tabViewCardio.TabIndex = 0;
            tabViewCardio.Text = "View All";
            tabViewCardio.UseVisualStyleBackColor = true;
            // 
            // btnViewAllSchedules
            // 
            btnViewAllSchedules.BackColor = Color.Violet;
            btnViewAllSchedules.FlatStyle = FlatStyle.Flat;
            btnViewAllSchedules.Location = new Point(409, 104);
            btnViewAllSchedules.Name = "btnViewAllSchedules";
            btnViewAllSchedules.Size = new Size(94, 60);
            btnViewAllSchedules.TabIndex = 2;
            btnViewAllSchedules.Text = "View All Schedules";
            btnViewAllSchedules.UseVisualStyleBackColor = false;
            btnViewAllSchedules.Click += btnViewAllSchedules_Click;
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
            // lbSchedule
            // 
            lbSchedule.DisplayMember = "Title";
            lbSchedule.FormattingEnabled = true;
            lbSchedule.ItemHeight = 20;
            lbSchedule.Location = new Point(42, 25);
            lbSchedule.Name = "lbSchedule";
            lbSchedule.Size = new Size(253, 264);
            lbSchedule.TabIndex = 0;
            // 
            // tabAddCardio
            // 
            tabAddCardio.Controls.Add(dateTime);
            tabAddCardio.Controls.Add(btnCreateSchedule);
            tabAddCardio.Controls.Add(lblTrainer);
            tabAddCardio.Controls.Add(lblTime);
            tabAddCardio.Controls.Add(cmbTrainer);
            tabAddCardio.Controls.Add(txbDescription);
            tabAddCardio.Controls.Add(txbTitle);
            tabAddCardio.Location = new Point(4, 29);
            tabAddCardio.Name = "tabAddCardio";
            tabAddCardio.Padding = new Padding(3);
            tabAddCardio.Size = new Size(624, 323);
            tabAddCardio.TabIndex = 1;
            tabAddCardio.Text = "Add";
            tabAddCardio.UseVisualStyleBackColor = true;
            // 
            // dateTime
            // 
            dateTime.Format = DateTimePickerFormat.Short;
            dateTime.Location = new Point(106, 125);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(125, 27);
            dateTime.TabIndex = 14;
            dateTime.Value = new DateTime(2023, 5, 20, 0, 0, 0, 0);
            // 
            // btnCreateSchedule
            // 
            btnCreateSchedule.BackColor = Color.Violet;
            btnCreateSchedule.FlatStyle = FlatStyle.Flat;
            btnCreateSchedule.Location = new Point(259, 196);
            btnCreateSchedule.Name = "btnCreateSchedule";
            btnCreateSchedule.Size = new Size(94, 54);
            btnCreateSchedule.TabIndex = 7;
            btnCreateSchedule.Text = "Create";
            btnCreateSchedule.UseVisualStyleBackColor = false;
            btnCreateSchedule.Click += btnCreateSchedule_Click;
            // 
            // lblTrainer
            // 
            lblTrainer.AutoSize = true;
            lblTrainer.Location = new Point(289, 71);
            lblTrainer.Name = "lblTrainer";
            lblTrainer.Size = new Size(80, 20);
            lblTrainer.TabIndex = 6;
            lblTrainer.Text = "Trainer ID :";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(51, 125);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(49, 20);
            lblTime.TabIndex = 5;
            lblTime.Text = "Time :";
            // 
            // cmbTrainer
            // 
            cmbTrainer.FormattingEnabled = true;
            cmbTrainer.Location = new Point(375, 67);
            cmbTrainer.Name = "cmbTrainer";
            cmbTrainer.Size = new Size(151, 28);
            cmbTrainer.TabIndex = 4;
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
            tabEditCardio.Controls.Add(dateNewTime);
            tabEditCardio.Controls.Add(lblNewTrainer);
            tabEditCardio.Controls.Add(lblNewTime);
            tabEditCardio.Controls.Add(cmbNewTrainer);
            tabEditCardio.Controls.Add(txbNewDescription);
            tabEditCardio.Controls.Add(txbNewTitle);
            tabEditCardio.Controls.Add(lbManageSchedule);
            tabEditCardio.Controls.Add(btnEdit);
            tabEditCardio.Controls.Add(btnDelete);
            tabEditCardio.Location = new Point(4, 29);
            tabEditCardio.Name = "tabEditCardio";
            tabEditCardio.Padding = new Padding(3);
            tabEditCardio.Size = new Size(624, 323);
            tabEditCardio.TabIndex = 2;
            tabEditCardio.Text = "Edit/Delete";
            tabEditCardio.UseVisualStyleBackColor = true;
            // 
            // dateNewTime
            // 
            dateNewTime.Format = DateTimePickerFormat.Short;
            dateNewTime.Location = new Point(283, 154);
            dateNewTime.Name = "dateNewTime";
            dateNewTime.Size = new Size(125, 27);
            dateNewTime.TabIndex = 13;
            dateNewTime.Value = new DateTime(2023, 5, 20, 0, 0, 0, 0);
            // 
            // lblNewTrainer
            // 
            lblNewTrainer.AutoSize = true;
            lblNewTrainer.Location = new Point(455, 53);
            lblNewTrainer.Name = "lblNewTrainer";
            lblNewTrainer.Size = new Size(114, 20);
            lblNewTrainer.TabIndex = 12;
            lblNewTrainer.Text = "New Trainer ID :";
            // 
            // lblNewTime
            // 
            lblNewTime.AutoSize = true;
            lblNewTime.Location = new Point(283, 126);
            lblNewTime.Name = "lblNewTime";
            lblNewTime.Size = new Size(49, 20);
            lblNewTime.TabIndex = 11;
            lblNewTime.Text = "Time :";
            // 
            // cmbNewTrainer
            // 
            cmbNewTrainer.FormattingEnabled = true;
            cmbNewTrainer.Location = new Point(455, 76);
            cmbNewTrainer.Name = "cmbNewTrainer";
            cmbNewTrainer.Size = new Size(125, 28);
            cmbNewTrainer.TabIndex = 10;
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
            lbManageSchedule.DisplayMember = "Title";
            lbManageSchedule.FormattingEnabled = true;
            lbManageSchedule.ItemHeight = 20;
            lbManageSchedule.Location = new Point(49, 39);
            lbManageSchedule.Name = "lbManageSchedule";
            lbManageSchedule.Size = new Size(183, 264);
            lbManageSchedule.TabIndex = 2;
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
            // tabTrainerSchedule
            // 
            tabTrainerSchedule.Controls.Add(btnViewTrainerSchedule);
            tabTrainerSchedule.Controls.Add(btnShowTrainerSchedules);
            tabTrainerSchedule.Controls.Add(cmbTrainerId);
            tabTrainerSchedule.Controls.Add(lbScheduleTrainer);
            tabTrainerSchedule.Location = new Point(4, 29);
            tabTrainerSchedule.Name = "tabTrainerSchedule";
            tabTrainerSchedule.Padding = new Padding(3);
            tabTrainerSchedule.Size = new Size(624, 323);
            tabTrainerSchedule.TabIndex = 3;
            tabTrainerSchedule.Text = "Trainer Schedule";
            tabTrainerSchedule.UseVisualStyleBackColor = true;
            // 
            // btnViewTrainerSchedule
            // 
            btnViewTrainerSchedule.BackColor = Color.Violet;
            btnViewTrainerSchedule.FlatStyle = FlatStyle.Flat;
            btnViewTrainerSchedule.Location = new Point(375, 210);
            btnViewTrainerSchedule.Name = "btnViewTrainerSchedule";
            btnViewTrainerSchedule.Size = new Size(94, 60);
            btnViewTrainerSchedule.TabIndex = 4;
            btnViewTrainerSchedule.Text = "View Details";
            btnViewTrainerSchedule.UseVisualStyleBackColor = false;
            btnViewTrainerSchedule.Click += btnViewTrainerSchedule_Click;
            // 
            // btnShowTrainerSchedules
            // 
            btnShowTrainerSchedules.BackColor = Color.Violet;
            btnShowTrainerSchedules.FlatStyle = FlatStyle.Flat;
            btnShowTrainerSchedules.Location = new Point(375, 146);
            btnShowTrainerSchedules.Name = "btnShowTrainerSchedules";
            btnShowTrainerSchedules.Size = new Size(94, 58);
            btnShowTrainerSchedules.TabIndex = 3;
            btnShowTrainerSchedules.Text = "Show Schedules";
            btnShowTrainerSchedules.UseVisualStyleBackColor = false;
            btnShowTrainerSchedules.Click += btnShowTrainerSchedules_Click;
            // 
            // cmbTrainerId
            // 
            cmbTrainerId.FormattingEnabled = true;
            cmbTrainerId.Location = new Point(345, 93);
            cmbTrainerId.Name = "cmbTrainerId";
            cmbTrainerId.Size = new Size(151, 28);
            cmbTrainerId.TabIndex = 2;
            // 
            // lbScheduleTrainer
            // 
            lbScheduleTrainer.DisplayMember = "Title";
            lbScheduleTrainer.FormattingEnabled = true;
            lbScheduleTrainer.ItemHeight = 20;
            lbScheduleTrainer.Location = new Point(94, 74);
            lbScheduleTrainer.Name = "lbScheduleTrainer";
            lbScheduleTrainer.Size = new Size(150, 204);
            lbScheduleTrainer.TabIndex = 0;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(673, 370);
            Controls.Add(tabConCardio);
            Name = "ScheduleForm";
            Text = "ScheduleForm";
            tabConCardio.ResumeLayout(false);
            tabViewCardio.ResumeLayout(false);
            tabAddCardio.ResumeLayout(false);
            tabAddCardio.PerformLayout();
            tabEditCardio.ResumeLayout(false);
            tabEditCardio.PerformLayout();
            tabTrainerSchedule.ResumeLayout(false);
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
        private Label lblTime;
        private ComboBox cmbTrainer;
        private TextBox txbDescription;
        private TextBox txbTitle;
        private TabPage tabEditCardio;
        private Label lblNewTrainer;
        private Label lblNewTime;
        private ComboBox cmbNewTrainer;
        private TextBox txbNewDescription;
        private TextBox txbNewTitle;
        private ListBox lbManageSchedule;
        private Button btnEdit;
        private Button btnDelete;
        private DateTimePicker dateNewTime;
        private DateTimePicker dateTime;
        private TabPage tabTrainerSchedule;
        private ListBox lbScheduleTrainer;
        private Button btnShowTrainerSchedules;
        private ComboBox cmbTrainerId;
        private Button btnViewTrainerSchedule;
    }
}