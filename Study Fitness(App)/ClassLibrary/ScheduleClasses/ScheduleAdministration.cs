using ClassLibrary.DatabaseClasses;
using ClassLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ScheduleClasses
{
    public class ScheduleAdministration
    {
        List<Schedule> schedules = new List<Schedule>();
        IScheduleDAL db = new ScheduleDAL();
        public ScheduleAdministration() { }

        public void AddSchedule(Schedule s) 
        {
            if (s.TrainerId != 0 && s.Title != "")
            {
                schedules.Add(s);
                db.AddSchedule(s);
            }
        }

        public void AddExistingSchedule(Schedule s) 
        {
            schedules.Add(s);
        }

        public void RemoveSchedule(Schedule s) 
        {
            schedules.Remove(s);
            db.RemoveSchedule(s);
        }

        public void EditSchedule(Schedule s, int trainerId, string title, DateTime time, string description) 
        {
            if (title != "" && trainerId != 0) 
            {
                db.UpdateSchedule(s, trainerId, title, time, description);
                s.TrainerId = trainerId;
                s.Title = title;
                s.Description = description;
                s.Date = time;
            }
        }

        public Schedule[] GetSchedules() { return this.schedules.ToArray(); }
        public Schedule GetSchedule(string title) 
        {
            foreach (Schedule s in GetSchedules()) 
            {
                if (s.Title == title)
                {
                    return s;
                }
            }
            return null;
        }

        public void AssignSchedule(string client, string scheduleTitle) 
        {
            if (client != null)
            {
                Schedule s = GetSchedule(scheduleTitle);    
                s.ClientName = client;
            }
        }
    }
}
