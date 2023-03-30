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

        [Required(ErrorMessage = "Please supply a name!")]
        [MinLength(5, ErrorMessage = "Please supply a name with at least 5 characters!")]
        public string FirstName { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Please supply a name with at least 8 characters!")]
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
