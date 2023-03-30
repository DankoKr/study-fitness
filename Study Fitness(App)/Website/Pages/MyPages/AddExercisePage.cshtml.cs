using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Website.Models;

namespace Website.Pages.MyPages
{
    public class AddExercisePageModel : PageModel
    {
        ExerciseAdministration myManager = new ExerciseAdministration();
        ExerciseDAL exData = new ExerciseDAL();

        public string? Message { get; set; }
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

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                //if (TestEx != null)
                //{
                //    myManager.CreateExercise(TestEx.Type, TestEx.Name, TestEx.Difficulty, TestEx.Equipment, TestEx.RepRange, TestEx.Weight, TestEx.Specialty, TestEx.PictureUrl);
                //    exData.AddExercise(myManager.GetExercise(TestEx.Name));
                //    Message = "You just created an exercise!";
                //}
            }

            return Page();

        }
    }
}
