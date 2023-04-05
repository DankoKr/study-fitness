using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ExerciseClasses
{
    public class BackExercise : Exercise
    {
        private string backElement;
        public string BackElemet { get { return this.backElement; } }
        public BackExercise(string name, string difficulty, string equipment, int reps, double weight, string backElement, string picture) : base(name, difficulty, equipment, reps, weight, picture)
        {
            this.backElement = backElement;
        }

        public override string ToString()
        {
            string s = "Back exercise - ";
            s += $" affects the {backElement}. {base.ToString()}. ";
            return s;
        }
    }
}
