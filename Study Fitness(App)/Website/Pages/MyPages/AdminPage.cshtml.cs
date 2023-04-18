using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using ClassLibrary.UserClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    //[Authorize(Policy = "OnlyAdminAccess")]

    public class AdminPageModel : PageModel
    {
        UserDAL db = new UserDAL();
        UserAdministration myManager = new UserAdministration();
        public User user = new User();

        public void OnGet()
        {
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

        public IActionResult OnPost()
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

            return new RedirectToPageResult("/MyPages/Login");
        }

    }


}
