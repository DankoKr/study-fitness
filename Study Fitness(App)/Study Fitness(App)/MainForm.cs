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
            }
        }
    }
}
