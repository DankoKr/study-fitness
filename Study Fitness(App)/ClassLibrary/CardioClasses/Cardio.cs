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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        public string Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        public string PictureURL
        {
            get { return pictureURL; }
            set { pictureURL = value; }
        }

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
