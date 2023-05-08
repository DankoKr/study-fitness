using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary.UserClasses
{
    public class User 
    {
        private string firstName;
        private string username;
        private string password;
        private string userRole;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string UserRole
        {
            get { return userRole; }
            set { userRole = value; }
        }

        public User()
        {

        }

        public User(string firstName, string username, string password, string userRole)
        {
            FirstName = firstName;
            Username = username; 
            UserRole = userRole; 
            Password = password;
        }

        public string GetInfo() 
        {
            return $"User is also known as {FirstName}";
        }

    }
}
