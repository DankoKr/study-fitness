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
        private string picture;

        public string Name 
        { get { return this.name; } }
        public int Calories { get { return this.calories; } }
        public string Difficulty 
        { get { return this.difficulty;} }
        public string Picture { get { return this.picture; } }

        public Cardio(string name, int calories, string difficulty, string picture) 
        {
            this.name = name;
            this.calories = calories;
            this.difficulty = difficulty;
            this.picture = picture;
        }

        public string ToString() 
        {
            return $"{name} is a cardio activity which burns {calories} calories and has a {difficulty} difficulty";
        }

    }
}
