using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ExerciseClasses
{
    public abstract class Exercise : IComparable<Exercise>
    {

        public string Name { get; set; }
        public string Difficulty { get; set; }
        public string Equipment { get; set; }
        public int RepRange { get; set; }
        public double Weight { get; set; }

        public Exercise(string name, string difficulty, string equipment, int reps, double weight)
        {
            Name = name;
            Difficulty = difficulty;
            Equipment = equipment;
            RepRange = reps;
            Weight = weight;
        }

        public virtual string ToString()
        {
            return $"This is an exercise called {Name} (difficulty: {Difficulty}, required equipment: {Equipment}, rep range: {RepRange}, weight: {Weight})";
        }

        public int CompareTo(Exercise compareExercise)
        {
            if (compareExercise.Weight > Weight)
                return -1;
            else if (compareExercise.Weight < Weight)
                return 1;

            return string.Compare(Name, compareExercise.Name);
        }

    }
}
