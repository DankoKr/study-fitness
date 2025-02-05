using ClassLibrary.CardioClasses;
using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Website.Pages.MyPages
{
    [Authorize]
    public class EditCommentModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        public string Error = "";
        public string SelectedName { get; set; }
        public Comment? selectedC { get; set; }
        public int NewRating { get; set; }
        public string NewDescription { get; set; }
        CommentAdministration myManager;
        ICommentDAL db = new CommentDAL();
        public void OnGet()
        {
            string titleComment = Request.Query["name"];
            myManager = new CommentAdministration(db);
            selectedC = db.GetComment(titleComment, selectedC);
        }

        public void OnPost()
        {
            SelectedName = Request.Query["name"];
            myManager = new CommentAdministration(db);
            selectedC = db.GetComment(SelectedName, selectedC);

            NewRating = Convert.ToInt32(Request.Form["rating"]);
            NewDescription = Request.Form["description"];

            if (NewRating > 5 || NewDescription == "" || NewRating < 0)
            {
                Error = "Missing or wrong data!";
                return;
            }

            myManager.EditComment(selectedC, NewDescription, NewRating);

            Response.Redirect("/MyPages/MyComments");
        }
    }
}
