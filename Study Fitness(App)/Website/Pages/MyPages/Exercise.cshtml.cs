using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Website.Pages.MyPages
{
    public class ExerciseModel : PageModel
    {        
        public IEnumerable<Exercise> MyExercises { get; set; }
        ExerciseAdministration myManager;
        IExerciseDAL exData = new ExerciseDAL();
        
        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 10;

        public void OnGet(int? page)
        {
            myManager = new ExerciseAdministration(exData);

			exData.LoadExercises(myManager);
            MyExercises = myManager.GetExercises();

            if (page != null)
            {
                CurrentPage = page.Value;
            }
        }

        public IEnumerable<Exercise> PaginatedExercises
        {
            get
            {
                return MyExercises.Skip((CurrentPage - 1) * PageSize).Take(PageSize);
            }
        }

        public int TotalPages
        {
            get
            {
                return (int)System.Math.Ceiling((decimal)MyExercises.Count() / PageSize);
            }
        }
    }
}
