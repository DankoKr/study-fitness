using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    public class DeleteExerciseModel : PageModel
    {
		public Exercise? selectedEx { get; set; }
		ExerciseAdministration myManager = new ExerciseAdministration();

		public void OnGet()
        {
			string nameEx = Request.Query["name"];
			myManager = new ExerciseAdministration();
			ExerciseDAL db = new ExerciseDAL();
			db.LoadExercises(myManager);
			myManager.RemoveExercise(nameEx);

			Response.Redirect("/MyPages/ExerciseTable");
		}
    }
}
