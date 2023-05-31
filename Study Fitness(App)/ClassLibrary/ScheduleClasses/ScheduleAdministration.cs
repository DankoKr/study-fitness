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
        public ScheduleAdministration(IScheduleDAL db) 
        {
            this.db = db;
        }

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

        public void EditSchedule(Schedule s, int trainerId, DateTime time, string description) 
        {
            if (trainerId != 0) 
            {
                db.UpdateSchedule(s, trainerId, time, description);
                s.TrainerId = trainerId;
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

        public void AssignSchedule(Schedule s,string client, string scheduleTitle) 
        {
            if (client != null)
            {
                bool isDublicated = IsDumblicatedScheduleTime(s.Date, client);
                int counter = GetTotalUserBookings(client);
                if (!isDublicated && counter < 3)
                {
                    s.ClientName = client;
                    db.AssignSchedule(s, client);
                }
            }
        }

        public void UnAssignSchedule(Schedule s) 
        {
            s.ClientName = null;
            db.UnAssignSchedule(s);
        }

        public void GetTrainersSchedules(int trainer_id, List<Schedule> trainerSchedules, int pageNumber, int pageSize, bool hasMoreRows) 
        {
            db.LoadTrainerSchedules(trainer_id, trainerSchedules, pageNumber, pageSize, hasMoreRows);
        }
        public int GetTotalUserBookings(string name) 
        {
            int counter = db.GetTotalUserBookings(name);
            return counter;
        }
        public bool IsDumblicatedScheduleTime(DateTime date, string username) 
        {
            bool isDublicated = db.IsDublicatedScheduleTime(date, username);
            return isDublicated;
        }
    }
}
