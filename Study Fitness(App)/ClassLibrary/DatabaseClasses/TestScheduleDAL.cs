using ClassLibrary.ScheduleClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseClasses
{
    public class TestScheduleDAL : IScheduleDAL
    {
        List<Schedule> schedules = new List<Schedule>();
        public void AddSchedule(Schedule s)
        {
            schedules.Add(s);
        }

        public void AssignSchedule(Schedule s, string name)
        {
            s.ClientName = name;
        }

        public void GetTrainersId(List<int> ids)
        {
            ids.Add(1);
            ids.Add(2);
            ids.Add(3);
        }

        public void LoadSchedules(ScheduleAdministration myManager)
        {
            string date = "2023-08-12";
            Schedule s1 = new Schedule("Title", Convert.ToDateTime(date), "desc", 1);
            Schedule s2 = new Schedule("Title2", Convert.ToDateTime(date), "desc2", 2);
            schedules.Add(s1);
            schedules.Add(s2);
            myManager.AddSchedule(s1);  
            myManager.AddSchedule(s2);
        }

        public void LoadSchedulesTrainerLevel(int level, ScheduleAdministration myManager)
        {
            throw new NotImplementedException();
        }

        public void LoadTrainerSchedules(int trainer_id, List<Schedule> s)
        {
            throw new NotImplementedException();
        }

        public void RemoveSchedule(Schedule s)
        {
            schedules.Remove(s);
        }

        public void UnAssignSchedule(Schedule s)
        {
            throw new NotImplementedException();
        }

        public void UpdateSchedule(Schedule s, int trainerId, string title, DateTime time, string description)
        {
            s.Title = title;
            s.Description = description;
            s.TrainerId = trainerId;
            s.Date = time;
        }
    }
}
