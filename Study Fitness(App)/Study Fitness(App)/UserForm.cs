using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
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
using System.Xml.Linq;

namespace Study_Fitness_App_
{
    public partial class UserForm : Form
    {
        UserAdministration myManager;
        UserDAL db = new UserDAL();
        public UserForm()
        {
            InitializeComponent();
			IUserDAL db = new UserDAL();
			myManager = new UserAdministration(db);

			// Load existing cardios from the database
			db.LoadUsers(myManager);
		}

        private void btnViewAllUsers_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ClearFields()
        {
            txbUsername.Text = "";
            txbNewUsername.Text = "";
            txbFirstName.Text = "";
            txbPassword.Text = "";
            cmbType.Text = "";
        }

        private void ShowData()
        {
            lbUsers.Items.Clear();
            lbManageUser.Items.Clear();

            foreach (User u in myManager.GetUsers())
            {
                lbUsers.Items.Add(u);
                lbManageUser.Items.Add(u);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a User!");
                return;
            }

            object obj = lbUsers.SelectedItem;
            User selectedU = (User)obj;
            MessageBox.Show(selectedU.GetInfo(), "Data");
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            User newUser = new User(txbFirstName.Text, txbUsername.Text, txbPassword.Text, cmbType.Text);
            myManager.AddUser(newUser);
            ClearFields();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (lbManageUser.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a User!");
                return;
            }

            object obj = lbManageUser.SelectedItem;
            User selectedU = (User)obj;
            myManager.DeleteUser(selectedU);
            ShowData();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (lbManageUser.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a User!");
                return;
            }

            object obj = lbManageUser.SelectedItem;
            User selectedU = (User)obj;
            myManager.ChangeUsername(selectedU, txbNewUsername.Text);
            ClearFields();
            ShowData();
        }
    }
}
