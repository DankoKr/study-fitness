using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Website.Pages.MyPages
{
    public class CardioDetailsModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        public CardioAdministration myManager;
        public Cardio? selectedC { get; set; }
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows;
        public void OnGet(string name)
        {
			ICardioDAL db = new CardioDAL();
			myManager = new CardioAdministration(db);
            db.LoadCardios(myManager, currentPage, pageSize, hasRows);
			selectedC = myManager.GetCardio(name);
        }
    }
}
