namespace Study_Fitness_App_
{
    partial class CommentForm
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
            btnView = new Button();
            btnDelete = new Button();
            lbComments = new ListBox();
            SuspendLayout();
            // 
            // btnView
            // 
            btnView.Location = new Point(104, 256);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 57);
            btnView.TabIndex = 0;
            btnView.Text = "View details";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(284, 256);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 57);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbComments
            // 
            lbComments.DisplayMember = "Title";
            lbComments.FormattingEnabled = true;
            lbComments.ItemHeight = 20;
            lbComments.Location = new Point(84, 59);
            lbComments.Name = "lbComments";
            lbComments.Size = new Size(328, 144);
            lbComments.TabIndex = 2;
            // 
            // CommentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 362);
            Controls.Add(lbComments);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Name = "CommentForm";
            Text = "CommentForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnView;
        private Button btnDelete;
        private ListBox lbComments;
    }
}