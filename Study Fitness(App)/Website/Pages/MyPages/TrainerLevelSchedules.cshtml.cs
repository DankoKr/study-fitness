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
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows;

        public void OnGet()
        {
            myManager = new ScheduleAdministration(db);
            string num = Request.Query["level"];
            int level = Convert.ToInt32(num);
            db.LoadSchedulesTrainerLevel(level ,myManager, currentPage, pageSize, hasRows);
        }

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid)
            {
                myManager = new ScheduleAdministration(db);
                string num = Request.Query["level"];
                int level = Convert.ToInt32(num);
                db.LoadSchedulesTrainerLevel(level,myManager, currentPage, pageSize, hasRows);   
                ClientName = HttpContext.Session.GetString("Username");
                string scheduleTitle = Request.Form["scheduleTitle"];
                int counter = myManager.GetTotalUserBookings(ClientName);

                if (scheduleTitle != "" && counter < 3)
                {
                    Schedule s = myManager.GetSchedule(scheduleTitle);
                    bool dublicatedTime = myManager.IsDumblicatedScheduleTime(s.Date, ClientName);
                    if (!dublicatedTime)
                    {
                        schedule = myManager.GetSchedule(scheduleTitle);
                        myManager.AssignSchedule(schedule, ClientName, scheduleTitle);
                    }
                    else
                    {
                        Message = "You cannot sign for two different schedules that are at the same time!";
                    }
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
