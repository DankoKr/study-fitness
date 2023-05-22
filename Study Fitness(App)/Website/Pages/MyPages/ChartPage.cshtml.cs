using ClassLibrary.DatabaseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    public class ChartPageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        public Dictionary<string, int> CommentCounts { get; private set; }
        private readonly ICommentDAL db = new CommentDAL();
        public void OnGet()
        {
            CommentCounts = new Dictionary<string, int>();

            for (int i = 1; i <= 5; i++)
            {
                CommentCounts[$"Rating {i}"] = db.GetCommentsByRating(i);
            }
        }
    }
}
