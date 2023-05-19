using ClassLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private Form activeForm;
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
            CheckRole(user);
        }

        private void btnToCardioForm_Click(object sender, EventArgs e)
        {
            CardioForm frm = new CardioForm();
            OpenChildForm(frm);
        }

        private void btnToExerciseForm_Click(object sender, EventArgs e)
        {
            AppForm frm = new AppForm();
            OpenChildForm(frm);
        }

        private void btnToUserForm_Click(object sender, EventArgs e)
        {
            UserForm frm = new UserForm();
            OpenChildForm(frm);
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
            OpenChildForm(frm);
        }

        private void btnToScheduleForm_Click(object sender, EventArgs e)
        {
            ScheduleForm frm = new ScheduleForm();
            OpenChildForm(frm);
        }

        private void ToChartForm_Click(object sender, EventArgs e)
        {
            ChartForm frm = new ChartForm();
            OpenChildForm(frm);
        }

        private void btnToScheduleStats_Click(object sender, EventArgs e)
        {
            ScheduleStatsForm frm = new ScheduleStatsForm();
            OpenChildForm(frm);
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelFormsContent.Controls.Add(childForm);
            this.panelFormsContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
