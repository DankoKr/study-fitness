using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ExerciseClasses
{
    public class ShoulderExercise : Exercise
    {
        private string shoulderHead;

        public ShoulderExercise(string name, string difficulty, string equipment, int reps, double weight, string shoulderHead) : base(name, difficulty, equipment, reps, weight)
        {
            this.shoulderHead = shoulderHead;
        }

        public override string ToString()
        {
            string s = "Shoulder exercise - ";
            s += $"{base.ToString()}.";
            return s;
        }
    }
}
