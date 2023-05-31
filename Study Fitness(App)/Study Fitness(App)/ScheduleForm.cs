using ClassLibrary.CardioClasses;
using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ScheduleClasses;
using ClassLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows;

        public ScheduleForm()
        {
            InitializeComponent();
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
            myManager = new ScheduleAdministration(db);
            db.LoadSchedules(myManager, currentPage, pageSize, hasRows);

            foreach (Schedule s in myManager.GetSchedules())
            {
                lbSchedule.Items.Add(s);
            }
        }

        public void ClearFields()
        {
            txbDescription.Text = "";
            txbNewDescription.Text = "";
            txbTitle.Text = "";
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
                MessageBox.Show("Incorrect data!", "ERROR");
            }

        }

        private void btnShowTrainerSchedules_Click(object sender, EventArgs e)
        {
            if (cmbTrainerId.Text != "")
            {
                lbScheduleTrainer.Items.Clear();
                List<Schedule> trainerSchedules = new List<Schedule>();
                myManager.GetTrainersSchedules(Convert.ToInt32(cmbTrainerId.Text), trainerSchedules, currentPage, pageSize, hasRows);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbSchedule.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Schedule!");
                return;
            }

            object obj = lbSchedule.SelectedItem;
            Schedule selectedS = (Schedule)obj;
            myManager.RemoveSchedule(selectedS);
            ShowData();
            MessageBox.Show("Schedule deleted!", "Done");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbSchedule.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Schedule!");
                return;
            }

            object obj = lbSchedule.SelectedItem;
            Schedule selectedS = (Schedule)obj;
            DateTime time = Convert.ToDateTime(dateTime.Value);
            myManager.EditSchedule(selectedS, Convert.ToInt32(cmbNewTrainer.Text), time, txbNewDescription.Text);
            ShowData();
            MessageBox.Show("Schedule changed!", "Done");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            db.LoadSchedules(myManager, currentPage, pageSize, hasRows);
            ShowData();
            btnNext.Enabled = hasRows;
            btnPrevious.Enabled = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                db.LoadSchedules(myManager, currentPage, pageSize, hasRows);
                ShowData();
                btnNext.Enabled = true;
                if (currentPage == 1)
                {
                    btnPrevious.Enabled = false;
                }
            }
            else { btnPrevious.Enabled = false; }
        }
    }
}
