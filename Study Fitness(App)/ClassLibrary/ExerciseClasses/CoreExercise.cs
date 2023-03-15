﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ExerciseClasses
{
    public class CoreExercise : Exercise
    {
        public CoreExercise(string name, string difficulty, string equipment, int reps, double weight) : base(name, difficulty, equipment, reps, weight)
        {
        }

        public override string ToString()
        {
            string s = "Core exercise - ";
            s += $"{base.ToString()}. ";
            return s;
        }
    }
}
