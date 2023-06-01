using ClassLibrary.DatabaseClasses;
using ClassLibrary.ScheduleClasses;
using ClassLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary.TestDataClasses
{
    public class TestScheduleDAL : IScheduleDAL
    {
        List<Schedule> schedules = new List<Schedule>();
        List<User> users = new List<User>();
        public void AddSchedule(Schedule s)
        {
            schedules.Add(s);
        }

        public void AssignSchedule(Schedule s, string name)
        {
            s.ClientName = name;
        }

        public int GetTotalUserBookings(string name)
        {
            int counter = 0;
            foreach (Schedule schedule in schedules)
            {
                if (schedule.ClientName == name)
                {
                    counter++;
                }
            }
            return counter;
        }

        public Dictionary<string, int> GetTrainersBookings()
        {//Cannot implement because this method requires real database
            throw new NotImplementedException();
        }

        public void GetTrainersId(List<int> ids)
        {
            ids.Add(1);
            ids.Add(2);
            ids.Add(3);
        }

        public bool IsDublicatedScheduleTime(DateTime date, string username)
        {
            foreach (Schedule s in schedules)
            {
                if (date == s.Date && username == s.ClientName)
                {
                    return true;
                }
            }
            return false;
        }

        public void LoadSchedules(ScheduleAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows)
        {
            string date = "2023-08-12";
            Schedule s1 = new Schedule("Title", Convert.ToDateTime(date), "desc", 1);
            Schedule s2 = new Schedule("Title2", Convert.ToDateTime(date), "desc2", 2);
            schedules.Add(s1);
            schedules.Add(s2);
            myManager.AddSchedule(s1);
            myManager.AddSchedule(s2);
        }

        public void LoadSchedulesTrainerLevel(int level, ScheduleAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows)
        {//Cannot implement because this method requires real database
            throw new NotImplementedException();
        }

        public void LoadTrainerSchedules(int trainer_id, List<Schedule> s, int pageNumber, int pageSize, bool hasMoreRows)
        {//Cannot implement because this method requires real database
            throw new NotImplementedException();
        }

        public void LoadUserBookings(ScheduleAdministration myManager, string username, int pageNumber, int pageSize, bool hasMoreRows)
        {
            foreach (User u in users)
            {
                if (u.Username == username)
                {
                    string date = "2023-08-12";
                    myManager.AddExistingSchedule(new Schedule("FakeBooking", Convert.ToDateTime(date), "desc2", 2));
                }
            }

        }

        public int NumBookedSchedulesPerTrainerLevel(int level)
        {//Cannot implement because this method requires real database
            throw new NotImplementedException();
        }

        public void RemoveSchedule(Schedule s)
        {
            schedules.Remove(s);
        }

        public void UnAssignSchedule(Schedule s)
        {
            s.ClientName = null;
        }

        public void UpdateSchedule(Schedule s, int trainerId, DateTime time, string description)
        {
            s.Description = description;
            s.TrainerId = trainerId;
            s.Date = time;
        }
    }
}
