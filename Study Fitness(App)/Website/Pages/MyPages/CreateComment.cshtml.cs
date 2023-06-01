using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.UserClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Website.Models;

namespace Website.Pages.MyPages
{
    [Authorize]
    public class CreateCommentModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        [BindProperty]
        public Comment? comment { get; set; }
        ICommentDAL db = new CommentDAL();
        CommentAdministration myManager;
        public string exerciseName { get; set; }
        public int exerciseId { get; set; }
        public int userId { get; set; }

        public String? Message { get; set; }

        public void OnGet(string name)
        {
            int id = 0;
            exerciseName = name;
            myManager = new CommentAdministration(db);
            exerciseId = myManager.GetExerciseId(name, id);
            TempData["ExerciseId"] = exerciseId;

            if (HttpContext.Session.GetString("Username") != null)
            {
                int uId = 0;
                string nameUser = HttpContext.Session.GetString("Username");
                userId = db.GetUserId(nameUser, uId);
                TempData["UserId"] = userId;
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                myManager = new CommentAdministration(db);
                if (comment != null && myManager.ValidateCommentIsUnique(comment.Title))
                {
                    Message = "Thank you for your feedback!";
                    exerciseId = (int)TempData["ExerciseId"];
                    userId = (int)TempData["UserId"];
                    myManager.AddCommentExercise(comment, userId, exerciseId);
                }
                else
                {
                    Message = "Dublication of title!";
                }
            }
            return Page();
        }
    }
}
