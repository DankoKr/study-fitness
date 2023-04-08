using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Website.Pages.MyPages
{
    public class CardioDetailsModel : PageModel
    {
        public CardioAdministration myManager = new CardioAdministration();
        public Cardio? selectedC { get; set; }
        public void OnGet(string name)
        {
            myManager = new CardioAdministration();
            CardioDAL db = new CardioDAL();
            db.LoadCardios(myManager);
            selectedC = myManager.GetCardio(name);
        }
    }
}
