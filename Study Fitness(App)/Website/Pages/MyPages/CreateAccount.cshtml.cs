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
    public class CreateAccountModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        UserAdministration myManager;
		IUserDAL db = new UserDAL();
        private int currentPage = 1;
        private const int pageSize = 20;
        private bool hasRows;

        public string Error = "";
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Type = "Member";

        public void OnGet()
        {
        }

        public void OnPost()
        {
			myManager = new UserAdministration(db);
            db.LoadUsers(myManager, currentPage, pageSize, hasRows);

			Username = Request.Form["username"];
            Password = Request.Form["password"];
            FirstName = Request.Form["firstname"];

            if (Username.Length == 0 || Password.Length == 0)
            { Error = "Missing data!"; return; }

            if (!myManager.ValidateUserIsUnique(Username))
            {
                Error = "Username has already been used. Please choose a new one!"; return;
            }

            myManager.AddUser(new User(FirstName, Username, Password, Type));
               

            Response.Redirect("/MyPages/Login");
            
        }
    }
}
