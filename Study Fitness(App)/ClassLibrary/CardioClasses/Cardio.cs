using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CardioClasses
{
    public class Cardio
    {
        private string name;
        private int calories;
        private string difficulty;
        private string pictureURL;

        public string Name { get; set; }
        public int Calories { get; set; }
        public string Difficulty { get; set; }
        public string PictureURL { get; set; }

        public Cardio(string name, int calories, string difficulty, string picture)
        {
            Name = name;
            Calories = calories;
            Difficulty = difficulty;
            PictureURL = picture;
        }

        public string ToString()
        {
            return $"{Name} is a cardio activity which burns {Calories} calories and has a {Difficulty} difficulty";
        }

    }
}
