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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblFamousTrainer = new Label();
            chartSchedules = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartSchedules).BeginInit();
            SuspendLayout();
            // 
            // lblFamousTrainer
            // 
            lblFamousTrainer.AutoSize = true;
            lblFamousTrainer.Location = new Point(34, 67);
            lblFamousTrainer.Name = "lblFamousTrainer";
            lblFamousTrainer.Size = new Size(157, 20);
            lblFamousTrainer.TabIndex = 0;
            lblFamousTrainer.Text = "Most booked Trainer : ";
            // 
            // chartSchedules
            // 
            chartArea1.Name = "ChartArea1";
            chartSchedules.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartSchedules.Legends.Add(legend1);
            chartSchedules.Location = new Point(363, 36);
            chartSchedules.Name = "chartSchedules";
            chartSchedules.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Schedules";
            chartSchedules.Series.Add(series1);
            chartSchedules.Size = new Size(375, 375);
            chartSchedules.TabIndex = 1;
            chartSchedules.Text = "Schedules";
            // 
            // ScheduleStatsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chartSchedules);
            Controls.Add(lblFamousTrainer);
            Name = "ScheduleStatsForm";
            Text = "ScheduleStatsForm";
            ((System.ComponentModel.ISupportInitialize)chartSchedules).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFamousTrainer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSchedules;
    }
}