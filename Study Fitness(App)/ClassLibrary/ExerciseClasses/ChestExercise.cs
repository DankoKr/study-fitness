using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ExerciseClasses
{
    public class ChestExercise : Exercise
    {
        private string chestElement;

        public ChestExercise(string name, string difficulty, string equipment, int reps, double weight, string chestElement) : base(name, difficulty, equipment, reps, weight)
        {
            this.chestElement = chestElement;
        }

        public override string ToString()
        {
            string s = "Chest exercise - ";
            s += $"{base.ToString()}. ";
            return s;
        }
    }
}
