using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ExerciseClasses
{
    public class Cardio
    {
        private string name;
        private int calories;
        private string difficulty;

        public string Name { get; set; }
        public int Calories { get; set; }
        public string Difficulty { get; set; }

        public Cardio(string name, int calories, string difficulty) 
        {
            this.name = name;
            this.calories = calories;
            this.difficulty = difficulty;
        }

        public string ToString() 
        {
            return $"{name} is a cardio activity which burns {calories} calories and has a {difficulty} difficulty";
        }

    }
}
