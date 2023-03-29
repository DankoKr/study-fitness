using ClassLibrary.UserClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    [Authorize]
    public class PersonalPageModel : PageModel
    {
        public void OnGet()
        {
        }

		public IActionResult OnPost()
		{
			HttpContext.Session.Remove("Username");
			if (Request.Cookies.ContainsKey("Username"))
			{
				// remove the cookie upon logout
				Response.Cookies.Append("Username", "");
			}

			return new RedirectToPageResult("/MyPages/Login");

		}
	}
}
