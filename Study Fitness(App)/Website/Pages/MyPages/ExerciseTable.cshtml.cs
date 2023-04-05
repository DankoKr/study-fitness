using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    public class ExerciseTableModel : PageModel
    {
		public Exercise[] myExercises { get; set; }
		ExerciseAdministration myManager = new ExerciseAdministration();
		ExerciseDAL exData = new ExerciseDAL();
		public void OnGet()
        {
			exData.LoadExercises(myManager);
			myExercises = myManager.GetExercises();
		}
    }
}
