using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ExerciseClasses
{
    public class NeckExercise : Exercise
    {
        public NeckExercise(string name, string difficulty, string equipment, int reps, double weight, string picture) : base(name, difficulty, equipment, reps, weight, picture)
        {
        }

        public override string ToString()
        {
            string s = "Neck Exercise - ";
            s += $"{base.ToString()}.";
            return s;
        }
    }
}
