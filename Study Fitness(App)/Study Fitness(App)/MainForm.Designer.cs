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
            btnToUserForm = new Button();
            btnToExerciseForm = new Button();
            btnToCardioForm = new Button();
            panelHeading = new Panel();
            lblHeader = new Label();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            lbCardios = new ListBox();
            lbExercises = new ListBox();
            lblCardios = new Label();
            lblExercise = new Label();
            lblUsers = new Label();
            lbUsers = new ListBox();
            panelButtons.SuspendLayout();
            panelHeading.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.Cyan;
            panelButtons.Controls.Add(btnToUserForm);
            panelButtons.Controls.Add(btnToExerciseForm);
            panelButtons.Controls.Add(btnToCardioForm);
            panelButtons.Location = new Point(1, 82);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(130, 367);
            panelButtons.TabIndex = 0;
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
            // lbCardios
            // 
            lbCardios.FormattingEnabled = true;
            lbCardios.ItemHeight = 20;
            lbCardios.Location = new Point(177, 167);
            lbCardios.Name = "lbCardios";
            lbCardios.Size = new Size(150, 184);
            lbCardios.TabIndex = 3;
            // 
            // lbExercises
            // 
            lbExercises.FormattingEnabled = true;
            lbExercises.ItemHeight = 20;
            lbExercises.Location = new Point(396, 167);
            lbExercises.Name = "lbExercises";
            lbExercises.Size = new Size(150, 184);
            lbExercises.TabIndex = 4;
            // 
            // lblCardios
            // 
            lblCardios.AutoSize = true;
            lblCardios.Location = new Point(177, 144);
            lblCardios.Name = "lblCardios";
            lblCardios.Size = new Size(103, 20);
            lblCardios.TabIndex = 5;
            lblCardios.Text = "Total Cardios :";
            // 
            // lblExercise
            // 
            lblExercise.AutoSize = true;
            lblExercise.Location = new Point(396, 144);
            lblExercise.Name = "lblExercise";
            lblExercise.Size = new Size(112, 20);
            lblExercise.TabIndex = 6;
            lblExercise.Text = "Total Exercises :";
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Location = new Point(612, 144);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(88, 20);
            lblUsers.TabIndex = 7;
            lblUsers.Text = "Total Users :";
            // 
            // lbUsers
            // 
            lbUsers.FormattingEnabled = true;
            lbUsers.ItemHeight = 20;
            lbUsers.Location = new Point(612, 167);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(150, 184);
            lbUsers.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbUsers);
            Controls.Add(lblUsers);
            Controls.Add(lblExercise);
            Controls.Add(lblCardios);
            Controls.Add(lbExercises);
            Controls.Add(lbCardios);
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
            PerformLayout();
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
        private ListBox lbCardios;
        private ListBox lbExercises;
        private Label lblCardios;
        private Label lblExercise;
        private Label lblUsers;
        private ListBox lbUsers;
    }
}