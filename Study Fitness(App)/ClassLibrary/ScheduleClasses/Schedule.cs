using ClassLibrary.UserClasses;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ScheduleClasses
{
    public class Schedule
    {
        private int trainerId;
        private string title;
        private string description;
        private DateTime date;
        private string clientName;

        public int TrainerId
        {
            get { return trainerId; }
            set { trainerId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

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
