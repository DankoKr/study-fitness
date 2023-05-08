using ClassLibrary.CommentClasses;
using ClassLibrary.ScheduleClasses;
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
        ScheduleAdministration myManager = new ScheduleAdministration();
        public ScheduleForm()
        {
            InitializeComponent();
            ShowData();
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
            myManager.AddSchedule(new Schedule(txbTitle.Text, Convert.ToDateTime(dateTime.Value), txbDescription.Text, Convert.ToInt32(cmbTrainer.Text)));
            ClearFields();
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
            myManager.EditSchedule(selectedS, Convert.ToInt32(cmbNewTrainer.Text), txbNewTitle.Text, DateTime.ParseExact(dateTime.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture), txbNewDescription.Text);
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
        }

    }
}
