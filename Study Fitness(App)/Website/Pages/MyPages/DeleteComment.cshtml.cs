using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Website.Pages.MyPages
{
    public class DeleteCommentModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        CommentAdministration myManager;
        ICommentDAL db = new CommentDAL();
        Comment c;
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows;
        public void OnGet()
        {
            if (HttpContext.Session.GetString("Username") != null)
            {
                int uId = 0;
                string nameUser = HttpContext.Session.GetString("Username");
                int userId = db.GetUserId(nameUser, uId);
                myManager = new CommentAdministration(db);
                db.GetUserComments(userId, myManager, currentPage, pageSize, hasRows);
                string commentTitle = Request.Query["name"];
                c = db.GetComment(commentTitle, c);
                myManager.RemoveComment(c);
            }

            Response.Redirect("/MyPages/MyComments");
        }
    }
}
