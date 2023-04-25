using ClassLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ScheduleClasses
{
    public class Schedule
    {
        public string TrainerName { get; set; }
        public string Title { get; set; }
        public int Time { get; set; }
        public string Description { get; set; }
        public User? Client { get; set; }

        public Schedule(string title, int time, string description, string trainerName) 
        {
            Title = title;
            Time = time;
            Description = description;
            TrainerName = trainerName;
            Client = null;
        }

        public string GetInfo() { return $"Booked by {Client?.FirstName} for {Time}."; }
    }
}
