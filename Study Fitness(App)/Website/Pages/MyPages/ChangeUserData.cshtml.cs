using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using ClassLibrary.UserClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
	[Authorize]
	public class ChangeUserDataModel : PageModel
    {
		public string Error = "";
		public string Message = "";
		public User? user { get; set; }
		UserAdministration myManager = new UserAdministration();
		UserDAL db = new UserDAL();
		public string? NewUsername { get; set; }
        public string? NewFirstName { get; set; }

        public void OnGet()
        {
            string nameUser = Request.Query["name"];
            db.GetUserByUsername(myManager, nameUser);
            user = myManager.GetUser(nameUser);
        }

		public void OnPost()
		{
			string currentUsername = Request.Query["name"];
			NewUsername = Request.Form["username"];
            NewFirstName = Request.Form["firstname"];

            db.GetUserByUsername(myManager, currentUsername);
            user = myManager.GetUser(currentUsername);


            if (NewUsername == "")
			{
				Error = "Missing or wrong data!";
				return;
			}

			myManager.ChangeUsername(user, NewUsername);
            myManager.ChangeFirstName(user, NewFirstName);

            // clear the old session 
            HttpContext.Session.Remove("Username");

            // store the new username in the session
            HttpContext.Session.SetString("Username", user.Username);

            // check if a cookie exists and clear it
            if (Request.Cookies.ContainsKey("Username"))
            {
                CookieOptions cOptions = new CookieOptions();
                cOptions.Expires = DateTime.Now.AddDays(-1); // set cookie expiration date to yesterday
                Response.Cookies.Append("Username", "", cOptions);

                //create new cookie with new username
                CookieOptions cOptions2 = new CookieOptions();
                cOptions2.Expires = DateTime.Now.AddMinutes(1); // expires after n minutes
                Response.Cookies.Append("Username", user.Username, cOptions2);
            }

            Response.Redirect("/MyPages/PersonalPage");
		}
	}
}
