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
        public string ShoulderHead 
        {
            get { return this.shoulderHead; } 
            set { this.shoulderHead = value;}
        }

        public ShoulderExercise(string name, string difficulty, string equipment, int reps, double weight, string shoulderHead, string picture) : base(name, difficulty, equipment, reps, weight, picture)
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
