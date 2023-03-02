namespace Study_Fitness
{
    partial class NotifierForm
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
            this.lbLatestActions = new System.Windows.Forms.ListBox();
            this.lblLatestActions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLatestActions
            // 
            this.lbLatestActions.FormattingEnabled = true;
            this.lbLatestActions.ItemHeight = 16;
            this.lbLatestActions.Location = new System.Drawing.Point(25, 57);
            this.lbLatestActions.Name = "lbLatestActions";
            this.lbLatestActions.Size = new System.Drawing.Size(281, 372);
            this.lbLatestActions.TabIndex = 0;
            // 
            // lblLatestActions
            // 
            this.lblLatestActions.AutoSize = true;
            this.lblLatestActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatestActions.Location = new System.Drawing.Point(49, 20);
            this.lblLatestActions.Name = "lblLatestActions";
            this.lblLatestActions.Size = new System.Drawing.Size(243, 25);
            this.lblLatestActions.TabIndex = 1;
            this.lblLatestActions.Text = "Latest actions (adds all)";
            // 
            // NotifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.lblLatestActions);
            this.Controls.Add(this.lbLatestActions);
            this.Name = "NotifierForm";
            this.Text = "NotifierForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLatestActions;
        private System.Windows.Forms.Label lblLatestActions;
    }
}