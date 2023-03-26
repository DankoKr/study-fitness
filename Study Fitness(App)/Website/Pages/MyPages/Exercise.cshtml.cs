using ClassLibrary.DatabaseClasses;
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
        StorageManager myData = new StorageManager();
        public void OnGet()
        {            
            myData.LoadExercises(myManager);
            MyExercises = myManager.GetExercises();
        }

    }
}
