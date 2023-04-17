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
    public class LoginModel : PageModel
    {
        UserDAL db = new UserDAL();
        UserAdministration myManager = new UserAdministration();
        public string Username { get; set; }
        public string Password { get; set; }
        public User user = new User();

        [BindProperty]
        public bool KeepMeLoggedIn { get; set; }

        public void OnGet()
        {
            // check if user is already logged in
            if (HttpContext.Session.GetString("Username") != null)
            {
                string name;
                name = HttpContext.Session.GetString("Username");
                db.GetUserByUsername(myManager, name);
                user = myManager.GetUser(name);

                if (user.UserRole == "Admin")
                    Response.Redirect("/MyPages/AdminPage");
                else
                    Response.Redirect("/MyPages/PersonalPage");
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

                    if (user.UserRole == "Admin")
                        Response.Redirect("/MyPages/AdminPage");
                    else
                        Response.Redirect("/MyPages/PersonalPage");
                }
            }
        }


        public IActionResult OnPost()
        {
            Username = Request.Form["Username"];
            Password = Request.Form["Password"];

            if (db.CheckLogin(Username, Password))
            {
                db.GetUserByUsername(myManager, Username);
                user = myManager.GetUser(Username);

                // store the username in the session
                HttpContext.Session.SetString("Username", user.Username);

                // Create a cookie
                if (KeepMeLoggedIn)
                {
                    CookieOptions cOptions = new CookieOptions();
                    cOptions.Expires = DateTime.Now.AddMinutes(1); // expires after n minutes
                    Response.Cookies.Append("Username", user.Username, cOptions);
                }


                if (user.UserRole == "Admin")
                    return new RedirectToPageResult("/MyPages/AdminPage");

                return new RedirectToPageResult("/MyPages/PersonalPage");

            }

            ViewData["LoginMessage"] = "Invalid credentials!";
            return Page();
        }
    }
}
