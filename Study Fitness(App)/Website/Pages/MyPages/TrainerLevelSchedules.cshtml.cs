using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ScheduleClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Website.Pages.MyPages
{
    [Authorize]
    public class TrainerLevelSchedulesModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        IScheduleDAL db = new ScheduleDAL();
        public ScheduleAdministration myManager;
        public Schedule? schedule { get; set; }
        public string? ClientName { get; set; }
        public string? ScheduleTitle { get; set; }
        public String? Message { get; set; }

        public void OnGet()
        {
            myManager = new ScheduleAdministration(db);
            string num = Request.Query["level"];
            int level = Convert.ToInt32(num);
            db.LoadSchedulesTrainerLevel(level ,myManager);
        }

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid)
            {
                myManager = new ScheduleAdministration(db);
                string num = Request.Query["level"];
                int level = Convert.ToInt32(num);
                db.LoadSchedulesTrainerLevel(level, myManager);   
                ClientName = HttpContext.Session.GetString("Username");
                string scheduleTitle = Request.Form["scheduleTitle"];
                int counter = db.GetTotalUserBookings(ClientName);


                if (scheduleTitle != "" && counter < 3)
                {
                    schedule = myManager.GetSchedule(scheduleTitle);
                    myManager.AssignSchedule(schedule, ClientName, scheduleTitle);
                }
                else 
                {
                    Message = "You have reached the maximum Bookings per member!";
                }
            }
            return Page();
        }
    }
}
