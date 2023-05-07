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
using System.Windows.Forms.DataVisualization.Charting;

namespace Study_Fitness_App_
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
            ICommentDAL db = new CommentDAL();

            chartComments.Titles.Add("Ratings from Comments");
            chartComments.ChartAreas[0].AxisX.Title = "Rating";
            chartComments.ChartAreas[0].AxisY.Title = "Comments";

            chartComments.Series["Comments"].Points.AddXY("1", db.GetCommentsByRating(1));
            chartComments.Series["Comments"].Points.AddXY("2", db.GetCommentsByRating(2));
            chartComments.Series["Comments"].Points.AddXY("3", db.GetCommentsByRating(3));
            chartComments.Series["Comments"].Points.AddXY("4", db.GetCommentsByRating(4));
            chartComments.Series["Comments"].Points.AddXY("5", db.GetCommentsByRating(5));

            chartComments.Series["Comments"].Points[0].Color = Color.Red;
            chartComments.Series["Comments"].Points[1].Color = Color.Orange;
            chartComments.Series["Comments"].Points[2].Color = Color.Yellow;
            chartComments.Series["Comments"].Points[3].Color = Color.Blue;
            chartComments.Series["Comments"].Points[4].Color = Color.Green;
        }
    }
}
