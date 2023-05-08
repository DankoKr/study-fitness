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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        public string Equipment
        {
            get { return equipment; }
            set { equipment = value; }
        }

        public int RepRange
        {
            get { return repRange; }
            set { repRange = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string PictureUrl
        {
            get { return pictureUrl; }
            set { pictureUrl = value; }
        }

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


    }
}
