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
        public string Legs { get { return this.legs; } }
        public LegsExercise(string name, string difficulty, string equipment, int reps, double weight, string legs, string picture) : base(name, difficulty, equipment, reps, weight, picture)
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
