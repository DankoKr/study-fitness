using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ExerciseClasses
{
    public class ArmExercise : Exercise
    {
        private string armElement;
        public ArmExercise(string name, string difficulty, string equipment, int reps, double weight, string armElement) : base(name, difficulty, equipment, reps, weight)
        {
            this.armElement = armElement;
        }

        public override string ToString()
        {
            string s = "Arm exercise - ";
            s += $" affects the {armElement}. {base.ToString()}. ";
            return s;
        }
    }
}
