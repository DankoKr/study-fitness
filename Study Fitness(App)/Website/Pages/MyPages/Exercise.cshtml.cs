using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Website.Pages.MyPages
{
    public class ExerciseModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {        
        public IEnumerable<Exercise> MyExercises { get; set; }
        ExerciseAdministration myManager;
        IExerciseDAL exData = new ExerciseDAL();
        
        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string SearchTerm { get; set; } = "";

        public void OnGet(int? page, string sort, string search)
        {
            myManager = new ExerciseAdministration(exData);

            exData.LoadExercises(myManager);
            MyExercises = myManager.GetExercises();

            if (page != null)
            {
                CurrentPage = page.Value;
            }

            if (!string.IsNullOrEmpty(sort))
            {
                MyExercises = SortExercises(sort);
            }

            if (!string.IsNullOrEmpty(search))
            {
                MyExercises = SearchExercises(search);
            }
        }

        private IEnumerable<Exercise> SortExercises(string sort)
        {
            var sortedExercises = MyExercises.ToList();

            switch (sort.ToLower())
            {
                case "weight":
                    myManager.SortExercises(sortedExercises);
                    break;
                case "name":
                    myManager.SortExercisesByName(sortedExercises);
                    break;
                case "reps":
                    myManager.SortExercisesByReps(sortedExercises);
                    break;
                default:
                    break;
            }

            return sortedExercises;
        }

        private IEnumerable<Exercise> SearchExercises(string search)
        {
            return MyExercises.Where(e => e.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
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
