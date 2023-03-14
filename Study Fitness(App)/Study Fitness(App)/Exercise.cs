using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Fitness_App_
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
            this.Name = name;
            this.Difficulty = difficulty;
            this.Equipment = equipment;
            this.RepRange = reps;
            this.Weight = weight;
        }

        public virtual string ToString()
        {
            return $"This is an exercise called {Name} (difficulty: {Difficulty}, required equipment: {Equipment}, rep range: {RepRange}, weight: {Weight})";
        }

        public int CompareTo(Exercise compareExercise) 
        {
            if (compareExercise.Weight > this.Weight)
                return -1;
            else if (compareExercise.Weight < this.Weight)
                return 1;

            return String.Compare(this.Name, compareExercise.Name);
        }

    }
}
