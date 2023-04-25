using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    [Authorize(Policy = "AdminOnly")]
	public class AddCardioModel : PageModel
    {
        CardioAdministration myManager;
		ICardioDAL db = new CardioDAL();

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


            if (Name.Length == 0) { Error = "Missing data!"; return; }

			//Add to database
			myManager = new CardioAdministration(db);
			db.LoadCardios(myManager);
			myManager.CreateCardio(Name, Calories, Difficulty, PictureUrl);
            //

            Message = "Cardio created!";
            //Response.Redirect("/MyPages/CardioTable");
        }
    }
}
