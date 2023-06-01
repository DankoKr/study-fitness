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
using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Study_Fitness_App_
{
    public partial class AppForm : Form
    {
        IExerciseDAL db = new ExerciseDAL();
        ExerciseAdministration myManager;
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows;
        public AppForm()
        {
            InitializeComponent();
            ShowData();
            btnPrevious.Enabled = false;
            txbSearchBar.TextChanged += txbSearchBar_TextChanged;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbExercises.Items.Clear();

            string[] searchLines = txbSearchBar.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            string namePattern = searchLines.Length > 0 ? "\\b\\w*" + searchLines[0] + "\\w*\\b" : null;
            int? weight = searchLines.Length > 1 && int.TryParse(searchLines[1], out var parsedWeight) ? parsedWeight : (int?)null;
            string difficulty = searchLines.Length > 2 ? searchLines[2] : null;

            foreach (Exercise ex in myManager.GetExercises())
            {
                bool nameMatch = namePattern == null || Regex.IsMatch(ex.Name, namePattern, RegexOptions.IgnoreCase);
                bool weightMatch = !weight.HasValue || ex.Weight == weight.Value;
                bool difficultyMatch = string.IsNullOrWhiteSpace(difficulty) || ex.Difficulty.IndexOf(difficulty, StringComparison.OrdinalIgnoreCase) >= 0;

                if (nameMatch && weightMatch && difficultyMatch)
                {
                    lbExercises.Items.Add(ex);
                }
            }
        }

        private void txbSearchBar_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                string[] lines = textBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                if (lines.Length > 3)
                {
                    // Ignore further input and inform the user
                    MessageBox.Show("You cannot enter more than 3 lines.", "ERROR");
                    textBox.Text = string.Join(Environment.NewLine, lines.Take(3));
                }
            }
        }


        private void btnViewExercise_Click(object sender, EventArgs e)
        {
            if (lbExercises.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose an Exercise!");
                return;
            }

            object obj = lbExercises.SelectedItem;
            Exercise selectedE = (Exercise)obj;
            MessageBox.Show(selectedE.ToString(), "Data");
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

            if (myManager.IsExerciseTypeValid(typeEx))
            {
                if (myManager.ValidateExerciseIsUnique(nameEx))
                {
                    if (myManager.IsPictureValid(picture))
                    {
                        myManager.CreateExercise(typeEx, nameEx, difficulty, equipment, numReps, weight, specialty, picture);

                        ClearFields();
                        ShowData();
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

        private void ShowData()
        {
            lbExercises.Items.Clear();
            myManager = new ExerciseAdministration(db);
            db.LoadExercises(myManager, currentPage, pageSize, hasRows);

            foreach (Exercise ex in myManager.GetExercises())
            {
                lbExercises.Items.Add(ex);
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
            cmbNewDifficulty.Text = "";
            txbNewReps.Text = "";
            txbNewWeight.Text = "";
            txbPicture.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            db.LoadExercises(myManager, currentPage, pageSize, hasRows);
            ShowData();
            btnNext.Enabled = hasRows;
            btnPrevious.Enabled = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                db.LoadExercises(myManager, currentPage, pageSize, hasRows);
                ShowData();
                btnNext.Enabled = true;
                if (currentPage == 1)
                {
                    btnPrevious.Enabled = false;
                }
            }
            else { btnPrevious.Enabled = false; }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbExercises.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose an Exercise!");
                return;
            }

            object obj = lbExercises.SelectedItem;
            Exercise selectedE = (Exercise)obj;

            int newReps = Convert.ToInt32(txbNewReps.Text);
            double newWeight = Convert.ToDouble(txbNewWeight.Text);
            string newDifficulty = cmbNewDifficulty.Text;
            myManager.EditExercise(selectedE.Name, newReps, newWeight, newDifficulty);
            ClearFields();
            ShowData();
            MessageBox.Show("Exercise is edited!", "Done");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbExercises.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose an Exercise!");
                return;
            }

            object obj = lbExercises.SelectedItem;
            Exercise selectedE = (Exercise)obj;

            myManager.RemoveExercise(selectedE.Name);
            ShowData();
            ClearFields();
            MessageBox.Show("Exercise is deleted!", "Done");
        }

        private void btnSortDescendingName_Click(object sender, EventArgs e)
        {
            lbExercises.Items.Clear();
            myManager.SortExercisesDescending(myManager.GetExercisesList(), exercise => exercise.Name);

            foreach (Exercise ex in myManager.GetExercises())
            {
                lbExercises.Items.Add(ex);
            }
        }

        private void btnSortExName_Click(object sender, EventArgs e)
        {
            lbExercises.Items.Clear();
            myManager.SortExercisesByName(myManager.GetExercisesList());

            foreach (Exercise ex in myManager.GetExercises())
            {
                lbExercises.Items.Add(ex);
            }
        }

        private void btnCustomCompare_Click(object sender, EventArgs e)
        {
            lbExercises.Items.Clear();
            myManager.SortExercises(myManager.GetExercisesList());

            foreach (Exercise ex in myManager.GetExercises())
            {
                lbExercises.Items.Add(ex);
            }
        }
    }
}
