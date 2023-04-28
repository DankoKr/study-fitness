using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    [Authorize]
    public class CreateCommentCardioModel : PageModel
    {
        [BindProperty]
        public Comment? comment { get; set; }
        ICommentDAL db = new CommentDAL();
        CommentAdministration myManager;
        public string cardioName { get; set; }
        public int cardioId { get; set; }
        public int userId { get; set; }

        public String? Message { get; set; }

        public void OnGet(string name)
        {
            int id = 0;
            cardioName = name;
            myManager = new CommentAdministration(db);
            cardioId = myManager.GetCardioId(name, id);
            TempData["CardioId"] = cardioId;

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
                if (comment != null)
                {
                    Message = "Thank you for your feedback!";
                    cardioId = (int)TempData["CardioId"];
                    userId = (int)TempData["UserId"];
                    myManager.AddCommentCardio(comment, userId, cardioId);
                }
            }
            return Page();
        }
    }
}
