using ClassLibrary.UserClasses;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Website.Pages.MyPages
{
    public class LoginV2Model : PageModel
    {
        [BindProperty]
        public User user { get; set; }
		[BindProperty]
		public bool KeepMeLoggedIn { get; set; }

		public IActionResult OnGet() 
		{
            if (HttpContext.Session.GetString("user.Username") == "user")
                return new RedirectToPageResult("PersonalPage");
            if (HttpContext.Session.GetString("user.Username") == "admin")
                return new RedirectToPageResult("AdminPage");

            if (Request.Cookies.ContainsKey("user.Username"))
            {
                user.Username = Request.Cookies["user.Username"];
                // Create the session key again
                HttpContext.Session.SetString("user.Username", user.Username);
                if (user.Username == "user")
                    return new RedirectToPageResult("PersonalPage");
                if (user.Username == "admin")
                    return new RedirectToPageResult("AdminPage");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
			if (user.Username == "user" && user.Password == "1234" || user.Username == "admin")
			{
				// successful login
				List<Claim> claims = new List<Claim>();
				claims.Add(new Claim(ClaimTypes.Name, user.Username));
				claims.Add(new Claim("id", "1"));
				HttpContext.Session.SetString("UserName", user.Username);
				// Create a cookie
				if (KeepMeLoggedIn)
				{
					CookieOptions cOptions = new CookieOptions();
					cOptions.Expires = DateTime.Now.AddDays(1);
					Response.Cookies.Append("UserName", user.Username, cOptions);
				}

				if (user.Username == "admin" && user.Password == "1234")
				{
					claims.Add(new Claim(ClaimTypes.AuthorizationDecision, "admin"));
				}

				var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
				HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

				if (user.Username == "admin")
					return new RedirectToPageResult("AdminPage");

				return new RedirectToPageResult("PersonalPage");

			}
			ViewData["LoginMessage"] = "Invalid credentials!";
			return Page();

		}


    }
}
