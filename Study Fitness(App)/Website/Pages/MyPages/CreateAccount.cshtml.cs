using ClassLibrary;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using ClassLibrary.UserClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using Website.Models;

namespace Website.Pages.MyPages
{
    public class CreateAccountModel : PageModel
    {
        UserAdministration myManager = new UserAdministration();

        public string Error = "";
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Type = "member";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Username = Request.Form["username"];
            Password = Request.Form["password"];
            FirstName = Request.Form["firstname"];

            if (Username.Length == 0 || Password.Length == 0) { Error = "Missing data!"; return; }

            //Add to database
            myManager.AddUser(new User(FirstName, Username, Password, Type));
               

            Response.Redirect("/MyPages/Login");
            
        }
    }
}
