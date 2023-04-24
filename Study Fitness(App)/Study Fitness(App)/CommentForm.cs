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
        public CommentForm()
        {
            InitializeComponent();
            myManager = new CommentAdministration(db);
            db.LoadComments(myManager);
            ShowData(); 
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (lbComments.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a User!");
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
                MessageBox.Show("Please choose a User!");
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
            foreach (Comment comment in myManager.GetComments())
            {
                lbComments.Items.Add(comment);
            }
        }
    }
}
