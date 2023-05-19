using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Fitness_App_
{
    public partial class CardioForm : Form
    {
        CardioAdministration myAdministration;
        public CardioForm()
        {
            InitializeComponent();
            ICardioDAL cardioDAL = new CardioDAL();
            myAdministration = new CardioAdministration(cardioDAL);
            cardioDAL.LoadCardios(myAdministration);
        }

        private void btnCreateCardio_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string difficulty = cmbDifficulty.Text;
            int calories = Convert.ToInt32(numCalories.Text);
            string picture = txbPictureURL.Text;

            myAdministration.CreateCardio(name, calories, difficulty, picture);
            ClearFields();
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
            lbManageCardio.Items.Clear();

            foreach (Cardio c in myAdministration.GetCardios())
            {
                lbCardios.Items.Add(c);
                lbManageCardio.Items.Add(c);
            }
        }


        private void btnViewAllCardios_Click(object sender, EventArgs e)
        {
            ShowData();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbManageCardio.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Cardio!");
                return;
            }

            object obj = lbManageCardio.SelectedItem;
            Cardio selectedC = (Cardio)obj;
            myAdministration.RemoveCardio(selectedC.Name);
            ShowData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbManageCardio.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a Cardio!");
                return;
            }

            object obj = lbManageCardio.SelectedItem;
            Cardio selectedC = (Cardio)obj;
            myAdministration.EditCardioData(selectedC, txbNewName.Text, Convert.ToInt32(numNewCalories.Text), cmbNewDifficulty.Text, txbNewPicURL.Text);
            ClearFields();
            ShowData();
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
            MessageBox.Show("Picture saved!","Done");

            // Extract image file name from path
            string imageName = Path.GetFileName(txbPictureURL.Text);

            // Display the name of the image file in the textbox
            txbPictureURL.Text = imageName;
        }
    }
}
