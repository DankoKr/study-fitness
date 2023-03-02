using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Fitness
{
    public partial class NotifierForm : Form, IMapClient
    {
        public NotifierForm()
        {
            InitializeComponent();
        }

        void IMapClient.ExerciseAdded(Exercise ex)
        {
            lbLatestActions.Items.Add($"Added ->  '{ex.Name}' exercise");
        }

        void IMapClient.ExerciseRemoved(Exercise ex)
        {
            lbLatestActions.Items.Add($"Removed -> '{ex.Name}' exercise");
        }



    }
}
