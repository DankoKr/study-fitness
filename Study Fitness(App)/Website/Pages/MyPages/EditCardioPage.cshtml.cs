using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    [Authorize(Policy = "AdminOnly")]
	public class EditCardioPageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        public string Error = "";
        public string Message = "";
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows;
        public Cardio? selectedC { get; set; }
        CardioAdministration myManager;
		ICardioDAL db = new CardioDAL();

        public string? NewDifficulty { get; set; }
        public int NewCalories{ get; set; }
        public string? NewPictureURL { get; set; }
        public string? SelectedName { get; set; }
        public void OnGet()
        {
            string nameEx = Request.Query["name"];
			myManager = new CardioAdministration(db);
			db.LoadCardios(myManager, currentPage, pageSize, hasRows);
			selectedC = myManager.GetCardio(nameEx);
        }

        public void OnPost()
        {
            SelectedName = Request.Query["name"];
            NewDifficulty = Request.Form["difficulty"];
            NewCalories = Convert.ToInt32(Request.Form["calories"]);
            NewPictureURL = Request.Form["picture"];

			myManager = new CardioAdministration(db);
			db.LoadCardios(myManager, currentPage, pageSize, hasRows);
			selectedC = myManager.GetCardio(SelectedName);


            if (NewCalories == 0 ||  NewPictureURL == "")
            {
                Error = "Missing or wrong data!";
                return;
            }

            myManager.EditCardioData(selectedC, NewCalories, NewDifficulty, NewPictureURL);

            Response.Redirect("/MyPages/CardioTable");
        }
    }
}
