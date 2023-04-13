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
        public string FirstName { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string UserRole { get; set; }

        public User()
        {

        }

        public User(string firstName, string username, string password, string userRole)
        {
            FirstName = firstName;
            Username = username; 
            UserRole = userRole; 
            var passwordHashData = PasswordEncryptor.HashPassword(password); 
            PasswordHash = passwordHashData[0]; 
            PasswordSalt = passwordHashData[1];
        }

        public bool VerifyPassword(string password) 
        { 
            return PasswordEncryptor.VerifyPassword(password, PasswordHash, PasswordSalt); 
        }

        public string GetInfo() 
        {
            return $"User is also known as {FirstName}";
        }

    }
}
