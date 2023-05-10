using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ScheduleClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    [Authorize]
    public class ManageMyBookingsModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        public ScheduleAdministration myManager;
        IScheduleDAL db = new ScheduleDAL();
        public Schedule? schedule { get; set; }
        public void OnGet()
        {
            if (HttpContext.Session.GetString("Username") != null)
            {
                string nameUser = HttpContext.Session.GetString("Username");
                myManager = new ScheduleAdministration(db);
                db.LoadUserBookings(myManager, nameUser);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                string nameUser = HttpContext.Session.GetString("Username");
                myManager = new ScheduleAdministration(db);
                db.LoadUserBookings(myManager, nameUser);
                string scheduleTitle = Request.Form["scheduleTitle"];

                if (scheduleTitle != "")
                {
                    schedule = myManager.GetSchedule(scheduleTitle);
                    myManager.UnAssignSchedule(schedule);
                }
            }
            return RedirectToPage("/MyPages/PersonalPage");
        }
    }
}
