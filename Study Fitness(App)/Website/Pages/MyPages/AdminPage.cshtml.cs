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
        public void OnGet()
        {
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
