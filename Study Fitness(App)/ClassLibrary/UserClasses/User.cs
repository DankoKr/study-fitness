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

        public string FirstName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }

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
