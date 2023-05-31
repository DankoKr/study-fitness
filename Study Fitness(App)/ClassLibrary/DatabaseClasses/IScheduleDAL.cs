using ClassLibrary.ScheduleClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseClasses
{
    public interface IScheduleDAL
    {
        void LoadSchedules(ScheduleAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows);
        void AddSchedule(Schedule s);
        void RemoveSchedule(Schedule s);
        void UpdateSchedule(Schedule s, int trainerId, DateTime time, string description);
        void GetTrainersId(List<int> ids);
        void AssignSchedule(Schedule s, string name);
        void LoadSchedulesTrainerLevel(int level, ScheduleAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows);
        void LoadTrainerSchedules(int trainer_id, List<Schedule> schedules, int pageNumber, int pageSize, bool hasMoreRows);
        void UnAssignSchedule(Schedule s);
        void LoadUserBookings(ScheduleAdministration myManager, string username, int pageNumber, int pageSize, bool hasMoreRows);
        int GetTotalUserBookings(string name);
        bool IsDublicatedScheduleTime(DateTime date, string username);
        Dictionary<string, int> GetTrainersBookings();
        int NumBookedSchedulesPerTrainerLevel(int level);
    }
}
