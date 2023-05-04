using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    public class DeleteExerciseModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
		public Exercise? selectedEx { get; set; }
		ExerciseAdministration myManager;
		IExerciseDAL db = new ExerciseDAL();

		public void OnGet()
        {
			string nameEx = Request.Query["name"];
			myManager = new ExerciseAdministration(db);
			db.LoadExercises(myManager);
			myManager.RemoveExercise(nameEx);

			Response.Redirect("/MyPages/ExerciseTable");
		}
    }
}
