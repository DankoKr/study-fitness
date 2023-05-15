using ClassLibrary.DatabaseClasses;
using ClassLibrary.UserClasses;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Website.Pages.MyPages
{
    public class LoginModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
		IUserDAL db = new UserDAL();
		UserAdministration myManager;
        public string Username { get; set; }
        public string Password { get; set; }
        public User user = new User();

        [BindProperty]
        public bool KeepMeLoggedIn { get; set; }

        public IActionResult OnGet()
        {
            myManager = new UserAdministration(db);

            // check if user is already logged in
            if (HttpContext.Session.GetString("Username") != null)
            {
                string name = HttpContext.Session.GetString("Username");
                db.GetUserByUsername(myManager, name);
                user = myManager.GetUser(name);

                if (user.UserRole == "Admin")
                    return RedirectToPage("/MyPages/AdminPage");
                else
                    return RedirectToPage("/MyPages/PersonalPage");
            }
            else
            {
                // check if a cookie exists and create a session
                if (Request.Cookies.TryGetValue("Username", out string username))
                {
                    HttpContext.Session.SetString("Username", username);
                    db.GetUserByUsername(myManager, username);
                    user = myManager.GetUser(username);

                    if (user.UserRole == "Admin")
                        return RedirectToPage("/MyPages/AdminPage");
                    else
                        return RedirectToPage("/MyPages/PersonalPage");
                }
            }
            return Page();
        }



        public IActionResult OnPost()
		{
			myManager = new UserAdministration(db);

			Username = Request.Form["Username"];
			Password = Request.Form["Password"];

			if (db.CheckLogin(Username, Password))
			{
				db.GetUserByUsername(myManager, Username);
				user = myManager.GetUser(Username);

				List<Claim> claims = new List<Claim>();
				claims.Add(new Claim(ClaimTypes.Name, Username));

				// store the username in the session
				HttpContext.Session.SetString("Username", user.Username);

				// add claim identity to cookie
				if (KeepMeLoggedIn)
				{
					claims.Add(new Claim(ClaimTypes.AuthorizationDecision, "KeepMeLoggedIn"));
					CookieOptions cOptions = new CookieOptions();
					cOptions.Expires = DateTime.Now.AddMinutes(1); // expires after n minutes
					Response.Cookies.Append("Username", user.Username, cOptions);
				}

				if (user.UserRole == "Admin")
				{
					claims.Add(new Claim(ClaimTypes.AuthorizationDecision, "Admin"));
				}

				var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
				HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

				if (user.UserRole == "Admin")
				{
					return new RedirectToPageResult("/MyPages/AdminPage");
				}
				return new RedirectToPageResult("/MyPages/PersonalPage");
			}

			ViewData["LoginMessage"] = "Invalid credentials!";
			return Page();
		}

	}
}
