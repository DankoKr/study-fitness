using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Website.Models;

namespace Website.Pages.MyPages
{
    public class CreateCommentModel : PageModel
    {
        [BindProperty]
        public Comment? comment { get; set; }
        ICommentDAL db = new CommentDAL();
        CommentAdministration myManager;
        public string exerciseName { get; set; }
        public int exerciseId { get; set; }

        public String? Message { get; set; }

        public void OnGet(string name)
        {
            int id = 0;
            exerciseName = name;
            myManager = new CommentAdministration(db);
            exerciseId = myManager.GetExerciseId(name, id);
            TempData["ExerciseId"] = exerciseId;
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                myManager = new CommentAdministration(db);
                if (comment != null)
                {
                    Message = "Thank you for your feedback!";
                    exerciseId = (int)TempData["ExerciseId"];
                    myManager.AddComment(comment, 1, exerciseId);
                }
            }
            return Page();
        }
    }
}
