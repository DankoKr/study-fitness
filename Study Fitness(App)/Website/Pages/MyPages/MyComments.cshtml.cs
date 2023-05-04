using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using ClassLibrary.UserClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Website.Pages.MyPages
{
    [Authorize]
    public class MyCommentsModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        public CommentAdministration myComments;
        ICommentDAL comments = new CommentDAL();
        public void OnGet()
        {
            if (HttpContext.Session.GetString("Username") != null)
            {
                int uId = 0;
                string nameUser = HttpContext.Session.GetString("Username");
                int userId = comments.GetUserId(nameUser, uId);
                myComments = new CommentAdministration(comments);
                comments.GetUserComments(userId, myComments);
            }
        }
    }
}
