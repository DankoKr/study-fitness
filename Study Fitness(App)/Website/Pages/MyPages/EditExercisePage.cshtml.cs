using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Website.Pages.MyPages
{
	[Authorize(Policy = "AdminOnly")]
	public class EditExercisePageModel : PageModel
    {
        public string Error = "";
        public string Message = "";
        public Exercise? selectedEx { get; set; }
        ExerciseAdministration myManager;
		IExerciseDAL db = new ExerciseDAL();
		public string? NewDifficulty { get; set; }
        public int NewRepRange { get; set; }
        public double NewWeight { get; set; }
        public string? SelectedName { get; set; }

        public void OnGet()
        {
            string nameEx = Request.Query["name"];
            myManager = new ExerciseAdministration(db);
            db.LoadExercises(myManager);
            selectedEx = myManager.GetExercise(nameEx);
        }

        public void OnPost()
        {
            SelectedName = Request.Query["name"];
            NewDifficulty = Request.Form["difficulty"];
            NewRepRange = Convert.ToInt32(Request.Form["repRange"]);
            NewWeight = Convert.ToDouble(Request.Form["weight"]);

			myManager = new ExerciseAdministration(db);
			db.LoadExercises(myManager);
			selectedEx = myManager.GetExercise(SelectedName);


			if (NewRepRange == 0 || NewDifficulty == "") 
            {
                Error = "Missing or wrong data!";
                return;
            }

            myManager.EditExerciseData(selectedEx, NewRepRange, NewWeight, NewDifficulty);

            Response.Redirect("/MyPages/ExerciseTable");
        }


    }
}
