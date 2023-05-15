namespace Study_Fitness_App_
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelButtons = new Panel();
            btnToScheduleForm = new Button();
            btnToCommentsForm = new Button();
            btnToUserForm = new Button();
            btnToExerciseForm = new Button();
            btnToCardioForm = new Button();
            panelHeading = new Panel();
            lblHeader = new Label();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            ToChartForm = new Button();
            btnToScheduleStats = new Button();
            panelButtons.SuspendLayout();
            panelHeading.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.Cyan;
            panelButtons.Controls.Add(btnToScheduleForm);
            panelButtons.Controls.Add(btnToCommentsForm);
            panelButtons.Controls.Add(btnToUserForm);
            panelButtons.Controls.Add(btnToExerciseForm);
            panelButtons.Controls.Add(btnToCardioForm);
            panelButtons.Location = new Point(1, 82);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(130, 367);
            panelButtons.TabIndex = 0;
            // 
            // btnToScheduleForm
            // 
            btnToScheduleForm.BackColor = SystemColors.ActiveCaption;
            btnToScheduleForm.Dock = DockStyle.Top;
            btnToScheduleForm.FlatAppearance.BorderSize = 0;
            btnToScheduleForm.FlatStyle = FlatStyle.Flat;
            btnToScheduleForm.Location = new Point(0, 240);
            btnToScheduleForm.Name = "btnToScheduleForm";
            btnToScheduleForm.Size = new Size(130, 60);
            btnToScheduleForm.TabIndex = 4;
            btnToScheduleForm.Text = "Schedules";
            btnToScheduleForm.UseVisualStyleBackColor = false;
            btnToScheduleForm.Click += btnToScheduleForm_Click;
            // 
            // btnToCommentsForm
            // 
            btnToCommentsForm.BackColor = SystemColors.ActiveCaption;
            btnToCommentsForm.Dock = DockStyle.Top;
            btnToCommentsForm.FlatAppearance.BorderSize = 0;
            btnToCommentsForm.FlatStyle = FlatStyle.Flat;
            btnToCommentsForm.Location = new Point(0, 180);
            btnToCommentsForm.Name = "btnToCommentsForm";
            btnToCommentsForm.Size = new Size(130, 60);
            btnToCommentsForm.TabIndex = 3;
            btnToCommentsForm.Text = "Comments";
            btnToCommentsForm.UseVisualStyleBackColor = false;
            btnToCommentsForm.Click += btnToCommentsForm_Click;
            // 
            // btnToUserForm
            // 
            btnToUserForm.BackColor = SystemColors.ActiveCaption;
            btnToUserForm.Dock = DockStyle.Top;
            btnToUserForm.FlatAppearance.BorderSize = 0;
            btnToUserForm.FlatStyle = FlatStyle.Flat;
            btnToUserForm.Location = new Point(0, 120);
            btnToUserForm.Name = "btnToUserForm";
            btnToUserForm.Size = new Size(130, 60);
            btnToUserForm.TabIndex = 2;
            btnToUserForm.Text = "Users";
            btnToUserForm.UseVisualStyleBackColor = false;
            btnToUserForm.Click += btnToUserForm_Click;
            // 
            // btnToExerciseForm
            // 
            btnToExerciseForm.BackColor = SystemColors.ActiveCaption;
            btnToExerciseForm.Dock = DockStyle.Top;
            btnToExerciseForm.FlatAppearance.BorderSize = 0;
            btnToExerciseForm.FlatStyle = FlatStyle.Flat;
            btnToExerciseForm.Location = new Point(0, 60);
            btnToExerciseForm.Name = "btnToExerciseForm";
            btnToExerciseForm.Size = new Size(130, 60);
            btnToExerciseForm.TabIndex = 1;
            btnToExerciseForm.Text = "Exercise";
            btnToExerciseForm.UseVisualStyleBackColor = false;
            btnToExerciseForm.Click += btnToExerciseForm_Click;
            // 
            // btnToCardioForm
            // 
            btnToCardioForm.BackColor = SystemColors.ActiveCaption;
            btnToCardioForm.Dock = DockStyle.Top;
            btnToCardioForm.FlatAppearance.BorderSize = 0;
            btnToCardioForm.FlatStyle = FlatStyle.Flat;
            btnToCardioForm.Location = new Point(0, 0);
            btnToCardioForm.Name = "btnToCardioForm";
            btnToCardioForm.Size = new Size(130, 60);
            btnToCardioForm.TabIndex = 0;
            btnToCardioForm.Text = "Cardio";
            btnToCardioForm.UseVisualStyleBackColor = false;
            btnToCardioForm.Click += btnToCardioForm_Click;
            // 
            // panelHeading
            // 
            panelHeading.BackColor = Color.Cyan;
            panelHeading.Controls.Add(lblHeader);
            panelHeading.Location = new Point(131, -1);
            panelHeading.Name = "panelHeading";
            panelHeading.Size = new Size(670, 84);
            panelHeading.TabIndex = 1;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHeader.Location = new Point(276, 31);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(95, 28);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Welcome";
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Location = new Point(1, -1);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(130, 84);
            panelLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 84);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ToChartForm
            // 
            ToChartForm.BackColor = SystemColors.ActiveCaption;
            ToChartForm.Location = new Point(318, 227);
            ToChartForm.Name = "ToChartForm";
            ToChartForm.Size = new Size(101, 80);
            ToChartForm.TabIndex = 3;
            ToChartForm.Text = "Statistics Comments";
            ToChartForm.UseVisualStyleBackColor = false;
            ToChartForm.Click += ToChartForm_Click;
            // 
            // btnToScheduleStats
            // 
            btnToScheduleStats.BackColor = SystemColors.ActiveCaption;
            btnToScheduleStats.Location = new Point(474, 227);
            btnToScheduleStats.Name = "btnToScheduleStats";
            btnToScheduleStats.Size = new Size(101, 80);
            btnToScheduleStats.TabIndex = 4;
            btnToScheduleStats.Text = "Statistics Schedules";
            btnToScheduleStats.UseVisualStyleBackColor = false;
            btnToScheduleStats.Click += btnToScheduleStats_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnToScheduleStats);
            Controls.Add(ToChartForm);
            Controls.Add(panelLogo);
            Controls.Add(panelHeading);
            Controls.Add(panelButtons);
            Name = "MainForm";
            Text = "MainForm";
            panelButtons.ResumeLayout(false);
            panelHeading.ResumeLayout(false);
            panelHeading.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Button btnToUserForm;
        private Button btnToExerciseForm;
        private Button btnToCardioForm;
        private Panel panelHeading;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Label lblHeader;
        private Button btnToCommentsForm;
        private Button btnToScheduleForm;
        private Button ToChartForm;
        private Button btnToScheduleStats;
    }
}