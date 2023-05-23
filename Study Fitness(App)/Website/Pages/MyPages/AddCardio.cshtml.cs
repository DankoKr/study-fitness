using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    [Authorize(Policy = "AdminOnly")]
	public class AddCardioModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        CardioAdministration myManager;
		ICardioDAL db = new CardioDAL();
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows;

        public string Message = "";
        public string Error = "";
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public int Calories { get; set; }
        public string PictureUrl { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Name = Request.Form["name"];
            Difficulty = Request.Form["difficulty"];
            Calories = Convert.ToInt32(Request.Form["calories"]);
            PictureUrl = Request.Form["pictureURL"];

            myManager = new CardioAdministration(db);
            db.LoadCardios(myManager, currentPage, pageSize, hasRows);

            if (Name.Length == 0)
            { Error = "Missing data!"; return; }
            else if (!myManager.IsPictureValid(PictureUrl))
            { Error = "Incorrect URL!"; return; }

			myManager.CreateCardio(Name, Calories, Difficulty, PictureUrl);
            

            Message = "Cardio created!";

        }
    }
}
