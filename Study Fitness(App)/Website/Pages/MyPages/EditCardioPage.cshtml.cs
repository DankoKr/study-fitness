using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    [Authorize(Policy = "AdminOnly")]
	public class EditCardioPageModel : PageModel
    {
        public string Error = "";
        public string Message = "";
        public Cardio? selectedC { get; set; }
        CardioAdministration myManager;
		ICardioDAL db = new CardioDAL();
		public string? NewDifficulty { get; set; }
        public string? NewName { get; set; }
        public int NewCalories{ get; set; }
        public string? NewPictureURL { get; set; }
        public string? SelectedName { get; set; }
        public void OnGet()
        {
            string nameEx = Request.Query["name"];
			myManager = new CardioAdministration(db);
			db.LoadCardios(myManager);
			selectedC = myManager.GetCardio(nameEx);
        }

        public void OnPost()
        {
            SelectedName = Request.Query["name"];
            NewDifficulty = Request.Form["difficulty"];
            NewCalories = Convert.ToInt32(Request.Form["calories"]);
            NewName = Request.Form["newname"];
            NewPictureURL = Request.Form["picture"];

			myManager = new CardioAdministration(db);
			db.LoadCardios(myManager);
			selectedC = myManager.GetCardio(SelectedName);


            if (NewCalories == 0 || NewName == "" || NewPictureURL == "")
            {
                Error = "Missing or wrong data!";
                return;
            }

            myManager.EditCardioData(selectedC, NewName, NewCalories, NewDifficulty, NewPictureURL);

            Response.Redirect("/MyPages/CardioTable");
        }
    }
}
