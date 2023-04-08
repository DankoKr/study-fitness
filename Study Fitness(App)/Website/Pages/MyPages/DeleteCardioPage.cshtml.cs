using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    public class DeleteCardioPageModel : PageModel
    {
		public Cardio? selectedC { get; set; }
		CardioAdministration myManager = new CardioAdministration();
		public void OnGet()
        {
			string nameEx = Request.Query["name"];
			myManager = new CardioAdministration();
			CardioDAL db = new CardioDAL();
			db.LoadCardios(myManager);
			myManager.RemoveExercise(nameEx);

			Response.Redirect("/MyPages/CardioTable");
		}
    }
}
