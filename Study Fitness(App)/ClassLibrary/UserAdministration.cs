using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Fitness_App_
{
    public class UserAdministration
    {
        List<User> myUsers = new List<User>();

        public void AddUser(User user)
        {
            if (ValidateUserIsUnique(user.Username))
            {
                myUsers.Add(user);
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
            }
        }

        public void EditPassword(string username, string newPassword)
        {
            User selectedUser = GetUser(username);
            myUsers.Remove(GetUser(username));
            ChangePassword(selectedUser, newPassword);
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

        public void ChangePassword(User user, string newPassword)
        {
            if (newPassword != "")
            {
                user.Password = newPassword;
            }
        }

    }
}
