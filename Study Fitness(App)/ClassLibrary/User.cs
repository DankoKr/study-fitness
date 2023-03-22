using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Fitness_App_
{
    public class User
    {

        private string firstName;
        private string username;
        private string password;

        [Required(ErrorMessage = "Please supply a name")]
        [MinLength(5, ErrorMessage = "Please supply a name with at least 5 characters")]
        [StringLength(10, ErrorMessage = "Name can have at most 10 characters")]
        public string FirstName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public User(string name, string username, string password)
        {
            this.FirstName = name;
            this.Username = username;
            this.Password = password;
        }

    }
}
