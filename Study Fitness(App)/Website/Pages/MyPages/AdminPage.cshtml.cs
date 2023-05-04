using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using ClassLibrary.UserClasses;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
	[Authorize(Policy = "AdminOnly")]
	public class AdminPageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        UserAdministration myManager;
        public User user = new User();

        public void OnGet()
        {
			IUserDAL db = new UserDAL();
			myManager = new UserAdministration(db);

            // check if user is already logged in
            if (HttpContext.Session.GetString("Username") != null)
            {
                string name;
                name = HttpContext.Session.GetString("Username");
                db.GetUserByUsername(myManager, name);
                user = myManager.GetUser(name);
            }
            else
            {
                // check if a cookie exists and create a session
                if (Request.Cookies.ContainsKey("Username"))
                {
                    string username = Request.Cookies["Username"];
                    HttpContext.Session.SetString("Username", username);
                    db.GetUserByUsername(myManager, username);
                    user = myManager.GetUser(username);
                }
            }
        }

		public async Task<IActionResult> OnPost()
		{
            // clear the session upon logout
            HttpContext.Session.Remove("Username");

            // check if a cookie exists and clear it
            if (Request.Cookies.ContainsKey("Username"))
            {
                CookieOptions cOptions = new CookieOptions();
                cOptions.Expires = DateTime.Now.AddDays(-1); // set cookie expiration date to yesterday
                Response.Cookies.Append("Username", "", cOptions);
            }

			await HttpContext.SignOutAsync();

			return new RedirectToPageResult("/MyPages/Login");
        }

    }


}
