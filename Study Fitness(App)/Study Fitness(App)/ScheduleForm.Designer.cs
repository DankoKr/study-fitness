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
            tabFunctions = new TabControl();
            tabDetailsAndDelete = new TabPage();
            btnDelete = new Button();
            btnViewDetails = new Button();
            tabEdit = new TabPage();
            dateNewTime = new DateTimePicker();
            lblNewTrainer = new Label();
            lblNewTime = new Label();
            cmbNewTrainer = new ComboBox();
            txbNewDescription = new TextBox();
            txbNewTitle = new TextBox();
            btnEdit = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            lbSchedule = new ListBox();
            tabAddCardio = new TabPage();
            dateTime = new DateTimePicker();
            btnCreateSchedule = new Button();
            lblTrainer = new Label();
            lblTime = new Label();
            cmbTrainer = new ComboBox();
            txbDescription = new TextBox();
            txbTitle = new TextBox();
            tabTrainerSchedule = new TabPage();
            btnViewTrainerSchedule = new Button();
            btnShowTrainerSchedules = new Button();
            cmbTrainerId = new ComboBox();
            lbScheduleTrainer = new ListBox();
            tabConCardio.SuspendLayout();
            tabViewCardio.SuspendLayout();
            tabFunctions.SuspendLayout();
            tabDetailsAndDelete.SuspendLayout();
            tabEdit.SuspendLayout();
            tabAddCardio.SuspendLayout();
            tabTrainerSchedule.SuspendLayout();
            SuspendLayout();
            // 
            // tabConCardio
            // 
            tabConCardio.Controls.Add(tabViewCardio);
            tabConCardio.Controls.Add(tabAddCardio);
            tabConCardio.Controls.Add(tabTrainerSchedule);
            tabConCardio.Location = new Point(12, 2);
            tabConCardio.Name = "tabConCardio";
            tabConCardio.SelectedIndex = 0;
            tabConCardio.Size = new Size(632, 356);
            tabConCardio.TabIndex = 1;
            // 
            // tabViewCardio
            // 
            tabViewCardio.Controls.Add(tabFunctions);
            tabViewCardio.Controls.Add(btnNext);
            tabViewCardio.Controls.Add(btnPrevious);
            tabViewCardio.Controls.Add(lbSchedule);
            tabViewCardio.Location = new Point(4, 29);
            tabViewCardio.Name = "tabViewCardio";
            tabViewCardio.Padding = new Padding(3);
            tabViewCardio.Size = new Size(624, 323);
            tabViewCardio.TabIndex = 0;
            tabViewCardio.Text = "View All";
            tabViewCardio.UseVisualStyleBackColor = true;
            // 
            // tabFunctions
            // 
            tabFunctions.Controls.Add(tabDetailsAndDelete);
            tabFunctions.Controls.Add(tabEdit);
            tabFunctions.Location = new Point(339, 25);
            tabFunctions.Name = "tabFunctions";
            tabFunctions.SelectedIndex = 0;
            tabFunctions.Size = new Size(267, 229);
            tabFunctions.TabIndex = 11;
            // 
            // tabDetailsAndDelete
            // 
            tabDetailsAndDelete.Controls.Add(btnDelete);
            tabDetailsAndDelete.Controls.Add(btnViewDetails);
            tabDetailsAndDelete.Location = new Point(4, 29);
            tabDetailsAndDelete.Name = "tabDetailsAndDelete";
            tabDetailsAndDelete.Padding = new Padding(3);
            tabDetailsAndDelete.Size = new Size(259, 196);
            tabDetailsAndDelete.TabIndex = 0;
            tabDetailsAndDelete.Text = "Details/Delete";
            tabDetailsAndDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Violet;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(143, 75);
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
            btnViewDetails.Location = new Point(24, 75);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(94, 60);
            btnViewDetails.TabIndex = 1;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // tabEdit
            // 
            tabEdit.Controls.Add(dateNewTime);
            tabEdit.Controls.Add(lblNewTrainer);
            tabEdit.Controls.Add(lblNewTime);
            tabEdit.Controls.Add(cmbNewTrainer);
            tabEdit.Controls.Add(txbNewDescription);
            tabEdit.Controls.Add(txbNewTitle);
            tabEdit.Controls.Add(btnEdit);
            tabEdit.Location = new Point(4, 29);
            tabEdit.Name = "tabEdit";
            tabEdit.Padding = new Padding(3);
            tabEdit.Size = new Size(259, 196);
            tabEdit.TabIndex = 1;
            tabEdit.Text = "Edit";
            tabEdit.UseVisualStyleBackColor = true;
            // 
            // dateNewTime
            // 
            dateNewTime.Format = DateTimePickerFormat.Short;
            dateNewTime.Location = new Point(16, 71);
            dateNewTime.Name = "dateNewTime";
            dateNewTime.Size = new Size(125, 27);
            dateNewTime.TabIndex = 20;
            dateNewTime.Value = new DateTime(2023, 5, 20, 0, 0, 0, 0);
            // 
            // lblNewTrainer
            // 
            lblNewTrainer.AutoSize = true;
            lblNewTrainer.Location = new Point(16, 101);
            lblNewTrainer.Name = "lblNewTrainer";
            lblNewTrainer.Size = new Size(114, 20);
            lblNewTrainer.TabIndex = 19;
            lblNewTrainer.Text = "New Trainer ID :";
            // 
            // lblNewTime
            // 
            lblNewTime.AutoSize = true;
            lblNewTime.Location = new Point(16, 48);
            lblNewTime.Name = "lblNewTime";
            lblNewTime.Size = new Size(49, 20);
            lblNewTime.TabIndex = 18;
            lblNewTime.Text = "Time :";
            // 
            // cmbNewTrainer
            // 
            cmbNewTrainer.FormattingEnabled = true;
            cmbNewTrainer.Location = new Point(16, 124);
            cmbNewTrainer.Name = "cmbNewTrainer";
            cmbNewTrainer.Size = new Size(125, 28);
            cmbNewTrainer.TabIndex = 17;
            // 
            // txbNewDescription
            // 
            txbNewDescription.Location = new Point(16, 158);
            txbNewDescription.Name = "txbNewDescription";
            txbNewDescription.PlaceholderText = "Description";
            txbNewDescription.Size = new Size(125, 27);
            txbNewDescription.TabIndex = 16;
            // 
            // txbNewTitle
            // 
            txbNewTitle.Location = new Point(16, 18);
            txbNewTitle.Name = "txbNewTitle";
            txbNewTitle.PlaceholderText = "Title";
            txbNewTitle.Size = new Size(125, 27);
            txbNewTitle.TabIndex = 15;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Violet;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(171, 73);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(71, 44);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Violet;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Location = new Point(188, 248);
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
            btnPrevious.Location = new Point(52, 248);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 34);
            btnPrevious.TabIndex = 9;
            btnPrevious.Text = "previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lbSchedule
            // 
            lbSchedule.DisplayMember = "Title";
            lbSchedule.FormattingEnabled = true;
            lbSchedule.ItemHeight = 20;
            lbSchedule.Location = new Point(42, 25);
            lbSchedule.Name = "lbSchedule";
            lbSchedule.Size = new Size(253, 204);
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
            lbScheduleTrainer.Location = new Point(73, 66);
            lbScheduleTrainer.Name = "lbScheduleTrainer";
            lbScheduleTrainer.Size = new Size(208, 204);
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
            tabFunctions.ResumeLayout(false);
            tabDetailsAndDelete.ResumeLayout(false);
            tabEdit.ResumeLayout(false);
            tabEdit.PerformLayout();
            tabAddCardio.ResumeLayout(false);
            tabAddCardio.PerformLayout();
            tabTrainerSchedule.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabConCardio;
        private TabPage tabViewCardio;
        private Button btnViewDetails;
        private ListBox lbSchedule;
        private TabPage tabAddCardio;
        private Button btnCreateSchedule;
        private Label lblTrainer;
        private Label lblTime;
        private ComboBox cmbTrainer;
        private TextBox txbDescription;
        private TextBox txbTitle;
        private DateTimePicker dateTime;
        private TabPage tabTrainerSchedule;
        private ListBox lbScheduleTrainer;
        private Button btnShowTrainerSchedules;
        private ComboBox cmbTrainerId;
        private Button btnViewTrainerSchedule;
        private Button btnNext;
        private Button btnPrevious;
        private TabControl tabFunctions;
        private TabPage tabDetailsAndDelete;
        private Button btnDelete;
        private TabPage tabEdit;
        private DateTimePicker dateNewTime;
        private Label lblNewTrainer;
        private Label lblNewTime;
        private ComboBox cmbNewTrainer;
        private TextBox txbNewDescription;
        private TextBox txbNewTitle;
        private Button btnEdit;
    }
}