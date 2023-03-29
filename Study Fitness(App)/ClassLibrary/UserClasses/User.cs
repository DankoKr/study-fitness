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
        private string type;


        public string FirstName { get; set; }

        [Required]
        //[Display(Name = "username")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public User()
        {

        }

        public User(string name, string username, string password, string type)
        {
            this.firstName = name;
            this.username = username;
            this.password = password;
            this.type = type;
        }

    }
}
