using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Fitness_App_
{
    public partial class CommentForm : Form
    {
        CommentAdministration myManager;
        ICommentDAL db = new CommentDAL();
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows;

        public CommentForm()
        {
            InitializeComponent();
            ShowData();
            btnPrevious.Enabled = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (lbComments.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Comment!");
                return;
            }

            object obj = lbComments.SelectedItem;
            Comment selectedC = (Comment)obj;
            MessageBox.Show(selectedC.GetInfo(), "Data");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbComments.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Comment!");
                return;
            }

            object obj = lbComments.SelectedItem;
            Comment selectedC = (Comment)obj;
            myManager.RemoveComment(selectedC);
            ShowData();
        }

        private void ShowData()
        {
            lbComments.Items.Clear();
            myManager = new CommentAdministration(db);
            db.LoadComments(myManager, currentPage, pageSize, hasRows);

            foreach (Comment comment in myManager.GetComments())
            {
                lbComments.Items.Add(comment);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                db.LoadComments(myManager, currentPage, pageSize, hasRows);
                ShowData();
                btnNext.Enabled = true;
                if (currentPage == 1)
                {
                    btnPrevious.Enabled = false;
                }
            }
            else { btnPrevious.Enabled = false; }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            db.LoadComments(myManager, currentPage, pageSize, hasRows);
            ShowData();
            btnNext.Enabled = hasRows;
            btnPrevious.Enabled = true;
        }
    }
}
