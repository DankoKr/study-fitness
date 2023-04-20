using ClassLibrary.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary.ExerciseClasses
{
    public class CardioAdministration : IAdministration
    {
        List<Cardio> myCardios = new List<Cardio>();
        private readonly ICardioDAL db;
        public CardioAdministration(ICardioDAL db) 
        {
            this.db = db;
        }

        public void CreateCardio(string name, int calories, string difficulty, string picture) 
        {
            Cardio cardio = new Cardio(name, calories, difficulty, picture);
            if (ValidateExerciseIsUnique(cardio.Name))
            {
                myCardios.Add(cardio);
                db.AddCardio(cardio);
            }
        }

        public void AddExistingCardio(Cardio c) 
        {
            myCardios.Add(c);
        }

        public bool ValidateExerciseIsUnique(string name) 
        {
            foreach (Cardio cardio in myCardios)
            {
                if (cardio.Name == name)
                {
                    return false;
                }
            }
            return true;
        }

        public bool ExerciseExists(string name) 
        {
            if (ValidateExerciseIsUnique(name))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void RemoveExercise(string name) 
        {
            if (ExerciseExists(name))
            {
                db.DeleteCardio(GetCardio(name));
                myCardios.Remove(GetCardio(name));
            }
        }

        public Cardio GetCardio(string name)
        {
            foreach (Cardio cardio in myCardios)
            {
                if (name == cardio.Name)
                {
                    return cardio;
                }
            }
            return null;
        }

        public Cardio[] GetCardios() 
        {
            return this.myCardios.ToArray();
        }

        public void EditCardioData(Cardio c, string newName, int newCalories, string newDifficulty, string newPicture) 
        {
            if (newCalories > 0 && newName != "")
            {
				db.EditCardio(c, newName, newDifficulty, newCalories, newPicture);
				c.Name = newName;
                c.Calories = newCalories;
                c.Difficulty = newDifficulty;
                c.PictureURL = newPicture;
            }

        }

    }
}
