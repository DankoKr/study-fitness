namespace Study_Fitness_App_
{
    partial class ChartForm
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
            chartComments = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartComments).BeginInit();
            SuspendLayout();
            // 
            // chartComments
            // 
            chartArea1.Name = "ChartArea1";
            chartComments.ChartAreas.Add(chartArea1);
            legend1.Name = "CommentsLegend";
            legend1.Title = "Legend Rating";
            chartComments.Legends.Add(legend1);
            chartComments.Location = new Point(12, 12);
            chartComments.Name = "chartComments";
            chartComments.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "CommentsLegend";
            series1.Name = "Comments";
            chartComments.Series.Add(series1);
            chartComments.Size = new Size(375, 375);
            chartComments.TabIndex = 0;
            chartComments.Text = "Comments";
            // 
            // ChartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 394);
            Controls.Add(chartComments);
            Name = "ChartForm";
            Text = "ChartForm";
            ((System.ComponentModel.ISupportInitialize)chartComments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartComments;
    }
}