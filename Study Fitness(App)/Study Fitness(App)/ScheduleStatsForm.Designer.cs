namespace Study_Fitness_App_
{
    partial class ScheduleStatsForm
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
            lblFamousTrainer = new Label();
            SuspendLayout();
            // 
            // lblFamousTrainer
            // 
            lblFamousTrainer.AutoSize = true;
            lblFamousTrainer.Location = new Point(189, 79);
            lblFamousTrainer.Name = "lblFamousTrainer";
            lblFamousTrainer.Size = new Size(157, 20);
            lblFamousTrainer.TabIndex = 0;
            lblFamousTrainer.Text = "Most booked Trainer : ";
            // 
            // ScheduleStatsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFamousTrainer);
            Name = "ScheduleStatsForm";
            Text = "ScheduleStatsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFamousTrainer;
    }
}