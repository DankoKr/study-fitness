using ClassLibrary.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Fitness_App_
{
    public partial class ScheduleStatsForm : Form
    {
        public ScheduleStatsForm()
        {
            InitializeComponent();
            IScheduleDAL db = new ScheduleDAL();
            Dictionary<string, int> trainersBookings = db.GetTrainersBookings();

            if (trainersBookings.Count > 0)
            {
                var mostBookedTrainer = trainersBookings.OrderByDescending(x => x.Value).First();
                lblFamousTrainer.Text += $"{mostBookedTrainer.Key} - {mostBookedTrainer.Value}";
            }
            else
            {
                lblFamousTrainer.Text = "No trainers found";
            }


            chartSchedules.Titles.Add("Schedules booked by trainer level");
            chartSchedules.ChartAreas[0].AxisX.Title = "trainer level";
            chartSchedules.ChartAreas[0].AxisY.Title = "num Bookings";

            chartSchedules.Series["Schedules"].Points.AddXY("0", db.NumBookedSchedulesPerTrainerLevel(0));
            chartSchedules.Series["Schedules"].Points.AddXY("1", db.NumBookedSchedulesPerTrainerLevel(1));
            chartSchedules.Series["Schedules"].Points.AddXY("2", db.NumBookedSchedulesPerTrainerLevel(2));

        }
    }
}
