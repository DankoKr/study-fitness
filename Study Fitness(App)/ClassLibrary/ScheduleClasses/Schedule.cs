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
        private string trainerId;
        private string title;
        private string description;

        public int TrainerId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ClientName { get; set; }

        public Schedule(string title, DateTime time, string description, int trainerId) 
        {
            Title = title;
            Date = time;
            Description = description;
            TrainerId = trainerId;
            ClientName = null;
        }

        public Schedule(string title, DateTime time, string description, int trainerId, string name)
        {
            Title = title;
            Date = time;
            Description = description;
            TrainerId = trainerId;
            ClientName = name;
        }

        public string GetInfo() 
        {
            if (ClientName != "" && ClientName != null)
            {
                return $"Booked by {ClientName} for {Date}.";
            }
            else { return $"Empty for {Date}"; }            
        }
    }
}
