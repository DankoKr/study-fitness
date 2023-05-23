using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
	[Authorize(Policy = "AdminOnly")]
	public class ExerciseTableModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
		public Exercise[] myExercises { get; set; }
		ExerciseAdministration myManager;
		IExerciseDAL exData = new ExerciseDAL();
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows;
        public void OnGet()
        {
			myManager = new ExerciseAdministration(exData);
			exData.LoadExercises(myManager, currentPage, pageSize, hasRows);
			myExercises = myManager.GetExercises();
		}
    }
}
