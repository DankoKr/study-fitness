using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ExerciseClasses
{
    public class LegsExercise : Exercise
    {
        private string legs;

        public LegsExercise(string name, string difficulty, string equipment, int reps, double weight, string legs) : base(name, difficulty, equipment, reps, weight)
        {
            this.legs = legs;
        }

        public override string ToString()
        {
            string s = "Legs exercise - ";
            s += $" performed with {legs}. {base.ToString()}.";
            return s;
        }
    }
}
