using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Study_Fitness_App_
{
    public partial class AppForm : Form
    {
        IExerciseDAL exData = new ExerciseDAL();
        ExerciseAdministration myAdministrator;
        public AppForm()
        {
            InitializeComponent();
            myAdministrator = new ExerciseAdministration(exData);
            exData.LoadExercises(myAdministrator);
            FillExercisesInBoxes();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbAllExercises.Items.Clear();

            string searched = txbSearchBar.Text;
            string regexPattern = "\\b\\w*" + searched + "\\w*\\b";

            foreach (Exercise ex in myAdministrator.GetExercises())
            {
                if (Regex.IsMatch(ex.Name, regexPattern, RegexOptions.IgnoreCase))
                {
                    lbAllExercises.Items.Add(ex);
                }
            }
        }

        private void FillExercisesInBoxes()
        {
            cmbSelectedEx.Items.Clear();
            cmbManageEx.Items.Clear();
            foreach (Exercise ex in myAdministrator.GetExercises())
            {
                cmbSelectedEx.Items.Add(ex.Name);
                cmbManageEx.Items.Add(ex.Name);
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

            if (myAdministrator.isExerciseTypeValid(typeEx))
            {
                if (myAdministrator.ValidateExerciseIsUnique(nameEx))
                {
                    if (myAdministrator.IsPictureValid(picture))
                    {
                        myAdministrator.CreateExercise(typeEx, nameEx, difficulty, equipment, numReps, weight, specialty, picture);

                        ClearFields();
                        ShowAllExercises();
                        FillExercisesInBoxes();
                        MessageBox.Show("Exercise created!", "Done");
                    }
                    else
                    {
                        MessageBox.Show("The URL is not in the correct format!", "ERROR");
                        txbPicture.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Exercise exists!", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Incorrect exercise type!", "ERROR");
            }

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
            if (exName != "")
            {
                myAdministrator.RemoveExercise(exName);

                ShowExercisesToManage();
                ShowAllExercises();

                ClearFields();
                FillExercisesInBoxes();
                MessageBox.Show("Exercise is deleted!", "Done");
            }
            else { MessageBox.Show("Select an exercise name!", "ERROR"); }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string exName = cmbManageEx.Text;
            if (exName != "")
            {
                int newReps = Convert.ToInt32(txbNewReps.Text);
                double newWeight = Convert.ToDouble(txbNewWeight.Text);
                string newDifficulty = cmbNewDifficulty.Text;
                myAdministrator.EditExercise(exName, newReps, newWeight, newDifficulty);
                ClearFields();
                FillExercisesInBoxes();
            }
            else { MessageBox.Show("Select an exercise name!", "ERROR"); }

        }

        private void btnCustomCompare_Click(object sender, EventArgs e)
        {
            lbExerciseSorted.Items.Clear();
            myAdministrator.SortExercises(myAdministrator.GetExercisesList());

            foreach (Exercise ex in myAdministrator.GetExercises())
            {
                lbExerciseSorted.Items.Add(ex);
            }
        }

        private void btnSortExName_Click(object sender, EventArgs e)
        {
            lbExerciseSorted.Items.Clear();
            myAdministrator.SortExercisesByName(myAdministrator.GetExercisesList());

            foreach (Exercise ex in myAdministrator.GetExercises())
            {
                lbExerciseSorted.Items.Add(ex);
            }
        }

        private void btnSortDescendingName_Click(object sender, EventArgs e)
        {
            lbExerciseSorted.Items.Clear();
            myAdministrator.SortExercisesDescending(myAdministrator.GetExercisesList(), exercise => exercise.Name);

            foreach (Exercise ex in myAdministrator.GetExercises())
            {
                lbExerciseSorted.Items.Add(ex);
            }
        }

    }
}
