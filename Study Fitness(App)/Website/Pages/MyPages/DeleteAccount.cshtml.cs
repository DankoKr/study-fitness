using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using ClassLibrary.UserClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    public class DeleteAccountModel : PageModel
    {
        public User? user { get; set; }
        UserAdministration myManager = new UserAdministration();
        UserDAL db = new UserDAL();

        public void OnGet()
        {
            string nameUser = Request.Query["name"];
            db.GetUserByUsername(myManager, nameUser);
            user = myManager.GetUser(nameUser);
            db.DeleteUser(user);

            // clear the session upon logout
            HttpContext.Session.Remove("Username");

            // check if a cookie exists and clear it
            if (Request.Cookies.ContainsKey("Username"))
            {
                CookieOptions cOptions = new CookieOptions();
                cOptions.Expires = DateTime.Now.AddDays(-1); // set cookie expiration date to yesterday
                Response.Cookies.Append("Username", "", cOptions);
            }

            Response.Redirect("/MyPages/Login");
        }

    }
}
