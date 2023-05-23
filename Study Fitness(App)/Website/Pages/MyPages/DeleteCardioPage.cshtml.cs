using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    public class DeleteCardioPageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
		public Cardio? selectedC { get; set; }
		CardioAdministration myManager;
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows;
        public void OnGet()
        {
			string nameEx = Request.Query["name"];
			ICardioDAL db = new CardioDAL();
			myManager = new CardioAdministration(db);
			db.LoadCardios(myManager, currentPage, pageSize, hasRows);
			myManager.RemoveCardio(nameEx);

			Response.Redirect("/MyPages/CardioTable");
		}
    }
}
