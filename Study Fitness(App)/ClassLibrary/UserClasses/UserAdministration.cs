using ClassLibrary.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.UserClasses
{
    public class UserAdministration
    {
        List<User> myUsers = new List<User>();
        UserDAL db = new UserDAL(); 

        public void AddUser(User user)
        {
            if (ValidateUserIsUnique(user.Username))
            {
                myUsers.Add(user);
                db.CreateUser(user);
            }
        }

        public void AddExistingUser(User user) 
        {
            myUsers.Add(user);
        }


        public void DeleteUser(User u)
        {
            myUsers.Remove(u);
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

        public void ChangeUsername(User user, string newUsername) 
        {
            if (newUsername != "")
            {
                user.Username = newUsername;
            }
        }

        public User[] GetUsers() { return this.myUsers.ToArray(); }

    }
}
