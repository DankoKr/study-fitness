using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    public class CardioModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        public IEnumerable<Cardio> MyCardios { get; set; }
		ICardioDAL db = new CardioDAL();
        CardioAdministration myManager;
		

		public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string SearchTerm { get; set; } = "";
        public void OnGet(int? page, string sort, string search)
        {
			myManager = new CardioAdministration(db);
			db.LoadCardios(myManager);
			MyCardios = myManager.GetCardios();

            if (page != null)
            {
                CurrentPage = page.Value;
            }

            if (!string.IsNullOrEmpty(search))
            {
                MyCardios = SearchExercises(search);
            }
        }

        private IEnumerable<Cardio> SearchExercises(string search)
        {
            return MyCardios.Where(e => e.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
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
