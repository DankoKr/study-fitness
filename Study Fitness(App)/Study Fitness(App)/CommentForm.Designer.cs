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
            btnView.BackColor = Color.Violet;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Location = new Point(220, 252);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 57);
            btnView.TabIndex = 0;
            btnView.Text = "View details";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Violet;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(385, 252);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 57);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbComments
            // 
            lbComments.DisplayMember = "Title";
            lbComments.FormattingEnabled = true;
            lbComments.ItemHeight = 20;
            lbComments.Location = new Point(185, 55);
            lbComments.Name = "lbComments";
            lbComments.Size = new Size(328, 144);
            lbComments.TabIndex = 2;
            // 
            // CommentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(673, 370);
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