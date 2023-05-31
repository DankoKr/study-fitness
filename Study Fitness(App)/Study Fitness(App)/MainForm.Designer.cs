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
            ToChartForm = new Button();
            btnToScheduleStats = new Button();
            btnToScheduleForm = new Button();
            btnToCommentsForm = new Button();
            btnToUserForm = new Button();
            btnToExerciseForm = new Button();
            btnToCardioForm = new Button();
            panelHeading = new Panel();
            pictureBox = new PictureBox();
            lblHeader = new Label();
            panelFormsContent = new Panel();
            panelButtons.SuspendLayout();
            panelHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.Cyan;
            panelButtons.Controls.Add(ToChartForm);
            panelButtons.Controls.Add(btnToScheduleStats);
            panelButtons.Controls.Add(btnToScheduleForm);
            panelButtons.Controls.Add(btnToCommentsForm);
            panelButtons.Controls.Add(btnToUserForm);
            panelButtons.Controls.Add(btnToExerciseForm);
            panelButtons.Controls.Add(btnToCardioForm);
            panelButtons.Dock = DockStyle.Left;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(130, 449);
            panelButtons.TabIndex = 0;
            // 
            // ToChartForm
            // 
            ToChartForm.BackColor = Color.Violet;
            ToChartForm.Dock = DockStyle.Top;
            ToChartForm.FlatAppearance.BorderSize = 0;
            ToChartForm.FlatStyle = FlatStyle.Flat;
            ToChartForm.Location = new Point(0, 384);
            ToChartForm.Name = "ToChartForm";
            ToChartForm.Size = new Size(130, 64);
            ToChartForm.TabIndex = 3;
            ToChartForm.Text = "Statistics Comments";
            ToChartForm.UseVisualStyleBackColor = false;
            ToChartForm.Click += ToChartForm_Click;
            // 
            // btnToScheduleStats
            // 
            btnToScheduleStats.BackColor = Color.Violet;
            btnToScheduleStats.Dock = DockStyle.Top;
            btnToScheduleStats.FlatAppearance.BorderSize = 0;
            btnToScheduleStats.FlatStyle = FlatStyle.Flat;
            btnToScheduleStats.Location = new Point(0, 320);
            btnToScheduleStats.Name = "btnToScheduleStats";
            btnToScheduleStats.Size = new Size(130, 64);
            btnToScheduleStats.TabIndex = 4;
            btnToScheduleStats.Text = "Statistics Schedules";
            btnToScheduleStats.UseVisualStyleBackColor = false;
            btnToScheduleStats.Click += btnToScheduleStats_Click;
            // 
            // btnToScheduleForm
            // 
            btnToScheduleForm.BackColor = Color.Violet;
            btnToScheduleForm.Dock = DockStyle.Top;
            btnToScheduleForm.FlatAppearance.BorderSize = 0;
            btnToScheduleForm.FlatStyle = FlatStyle.Flat;
            btnToScheduleForm.Location = new Point(0, 256);
            btnToScheduleForm.Name = "btnToScheduleForm";
            btnToScheduleForm.Size = new Size(130, 64);
            btnToScheduleForm.TabIndex = 4;
            btnToScheduleForm.Text = "Schedules";
            btnToScheduleForm.UseVisualStyleBackColor = false;
            btnToScheduleForm.Click += btnToScheduleForm_Click;
            // 
            // btnToCommentsForm
            // 
            btnToCommentsForm.BackColor = Color.Violet;
            btnToCommentsForm.Dock = DockStyle.Top;
            btnToCommentsForm.FlatAppearance.BorderSize = 0;
            btnToCommentsForm.FlatStyle = FlatStyle.Flat;
            btnToCommentsForm.Location = new Point(0, 192);
            btnToCommentsForm.Name = "btnToCommentsForm";
            btnToCommentsForm.Size = new Size(130, 64);
            btnToCommentsForm.TabIndex = 3;
            btnToCommentsForm.Text = "Comments";
            btnToCommentsForm.UseVisualStyleBackColor = false;
            btnToCommentsForm.Click += btnToCommentsForm_Click;
            // 
            // btnToUserForm
            // 
            btnToUserForm.BackColor = Color.Violet;
            btnToUserForm.Dock = DockStyle.Top;
            btnToUserForm.FlatAppearance.BorderSize = 0;
            btnToUserForm.FlatStyle = FlatStyle.Flat;
            btnToUserForm.Location = new Point(0, 128);
            btnToUserForm.Name = "btnToUserForm";
            btnToUserForm.Size = new Size(130, 64);
            btnToUserForm.TabIndex = 2;
            btnToUserForm.Text = "Users";
            btnToUserForm.UseVisualStyleBackColor = false;
            btnToUserForm.Click += btnToUserForm_Click;
            // 
            // btnToExerciseForm
            // 
            btnToExerciseForm.BackColor = Color.Violet;
            btnToExerciseForm.Dock = DockStyle.Top;
            btnToExerciseForm.FlatAppearance.BorderSize = 0;
            btnToExerciseForm.FlatStyle = FlatStyle.Flat;
            btnToExerciseForm.Location = new Point(0, 64);
            btnToExerciseForm.Name = "btnToExerciseForm";
            btnToExerciseForm.Size = new Size(130, 64);
            btnToExerciseForm.TabIndex = 1;
            btnToExerciseForm.Text = "Exercise";
            btnToExerciseForm.UseVisualStyleBackColor = false;
            btnToExerciseForm.Click += btnToExerciseForm_Click;
            // 
            // btnToCardioForm
            // 
            btnToCardioForm.BackColor = Color.Violet;
            btnToCardioForm.Dock = DockStyle.Top;
            btnToCardioForm.FlatAppearance.BorderSize = 0;
            btnToCardioForm.FlatStyle = FlatStyle.Flat;
            btnToCardioForm.Location = new Point(0, 0);
            btnToCardioForm.Name = "btnToCardioForm";
            btnToCardioForm.Size = new Size(130, 64);
            btnToCardioForm.TabIndex = 0;
            btnToCardioForm.Text = "Cardio";
            btnToCardioForm.UseVisualStyleBackColor = false;
            btnToCardioForm.Click += btnToCardioForm_Click;
            // 
            // panelHeading
            // 
            panelHeading.BackColor = Color.PaleTurquoise;
            panelHeading.Controls.Add(pictureBox);
            panelHeading.Controls.Add(lblHeader);
            panelHeading.Dock = DockStyle.Top;
            panelHeading.Location = new Point(130, 0);
            panelHeading.Name = "panelHeading";
            panelHeading.Size = new Size(670, 84);
            panelHeading.TabIndex = 1;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Right;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.InitialImage = (Image)resources.GetObject("pictureBox.InitialImage");
            pictureBox.Location = new Point(540, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(130, 84);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHeader.Location = new Point(237, 26);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(168, 28);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Study Fitness App";
            // 
            // panelFormsContent
            // 
            panelFormsContent.BackColor = Color.MistyRose;
            panelFormsContent.Dock = DockStyle.Fill;
            panelFormsContent.Location = new Point(130, 84);
            panelFormsContent.Name = "panelFormsContent";
            panelFormsContent.Size = new Size(670, 365);
            panelFormsContent.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(panelFormsContent);
            Controls.Add(panelHeading);
            Controls.Add(panelButtons);
            Name = "MainForm";
            Text = "MainForm";
            panelButtons.ResumeLayout(false);
            panelHeading.ResumeLayout(false);
            panelHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Button btnToUserForm;
        private Button btnToExerciseForm;
        private Button btnToCardioForm;
        private Panel panelHeading;
        private Panel panelLogo;
        private PictureBox pictureBox;
        private Label lblHeader;
        private Button btnToCommentsForm;
        private Button btnToScheduleForm;
        private Button ToChartForm;
        private Button btnToScheduleStats;
        private Panel panelFormsContent;
    }
}