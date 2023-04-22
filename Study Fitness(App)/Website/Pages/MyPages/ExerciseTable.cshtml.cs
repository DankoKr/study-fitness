using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
	[Authorize(Policy = "AdminOnly")]
	public class ExerciseTableModel : PageModel
    {
		public Exercise[] myExercises { get; set; }
		ExerciseAdministration myManager;
		IExerciseDAL exData = new ExerciseDAL();
		public void OnGet()
        {
			myManager = new ExerciseAdministration(exData);
			exData.LoadExercises(myManager);
			myExercises = myManager.GetExercises();
		}
    }
}
