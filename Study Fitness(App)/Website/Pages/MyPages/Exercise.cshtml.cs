using ClassLibrary;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Data.SqlClient;
using Website.Models;

namespace Website.Pages.MyPages
{
    public class ExerciseModel : PageModel
    {
        public Exercise[]? MyExercises { get; set; }
        ExerciseAdministration myManager = new ExerciseAdministration();
        DBconfig database = new DBconfig();
        public void OnGet()
        {            
            database.LoadExercises(myManager);
            MyExercises = myManager.GetExercises();
        }

    }
}
