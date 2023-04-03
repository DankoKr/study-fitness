using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Study_Fitness_App_
{
    public partial class AppForm : Form
    {
        ExerciseAdministration myAdministrator = new ExerciseAdministration();
        ExerciseDAL exData = new ExerciseDAL();
        public AppForm()
        {
            InitializeComponent();
            exData.LoadExercises(myAdministrator);
            FillExercisesInBoxes();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbAllExercises.Items.Clear();

            string searched = txbSearchBar.Text;
            lbAllExercises.Items.Add(myAdministrator.GetExercise(searched));
            txbSearchBar.Text = "";
        }

        private void FillExercisesInBoxes()
        {
            foreach (Exercise ex in myAdministrator.GetExercises())
            {
                cmbSelectedEx.Items.Add(ex.GetName());
                cmbManageEx.Items.Add(ex.GetName());
            }
        }

        private void btnViewExercise_Click(object sender, EventArgs e)
        {
            string wantedExercise = cmbSelectedEx.Text;
            MessageBox.Show((myAdministrator.GetExercise(wantedExercise)).ToString(), "Description");
        }

        private void btnCreateExercise_Click(object sender, EventArgs e)
        {
            string typeEx = cmbTypeEx.Text;
            string nameEx = txbName.Text;
            string difficulty = cmbDifficulty.Text;
            string equipment = txbEquipment.Text;
            int numReps = Convert.ToInt32(txbNumReps.Text);
            double weight = Convert.ToDouble(txbWeight.Text);
            string specialty = txbSpecialty.Text;
            string picture = txbPicture.Text;

            myAdministrator.CreateExercise(typeEx, nameEx, difficulty, equipment, numReps, weight, specialty, picture);

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
            cmbDifficulty.Text = "";
            txbEquipment.Text = "";
            txbNumReps.Text = "";
            txbWeight.Text = "";
            txbSpecialty.Text = "";
            cmbManageEx.Text = "";
            cmbNewDifficulty.Text = "";
            txbNewReps.Text = "";
            txbNewWeight.Text = "";
            txbPicture.Text = "";
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
            string exName = cmbManageEx.Text;
            myAdministrator.RemoveExercise(exName);

            ShowExercisesToManage();
            ShowAllExercises();

            ClearFields();
            FillExercisesInBoxes();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string exName = cmbManageEx.Text;
            int newReps = Convert.ToInt32(txbNewReps.Text);
            double newWeight = Convert.ToDouble(txbNewWeight.Text);
            string newDifficulty = cmbNewDifficulty.Text;
            myAdministrator.EditExercise(exName, newReps, newWeight, newDifficulty);
            ClearFields();
            FillExercisesInBoxes();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            (myAdministrator.GetExercisesList()).Sort();
            lbTest.Items.Clear();

            foreach (Exercise ex in myAdministrator.GetExercises())
            {
                lbTest.Items.Add(ex);
            }
        }

    }
}
