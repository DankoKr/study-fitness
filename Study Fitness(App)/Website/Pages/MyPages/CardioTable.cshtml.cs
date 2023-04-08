using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    public class CardioTableModel : PageModel
    {
		public Cardio[] myCardios { get; set; }
		CardioAdministration myManager = new CardioAdministration();
		CardioDAL exData = new CardioDAL();
		public void OnGet()
        {
			exData.LoadCardios(myManager);
			myCardios = myManager.GetCardios();
		}
    }
}
