using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Fitness_App_
{
    public class ComplexExercise : Exercise
    {
        private string bodyElements;

        public ComplexExercise(string name, string difficulty, string equipment, int reps, double weight, string bodyElements) : base(name, difficulty, equipment, reps, weight)
        {
            this.bodyElements = bodyElements;
        }

        public override string ToString()
        {
            string s = "ComplexExercise - ";
            s += $" performed with the {bodyElements}. {base.ToString()}. ";
            return s;
        }
    }
}
