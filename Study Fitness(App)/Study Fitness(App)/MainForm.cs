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
        public MainForm()
        {
            InitializeComponent();
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
    }
}
