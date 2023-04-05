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
        public string ChestElemet { get { return this.chestElement; } }

        public ChestExercise(string name, string difficulty, string equipment, int reps, double weight, string chestElement, string picture) : base(name, difficulty, equipment, reps, weight, picture)
        {
            this.chestElement = chestElement;
        }

        public override string ToString()
        {
            string s = "Chest exercise - ";
            s += $"{base.ToString()}. Affects {chestElement}!";
            return s;
        }
    }
}
