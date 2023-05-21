﻿using ClassLibrary.DatabaseClasses;
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
            db.LoadUsers(myManager);
            FillComboBox();
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

        private void FillComboBox()
        {
            cmbTrainerName.Items.Clear();

            foreach (User trainer in myManager.GetUsers())
            {
                if (trainer.UserRole == "Trainer")
                {
                    cmbTrainerName.Items.Add(trainer.Username);
                }
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
                    MessageBox.Show("User created!", "Done");
                }
                else { MessageBox.Show("Dublication of username!", "ERROR"); }
            }
            else
            {
                MessageBox.Show("Incorrect data!", "ERROR");
            }
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
            MessageBox.Show("User deleted!", "Done");
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
            if (txbNewUsername.Text != "" && myManager.ValidateUserIsUnique(txbNewUsername.Text))
            {
                myManager.ChangeUsername(selectedU, txbNewUsername.Text);
                ClearFields();
                ShowData();
                MessageBox.Show("User changed!", "Done");
            }
        }

        private void btnSetLevel_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numLevel.Text) >= 0 && cmbTrainerName.Text != "")
            {
                db.SetTrainerLevel(cmbTrainerName.Text, Convert.ToInt32(numLevel.Text));
                MessageBox.Show("Trainer level changed!", "Done");
            }
            else { MessageBox.Show("Choose a trainer!", "ERROR"); }
        }
    }
}
