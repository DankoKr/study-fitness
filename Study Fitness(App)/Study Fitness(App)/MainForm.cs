using ClassLibrary.UserClasses;
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
    public partial class MainForm : Form
    {
        User user;
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
            CheckRole(user);
        }

        private void btnToCardioForm_Click(object sender, EventArgs e)
        {
            CardioForm frm = new CardioForm();
            frm.Show();
        }

        private void btnToExerciseForm_Click(object sender, EventArgs e)
        {
            AppForm frm = new AppForm();
            frm.Show();
        }

        private void btnToUserForm_Click(object sender, EventArgs e)
        {
            UserForm frm = new UserForm();
            frm.Show();
        }

        private void CheckRole(User user)
        {
            if (user.UserRole == "Trainer")
            {
                btnToUserForm.Hide();
                btnToCommentsForm.Hide();
            }
        }

        private void btnToCommentsForm_Click(object sender, EventArgs e)
        {
            CommentForm frm = new CommentForm();
            frm.Show();
        }

        private void btnToScheduleForm_Click(object sender, EventArgs e)
        {
            ScheduleForm frm = new ScheduleForm();
            frm.Show();
        }

        private void ToChartForm_Click(object sender, EventArgs e)
        {
            ChartForm frm = new ChartForm();
            frm.Show();
        }

        private void btnToScheduleStats_Click(object sender, EventArgs e)
        {
            ScheduleStatsForm frm = new ScheduleStatsForm();
            frm.Show();
        }
    }
}
