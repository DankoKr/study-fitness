using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Fitness
{
	public partial class AppForm : Form
	{
		ExerciseAdministration myAdministrator = new ExerciseAdministration();
        private List<IMapClient> imapClientList = new List<IMapClient>();
        public AppForm()
		{
			InitializeComponent();
			CreateExercisesTesting();
            NotifierForm notifierform = new NotifierForm();
            imapClientList.Add(notifierform);
            notifierform.Show();
        }

		private void CreateExercisesTesting() 
		{//Temporary until database is added!
		    Exercise ex1 = new UpperBodyExercise("Pushup", "normal", "no", 20, 25.6, "Chest");
            myAdministrator.AddDummyData(ex1);
			lbAllExercises.Items.Add(ex1);

            Exercise ex2 = new LowerBodyExercise("Squats", "medium", "yes", 10, 65.6, "both legs");
            myAdministrator.AddDummyData(ex2);
            lbAllExercises.Items.Add(ex2);

            Exercise ex3 = new ComplexExercise("Pullup", "hard", "no", 5, 70, "Back and Arm");
            myAdministrator.AddDummyData(ex3);
            lbAllExercises.Items.Add(ex3);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbAllExercises.Items.Clear();

            string searched = txbSearchBar.Text;
            //crashes when ex does not exist
            lbAllExercises.Items.Add(myAdministrator.GetExercise(searched));
            txbSearchBar.Text = "";
        }

        private void btnViewExercise_Click(object sender, EventArgs e)
        {
            string wantedExercise = txbWantedExercise.Text;
            MessageBox.Show((myAdministrator.GetExercise(wantedExercise)).ToString(), "Description");
        }

        private void btnCreateExercise_Click(object sender, EventArgs e)
        {
            string typeEx = cmbTypeEx.Text;
            string nameEx = txbName.Text;
            string difficulty = txbDifficulty.Text;
            string equipment = txbEquipment.Text;
            int numReps = Convert.ToInt32(txbRepsNum.Text);
            double weight = Convert.ToDouble(txbWeight.Text);
            string specialty = txbSpecialty.Text;

            myAdministrator.CreateExercise(typeEx, nameEx, difficulty, equipment, numReps, weight, specialty);

            //Experimenting with Interface-------------------------

            foreach (IMapClient imapclient in imapClientList)
            {
                Exercise ex = new UpperBodyExercise(nameEx, difficulty, equipment, numReps, weight, specialty);
                imapclient.ExerciseAdded(ex);
            }

            //-----------------------------------------------------
            ClearFields();
            ShowAllExercises();
        }

        private void ShowAllExercises() 
        {  
            lbAllExercises.Items.Clear();
            foreach (Exercise ex in myAdministrator.GetExercises())
            {
                lbAllExercises.Items.Add(ex);
            }
        }

        private void ShowExercisesToManage() 
        {
            lbManageExercises.Items.Clear();
            foreach (Exercise ex in myAdministrator.GetExercises())
            {
                lbManageExercises.Items.Add(ex);
            }
        }

        private void ClearFields() 
        {
            cmbTypeEx.Text = "";
            txbName.Text = "";
            txbDifficulty.Text = "";
            txbEquipment.Text = "";
            txbRepsNum.Text = "";
            txbWeight.Text = "";
            txbSpecialty.Text = "";
            txbManageExercise.Text = "";
            txbNewDifficulty.Text = "";
            txbNewReps.Text = "";
            txbNewWeight.Text = "";
        }

        private void btnShowExercises_Click(object sender, EventArgs e)
        {
            ShowAllExercises();
        }

        private void btnManageAllExercises_Click(object sender, EventArgs e)
        {
            ShowExercisesToManage();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string exName = txbManageExercise.Text;
            myAdministrator.RemoveExercise(exName);
            ShowExercisesToManage();
            ShowAllExercises();

            ////Experimenting with Interface-------------------------

            //foreach (IMapClient imapclient in imapClientList)
            //{               
            //    imapclient.ExerciseRemoved(myAdministrator.GetExercise(exName));
            //}

            ////-----------------------------------------------------

            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string exName = txbManageExercise.Text;
            int newReps = Convert.ToInt32(txbNewReps.Text);
            double newWeight = Convert.ToDouble(txbNewWeight.Text);
            string newDifficulty = txbNewDifficulty.Text;
            myAdministrator.EditExercise(exName, newReps, newWeight, newDifficulty);
            ClearFields();
        }


    }
}
