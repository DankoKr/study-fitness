using ClassLibrary.DatabaseClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Study_Fitness_App_
{
    public partial class LoginForm : Form
    {
        UserDAL db = new UserDAL();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (db.CheckLogin(txbEmail.Text, txbPassword.Text))
            {
                MainForm frm = new MainForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect credentials!", "ERROR");
            }

        }

    }
}
