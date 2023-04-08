using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    public class CardioModel : PageModel
    {
        public IEnumerable<Cardio> MyCardios { get; set; }
        CardioAdministration myManager = new CardioAdministration();
        CardioDAL exData = new CardioDAL();

        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public void OnGet(int? page)
        {
            exData.LoadCardios(myManager);
            MyCardios = myManager.GetCardios();

            if (page != null)
            {
                CurrentPage = page.Value;
            }
        }

        public IEnumerable<Cardio> PaginatedExercises
        {
            get
            {
                return MyCardios.Skip((CurrentPage - 1) * PageSize).Take(PageSize);
            }
        }

        public int TotalPages
        {
            get
            {
                return (int)System.Math.Ceiling((decimal)MyCardios.Count() / PageSize);
            }
        }
    }
}
