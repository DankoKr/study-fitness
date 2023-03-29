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
    public class LoginV2Model : PageModel
    {
        [BindProperty]
        public User user { get; set; }

        [BindProperty]
        public bool KeepMeLoggedIn { get; set; }

        public IActionResult OnGet()
        {
            string username = HttpContext.Session.GetString("Username");

            // Check for an existing cookie
            if (string.IsNullOrEmpty(username) && Request.Cookies.ContainsKey("Username"))
            {
                username = Request.Cookies["Username"];
                HttpContext.Session.SetString("Username", username);
            }

            // Redirect to the corresponding page
            if (username == "user")
                return new RedirectToPageResult("PersonalPage");
            if (username == "admin")
                return new RedirectToPageResult("AdminPage");

            return Page();
        }

        public IActionResult OnPost()
        {
            if (user.Username == "user" && user.Password == "1234" || user.Username == "admin")
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, user.Username));
                claims.Add(new Claim("id", "1"));
                HttpContext.Session.SetString("Username", user.Username);

                // Create a cookie
                if (KeepMeLoggedIn)
                {
                    CookieOptions cOptions = new CookieOptions();
                    cOptions.Expires = DateTime.Now.AddMinutes(5); // expires after 5 minutes
                    Response.Cookies.Append("Username", user.Username, cOptions);
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
