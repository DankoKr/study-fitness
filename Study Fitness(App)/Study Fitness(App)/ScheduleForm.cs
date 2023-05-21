using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ScheduleClasses;
using ClassLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Fitness_App_
{
    public partial class ScheduleForm : Form
    {
        ScheduleAdministration myManager;
        IScheduleDAL db = new ScheduleDAL();
        List<int> ids = new List<int>();

        public ScheduleForm()
        {
            InitializeComponent();
            myManager = new ScheduleAdministration(db);
            db.LoadSchedules(myManager);
            db.GetTrainersId(ids);
            ShowData();
            FillTrainerCombos();
        }

        private void FillTrainerCombos()
        {
            foreach (int id in ids)
            {
                cmbTrainer.Items.Add(id);
                cmbNewTrainer.Items.Add(id);
                cmbTrainerId.Items.Add(id);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (lbSchedule.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Schedule!");
                return;
            }

            object obj = lbSchedule.SelectedItem;
            Schedule selectedS = (Schedule)obj;
            MessageBox.Show(selectedS.GetInfo(), "Data");
        }

        public void ShowData()
        {
            lbSchedule.Items.Clear();
            lbManageSchedule.Items.Clear();
            foreach (Schedule s in myManager.GetSchedules())
            {
                lbSchedule.Items.Add(s);
                lbManageSchedule.Items.Add(s);
            }
        }

        public void ClearFields()
        {
            txbDescription.Text = "";
            txbNewDescription.Text = "";
            txbNewTitle.Text = "";
            txbTitle.Text = "";
        }

        private void btnViewAllSchedules_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnCreateSchedule_Click(object sender, EventArgs e)
        {
            if (txbTitle.Text != "")
            {
                myManager.AddSchedule(new Schedule(txbTitle.Text, Convert.ToDateTime(dateTime.Value), txbDescription.Text, Convert.ToInt32(cmbTrainer.Text)));
                ClearFields();
                ShowData();
                MessageBox.Show("Schedule created!", "Done");
            }
            else
            {
                MessageBox.Show("Incorrect data!","ERROR");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbManageSchedule.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Schedule!");
                return;
            }

            object obj = lbManageSchedule.SelectedItem;
            Schedule selectedS = (Schedule)obj;
            myManager.EditSchedule(selectedS, Convert.ToInt32(cmbNewTrainer.Text), txbNewTitle.Text, Convert.ToDateTime(dateTime.Value), txbNewDescription.Text);
            ShowData();
            MessageBox.Show("Schedule changed!", "Done");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbManageSchedule.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Schedule!");
                return;
            }

            object obj = lbManageSchedule.SelectedItem;
            Schedule selectedS = (Schedule)obj;
            myManager.RemoveSchedule(selectedS);
            ShowData();
            MessageBox.Show("Schedule deleted!", "Done");
        }

        private void btnShowTrainerSchedules_Click(object sender, EventArgs e)
        {
            if (cmbTrainerId.Text != "")
            {
                lbScheduleTrainer.Items.Clear();
                List<Schedule> trainerSchedules = new List<Schedule>();
                myManager.GetTrainersSchedules(Convert.ToInt32(cmbTrainerId.Text), trainerSchedules);
                foreach (Schedule schedule in trainerSchedules)
                {
                    lbScheduleTrainer.Items.Add(schedule);
                }
            }
            else
            {
                MessageBox.Show("Select a trainer Id!", "ERROR");
            }
        }

        private void btnViewTrainerSchedule_Click(object sender, EventArgs e)
        {
            if (lbScheduleTrainer.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Schedule!");
                return;
            }

            object obj = lbScheduleTrainer.SelectedItem;
            Schedule selectedS = (Schedule)obj;
            MessageBox.Show(selectedS.GetInfo(), "Data");
        }
    }
}
