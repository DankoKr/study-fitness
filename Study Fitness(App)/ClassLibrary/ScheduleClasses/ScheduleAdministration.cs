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
        public ScheduleAdministration() { }

        public void AddSchedule(Schedule s) 
        {
            if (s.TrainerName != "" && s.Title != "")
            {
                schedules.Add(s);
            }
        }

        public void RemoveSchedule(Schedule s) 
        {
            schedules.Remove(s);
        }

        public void EditSchedule(Schedule s, string trainerName, string title, int time, string description) 
        {
            if (title != "" && trainerName != "") 
            { 
                s.TrainerName = trainerName;
                s.Title = title;
                s.Description = description;
                s.Time = time;
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
        public User GetClient(Schedule s) 
        {
            if (s.Client != null)
            {
                return s.Client;
            }
            return null;
        }

        public void AssignSchedule(User client, string scheduleTitle) 
        {
            if (client != null)
            {
                Schedule s = GetSchedule(scheduleTitle);    
                s.Client = client;
            }
        }
    }
}
