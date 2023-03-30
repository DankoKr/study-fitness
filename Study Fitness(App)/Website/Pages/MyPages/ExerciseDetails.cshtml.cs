using ClassLibrary;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Website.Models;

namespace Website.Pages.MyPages
{
    public class ExerciseDetailscshtmlModel : PageModel
    {
        public ExerciseAdministration myManager = new ExerciseAdministration();
        public Exercise? selectedEx { get; set; }

        public void OnGet(string name)
        {
            myManager = new ExerciseAdministration();
            ExerciseDAL db = new ExerciseDAL();
            db.LoadExercises(myManager);
            selectedEx = myManager.GetExercise(name);
        }

    }
}
