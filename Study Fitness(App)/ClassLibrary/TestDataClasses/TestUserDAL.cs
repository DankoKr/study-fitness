using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary.TestDataClasses
{
    public class TestUserDAL : IUserDAL
    {
        List<User> myUsers = new List<User>();
        public bool CheckLogin(string username, string password)
        {
            bool isLogged = false;
            foreach (User u in myUsers)
            {
                if (u.Username == username && u.Password == password)
                { return isLogged = true; }
            }
            return isLogged;
        }

        public bool CreateUser(User u)
        {
            myUsers.Add(u);
            return true;
        }

        public void DeleteUser(User u)
        {
            myUsers.Remove(u);
        }

        public void EditUser(User u, string username)
        {
            u.Username = username;
        }

        public void EditUserFirstName(User u, string newFirstName)
        {
            u.FirstName = newFirstName;
        }

        public string GetSalt(string username)
        {
            string salt = "";
            foreach (User u in myUsers)
            {
                if (u.Username == username)
                { return salt = "fdsjhf"; }
            }
            return salt;
        }

        public void GetTrainerNameByPoints(int points, List<string> trainers)
        {//Cannot implement because this method requires real database
            throw new NotImplementedException();
        }

        public void GetUserByUsername(UserAdministration myManager, string username)
        {
            foreach (var user in myUsers)
            {
                if (user.Username == username)
                {
                    myManager.AddExistingUser(user);
                }
            }
        }

        public bool IsUnique(string name)
        {
            bool isUnique = true;
            foreach (User u in myUsers)
            {
                if (u.Username == name) return isUnique = false;
            }
            return isUnique;
        }

        public void LoadUsers(UserAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows)
        {
            User u1 = new User("User1", "First", "1234", "Member");
            User u2 = new User("User2", "Second", "1234", "Admin");
            User u3 = new User("User3", "Third", "1234", "Member");
            myUsers.Add(u1);
            myUsers.Add(u2);
            myUsers.Add(u3);
            myManager.AddExistingUser(u1);
            myManager.AddExistingUser(u2);
            myManager.AddExistingUser(u3);
        }

        public void SetTrainerLevel(string trainerUsername, int level)
        {
            int trainerLevel = 0;
            foreach (User u in myUsers)
            {
                if (u.Username == trainerUsername)
                {
                    trainerLevel = level;
                }
            }
        }

        public int UserId(string username)
        {
            int id = 0;
            foreach (User u in myUsers)
            {
                id++;
                if (u.Username == username)
                {
                    return id;
                }
            }
            return id;
        }
    }
}
