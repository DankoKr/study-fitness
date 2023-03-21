using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    public class AdminPageModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            HttpContext.Session.Remove("UserName");
            if (Request.Cookies.ContainsKey("UserName"))
            {
                // remove the cookie upon logout
                Response.Cookies.Append("UserName", "");
            }

            return new RedirectToPageResult("Login");

        }
    }
}
