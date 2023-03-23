using ClassLibrary;
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
        public void OnGet(int id)
        {
            //myManager = new ExerciseAdministration();
            //DBconfig db = new DBconfig();
            //db.LoadExercises(myManager);
            ////dummyData = dataManager.GetDummyId(id);
        }

    }
}
