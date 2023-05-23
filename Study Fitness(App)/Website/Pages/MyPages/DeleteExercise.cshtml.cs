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
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows;

        public void OnGet()
        {
			string nameEx = Request.Query["name"];
			myManager = new ExerciseAdministration(db);
			db.LoadExercises(myManager, currentPage, pageSize, hasRows);
			myManager.RemoveExercise(nameEx);

			Response.Redirect("/MyPages/ExerciseTable");
		}
    }
}
