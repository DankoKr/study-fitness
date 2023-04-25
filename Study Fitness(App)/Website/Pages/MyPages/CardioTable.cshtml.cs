using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    [Authorize(Policy = "AdminOnly")]
	public class CardioTableModel : PageModel
    {
		public Cardio[] myCardios { get; set; }
		CardioAdministration myManager;

		public void OnGet()
        {
			ICardioDAL db = new CardioDAL();
			myManager = new CardioAdministration(db);
			db.LoadCardios(myManager);
			myCardios = myManager.GetCardios();
		}
    }
}
