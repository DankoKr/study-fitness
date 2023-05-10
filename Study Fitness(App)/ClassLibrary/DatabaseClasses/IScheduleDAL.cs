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
        void LoadSchedules(ScheduleAdministration myManager);
        void AddSchedule(Schedule s);
        void RemoveSchedule(Schedule s);
        void UpdateSchedule(Schedule s, int trainerId, string title, DateTime time, string description);
        void GetTrainersId(List<int> ids);
        void AssignSchedule(Schedule s, string name);
        void LoadSchedulesTrainerLevel(int level, ScheduleAdministration myManager);
        void LoadTrainerSchedules(int trainer_id, List<Schedule> schedules);
        void UnAssignSchedule(Schedule s);
    }
}
