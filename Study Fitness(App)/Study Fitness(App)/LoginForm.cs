using ClassLibrary.DatabaseClasses;
using ClassLibrary.UserClasses;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Study_Fitness_App_
{
    public partial class LoginForm : Form
    {
        UserDAL db = new UserDAL();
        UserAdministration myManager = new UserAdministration();
        public User user = new User();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (db.CheckLogin(txbUsername.Text, txbPassword.Text))
            {
                db.GetUserByUsername(myManager, txbUsername.Text);
                user = myManager.GetUser(txbUsername.Text);

                if (user.UserRole == "Admin")
                {
                    MainForm frm = new MainForm();
                    frm.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("Sorry, but you don't have access!", "ERROR");
                }

            }
            else
            {
                MessageBox.Show("Incorrect credentials!", "ERROR");
            }

        }

    }
}
