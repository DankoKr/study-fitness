using ClassLibrary.UserClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Website.Models;

namespace Website.Pages.MyPages
{
    public class CreateAccountModel : PageModel
    {
        [BindProperty]
        public User? user { get; set; }

        [BindProperty]
        public bool AgreedTerms { get; set; }
        public void OnGet()
        {
        }
    }
}
