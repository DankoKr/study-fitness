using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ScheduleClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    public class TrainerLevelSchedulesModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        IScheduleDAL db = new ScheduleDAL();
        public ScheduleAdministration myManager;
        public void OnGet()
        {
            myManager = new ScheduleAdministration(db);
            string num = Request.Query["level"];
            int level = Convert.ToInt32(num);
            db.LoadSchedulesTrainerLevel(level ,myManager);
        }
    }
}
