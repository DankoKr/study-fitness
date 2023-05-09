using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    public class TrainersModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        public int LevelZero = 0;
        public int LevelOne = 1;
        public int LevelTwo = 2;

        public void OnGet()
        {
        }
    }
}
