using ClassLibrary.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary.CardioClasses
{
    public class CardioAdministration
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
            if (ValidateCardioIsUnique(cardio.Name))
            {
                myCardios.Add(cardio);
                db.AddCardio(cardio);
            }
        }

        public void AddExistingCardio(Cardio c)
        {
            myCardios.Add(c);
        }

        public bool ValidateCardioIsUnique(string name)
        {
            return db.IsUnique(name);
        }

        public bool CardioExists(string name)
        {
            if (ValidateCardioIsUnique(name))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void RemoveCardio(string name)
        {
            if (CardioExists(name))
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
            return myCardios.ToArray();
        }

        public void EditCardioData(Cardio c, int newCalories, string newDifficulty, string newPicture)
        {
            if (newCalories > 0)
            {
                db.EditCardio(c, newDifficulty, newCalories, newPicture);
                c.Calories = newCalories;
                c.Difficulty = newDifficulty;
                c.PictureURL = newPicture;
            }

        }

        public bool IsPictureValid(string pictureUrl)
        {
            string pattern = @"^(http|https):\/\/.{1,140}$";
            string extractedFilePattern = @"^.*\.(?:png|jpg|jpeg|gif|bmp)$";


            bool isValid = Regex.IsMatch(pictureUrl, pattern);
            bool isFileValid = Regex.IsMatch(pictureUrl, extractedFilePattern);

            if (isValid || isFileValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
