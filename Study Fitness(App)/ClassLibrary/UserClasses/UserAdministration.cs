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
        private readonly IUserDAL db;

        public UserAdministration(IUserDAL db) 
        {
			this.db = db;
		}

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
            db.DeleteUser(u);
        }

        public bool ValidateUserIsUnique(string username)
        {
            return db.isUnique(username);
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
                db.EditUser(user, newUsername);
                user.Username = newUsername;
            }
        }

        public void ChangeFirstName(User user, string newFirstName) 
        {
            if (newFirstName != "")
            {
                db.EditUserFirstName(user, newFirstName);
                user.FirstName = newFirstName;
            }
        }

        public User[] GetUsers() { return this.myUsers.ToArray(); }

    }
}
