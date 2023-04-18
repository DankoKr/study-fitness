using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Website.Models;

namespace Website.Pages.MyPages
{
	[Authorize(Policy = "AdminOnly")]
	public class AddExercisePageModel : PageModel
    {
        ExerciseAdministration myManager = new ExerciseAdministration();
        ExerciseDAL db = new ExerciseDAL();

        public string Message = "";
        public string Error = "";
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public string Equipment { get; set; }
        public int RepRange { get; set; }
        public double Weight { get; set; }
        public string PictureUrl { get; set; }
        public string Type { get; set; }
        public string Specialty { get; set; }

        public void OnGet()
        {
        }

        public void OnPost() 
        {
            Name = Request.Form["name"];
            Difficulty = Request.Form["difficulty"];
            Equipment = Request.Form["equipment"];
            RepRange = Convert.ToInt32(Request.Form["repRange"]);
            Weight = Convert.ToDouble(Request.Form["weight"]);
            PictureUrl = Request.Form["pictureURL"];
            Type = Request.Form["type"];
            Specialty = Request.Form["specialty"];

            if (Name.Length == 0) { Error = "Missing data!"; return; }

            //Add to database
            myManager.CreateExercise(Type, Name, Difficulty, Equipment, RepRange, Weight, Specialty, PictureUrl);           
            //

            Message = "Exercise created!";
            //Response.Redirect("/MyPages/ExerciseTable");
        }
    }
}
