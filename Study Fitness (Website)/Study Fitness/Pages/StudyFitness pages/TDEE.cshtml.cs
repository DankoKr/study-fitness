using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Study_Fitness.Models;

namespace Study_Fitness.Pages
{
    public class TDEEModel : PageModel
    {
        [BindProperty]
        public TDEECalculator? calculator { get; set; }

        public String? Message { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (calculator != null)
                {
                    calculator.Calculate();
                    Message = "You are a " + calculator.Sex + " (age: " + calculator.Age + ")" + " with TDEE: " + calculator.myTDEE;
                }
            }
            return Page();

        }

    }
}
