using ClassLibrary.CardioClasses;
using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Fitness_App_
{
    public partial class CardioForm : Form
    {
        CardioAdministration myManager;
        ICardioDAL cardioDAL = new CardioDAL();
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows;
        public CardioForm()
        {
            InitializeComponent();
            ShowData();
            btnPrevious.Enabled = false;
        }

        private void btnCreateCardio_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            if (name != "")
            {
                if (myManager.ValidateCardioIsUnique(name) && myManager.IsPictureValid(txbPictureURL.Text))
                {
                    string difficulty = cmbDifficulty.Text;
                    int calories = Convert.ToInt32(numCalories.Text);
                    string picture = txbPictureURL.Text;

                    myManager.CreateCardio(name, calories, difficulty, picture);
                    ClearFields();
                    MessageBox.Show("Cardio created!", "Done");
                    ShowData();
                }
                else
                {
                    MessageBox.Show("Dublication of name or incorrect URL!", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Incorrect data!", "ERROR");
            }
        }

        private void ClearFields()
        {
            txbName.Text = "";
            txbNewName.Text = "";
            txbPictureURL.Text = "";
            txbNewPicURL.Text = "";
            numCalories.Text = "0";
            numNewCalories.Text = "0";
            cmbDifficulty.Text = "";
            cmbNewDifficulty.Text = "";
        }

        private void ShowData()
        {
            lbCardios.Items.Clear();
            myManager = new CardioAdministration(cardioDAL);
            cardioDAL.LoadCardios(myManager, currentPage, pageSize, hasRows);

            foreach (Cardio c in myManager.GetCardios())
            {
                lbCardios.Items.Add(c);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (lbCardios.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Cardio!");
                return;
            }

            object obj = lbCardios.SelectedItem;
            Cardio selectedC = (Cardio)obj;
            MessageBox.Show(selectedC.ToString(), "Data");
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of selected file
                string filePath = openFileDialog.FileName;

                // Display the path of image file in the textbox
                txbPictureURL.Text = filePath;
            }
        }

        private void btnSaveFileImage_Click(object sender, EventArgs e)
        {
            File.Copy(txbPictureURL.Text, Path.Combine(@"C:\Users\panay\Desktop\Study Fitness\study-fitness\Study Fitness(App)\Website\wwwroot\Images\", Path.GetFileName(txbPictureURL.Text)), true);
            MessageBox.Show("Picture saved!", "Done");

            // Extract image file name from path
            string imageName = Path.GetFileName(txbPictureURL.Text);

            // Display the name of the image file in the textbox
            txbPictureURL.Text = imageName;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbCardios.Items.Clear();

            string searched = txbSearchBar.Text;
            string regexPattern = "\\b\\w*" + searched + "\\w*\\b";

            foreach (Cardio ex in myManager.GetCardios())
            {
                if (Regex.IsMatch(ex.Name, regexPattern, RegexOptions.IgnoreCase))
                {
                    lbCardios.Items.Add(ex);
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                cardioDAL.LoadCardios(myManager, currentPage, pageSize, hasRows);
                ShowData();
                btnNext.Enabled = true;
                if (currentPage == 1)
                {
                    btnPrevious.Enabled = false;
                }
            }
            else { btnPrevious.Enabled = false; }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            cardioDAL.LoadCardios(myManager, currentPage, pageSize, hasRows);
            ShowData();
            btnNext.Enabled = hasRows;
            btnPrevious.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbCardios.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Cardio!");
                return;
            }

            object obj = lbCardios.SelectedItem;
            Cardio selectedC = (Cardio)obj;
            if (myManager.IsPictureValid(txbNewPicURL.Text))
            {
                myManager.EditCardioData(selectedC, txbNewName.Text, Convert.ToInt32(numNewCalories.Text), cmbNewDifficulty.Text, txbNewPicURL.Text);
                ClearFields();
                ShowData();
                MessageBox.Show("Cardio changed!", "Done");
            }
            else
            {
                MessageBox.Show("Incorrect URL!", "ERROR");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbCardios.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Cardio!");
                return;
            }

            object obj = lbCardios.SelectedItem;
            Cardio selectedC = (Cardio)obj;
            myManager.RemoveCardio(selectedC.Name);
            ShowData();
            MessageBox.Show("Cardio deleted!", "Done");
        }
    }
}
