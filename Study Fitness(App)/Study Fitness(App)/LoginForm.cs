﻿using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {//Temporary until database is connected!
            if (txbEmail.Text == "admin@email.com" && txbPassword.Text == "1234")
            {
                AppForm app = new AppForm();
                Hide();
                app.Show();
            }
            else
            {
                MessageBox.Show("Incorrect/Missing details!", "ERROR");
            }
        }
    }
}
