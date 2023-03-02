using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Fitness
{
    public class UserAdministration
    {//Will be implemented as soon as there is a database!
        List<User> myUsers = new List<User>();

        public void AddUser(User user)
        {
            if (ValidateUserIsUnique(user.Username))
            { 
                myUsers.Add(user);
                MessageBox.Show("Account created!", "Done");
            }
        }

        public void DeleteUser(string username) 
        {
            foreach (User user in myUsers)
            {
                if (user.Username == username)
                {
                    myUsers.Remove(user);
                }
                else
                {
                    MessageBox.Show("No such account!", "ERROR");
                }
            }
        }

        public void EditPassword(string username, string newPassword)
        {
            User selectedUser = GetUser(username);
            myUsers.Remove(GetUser(username));
            selectedUser.ChangePassword(selectedUser, newPassword);
            myUsers.Add(selectedUser);
        }

        public bool ValidateUserIsUnique(string username)
        {
            foreach (User user in myUsers)
            {
                if (user.Username == username)
                {
                    return false;
                }
            }
            return true;
        }

        public User GetUser(string username)
        {
            foreach (User user in myUsers)
            {
                if (username == user.Username)
                {
                    return user;
                }
            }
            return null;
        }


    }
}
