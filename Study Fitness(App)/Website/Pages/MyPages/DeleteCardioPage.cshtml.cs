using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    public class DeleteCardioPageModel : PageModel
    {
		public Cardio? selectedC { get; set; }
		CardioAdministration myManager;
		public void OnGet()
        {
			string nameEx = Request.Query["name"];
			ICardioDAL db = new CardioDAL();
			myManager = new CardioAdministration(db);
			db.LoadCardios(myManager);
			myManager.RemoveCardio(nameEx);

			Response.Redirect("/MyPages/CardioTable");
		}
    }
}
