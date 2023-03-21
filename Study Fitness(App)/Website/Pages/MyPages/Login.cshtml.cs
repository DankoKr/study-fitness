using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public bool KeepMeLoggedIn { get; set; }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("UserName") == "user" && ("Password") == "1234")
                return new RedirectToPageResult("MemberPage"); 
            if (HttpContext.Session.GetString("UserName") == "admin" && ("Password") == "1234")
                return new RedirectToPageResult("AdminPage");

            if (Request.Cookies.ContainsKey("UserName") && Request.Cookies.ContainsKey("Password"))
            {
                UserName = Request.Cookies["UserName"];
                Password = Request.Cookies["Password"];
                // Create the session key again
                HttpContext.Session.SetString("UserName", UserName);
                HttpContext.Session.SetString("Password", Password);

                if (UserName == "user")
                    return new RedirectToPageResult("MemberPage");
                if (UserName == "admin")
                    return new RedirectToPageResult("AdminPage");
            }

            return Page();
        }

        public IActionResult OnPost()
        {

            // Set the session key value
            if (UserName != null)
            {
                HttpContext.Session.SetString("UserName", UserName);
                HttpContext.Session.SetString("Password", Password);
                // Create a cookie
                if (KeepMeLoggedIn)
                {
                    CookieOptions cOptions = new CookieOptions();
                    cOptions.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Append("UserName", UserName, cOptions);
                    Response.Cookies.Append("Password", Password, cOptions);
                }

            }
            if (UserName == "user" && Password == "1234")
                return new RedirectToPageResult("MemberPage");
            if (UserName == "admin" && Password == "1234")
                return new RedirectToPageResult("AdminPage");
            // if not user or admin, show error message
            ViewData["LoginMessage"] = "Invalid credentials, try again";
            return Page();
        }
    }
}
