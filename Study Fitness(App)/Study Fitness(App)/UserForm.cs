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
        IUserDAL db = new UserDAL();
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows;

        public UserForm()
        {
            InitializeComponent();
            ShowData();
            btnPrevious.Enabled = false;
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
            myManager = new UserAdministration(db);
            db.LoadUsers(myManager, currentPage, pageSize, hasRows);

            foreach (User u in myManager.GetUsers())
            {
                lbUsers.Items.Add(u);
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
            if (txbUsername.Text != "")
            {
                if (myManager.ValidateUserIsUnique(txbUsername.Text))
                {
                    User newUser = new User(txbFirstName.Text, txbUsername.Text, txbPassword.Text, cmbType.Text);
                    myManager.AddUser(newUser);
                    ClearFields();
                    ShowData();
                    MessageBox.Show("User created!", "Done");
                }
                else { MessageBox.Show("Dublication of username!", "ERROR"); }
            }
            else
            {
                MessageBox.Show("Incorrect data!", "ERROR");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            db.LoadUsers(myManager, currentPage, pageSize, hasRows);
            ShowData();
            btnNext.Enabled = hasRows;
            btnPrevious.Enabled = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                db.LoadUsers(myManager, currentPage, pageSize, hasRows);
                ShowData();
                btnNext.Enabled = true;
                if (currentPage == 1)
                {
                    btnPrevious.Enabled = false;
                }
            }
            else { btnPrevious.Enabled = false; }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a User!");
                return;
            }

            object obj = lbUsers.SelectedItem;
            User selectedU = (User)obj;
            if (txbNewUsername.Text != "" && myManager.ValidateUserIsUnique(txbNewUsername.Text))
            {
                myManager.ChangeUsername(selectedU, txbNewUsername.Text);
                ClearFields();
                ShowData();
                MessageBox.Show("User changed!", "Done");
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a User!");
                return;
            }

            object obj = lbUsers.SelectedItem;
            User selectedU = (User)obj;
            myManager.DeleteUser(selectedU);
            ShowData();
            MessageBox.Show("User deleted!", "Done");
        }

        private void btnSetLevel_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Trainer!");
                return;
            }

            object obj = lbUsers.SelectedItem;
            User selectedU = (User)obj;

            if (selectedU.UserRole != "Trainer")
            {
                MessageBox.Show("The Chosen User is not a Trainer!");
                return;
            }

            if (Convert.ToInt32(numLevel.Text) >= 0)
            {
                db.SetTrainerLevel(selectedU.Username, Convert.ToInt32(numLevel.Text));
                MessageBox.Show("Trainer level changed!", "Done");
            }
        }
    }
}
