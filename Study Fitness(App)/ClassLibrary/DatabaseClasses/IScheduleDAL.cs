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
        void UpdateSchedule(Schedule s, string trainerName, string title, int time, string description);
    }
}
