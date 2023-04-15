using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ExerciseClasses
{
    public abstract class Exercise 
    {
        private string name;
        private string difficulty;
        private string equipment;
        private int repRange;
        private double weight;
        private string pictureUrl;

        public string Name { get; set; }
        public string Difficulty { get; set; }
        public string Equipment { get; set; }
        public int RepRange { get; set; }
        public double Weight { get; set; }
        public string PictureUrl { get; set; }

        public Exercise() { }

        public Exercise(string name, string difficulty, string equipment, int reps, double weight, string picture)
        {
            Name = name;
            Difficulty = difficulty;
            Equipment = equipment;
            RepRange = reps;
            Weight = weight;
            PictureUrl = picture;
        }

        public virtual string ToString()
        {
            return $"This is an exercise called {Name} (difficulty: {Difficulty}, required equipment: {Equipment}, rep range: {RepRange}, weight: {Weight})";
        }

        public string GetName() { return this.Name; }


    }
}
