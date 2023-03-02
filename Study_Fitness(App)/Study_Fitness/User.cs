﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Fitness
{
	public class User
	{
		private string firstName;
		private string username;
		private string password;

		public string FirstName { get; private set; }

		public string Username { get; private set; }

		public string Password { get; private set; }

		public User(string name, string username, string password ) 
		{
		    this.FirstName = name;
			this.Username = username;
			this.Password = password;
		}

        public void ChangePassword(User user, string newPassword)
        {
            if (newPassword != "")
            {
				user.Password = newPassword;
                MessageBox.Show("Password changed!", "Done");
            }
            else
            {
                MessageBox.Show("Inccorect data!", "ERROR");
            }
        }

    }
}
