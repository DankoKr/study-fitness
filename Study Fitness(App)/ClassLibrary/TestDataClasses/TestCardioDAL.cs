using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.TestDataClasses
{
    public class TestCardioDAL : ICardioDAL
    {
        private List<Cardio> cardios = new List<Cardio>();
        public void AddCardio(Cardio c)
        {
            cardios.Add(c);
        }

        public int CardioId(string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteCardio(Cardio c)
        {
            cardios.Remove(c);
        }

        public void EditCardio(Cardio c, string newDifficulty, int newCalories, string newPicture)
        {
            if (newCalories > 0)
            {
                c.Calories = newCalories;
                c.Difficulty = newDifficulty;
                c.PictureURL = newPicture;
            }
        }

        public bool isUnique(string name)
        {
            bool isUnique = true;
            foreach (Cardio c in cardios)
            {
                if (c.Name == name) return isUnique = false;
            }
            return isUnique;
        }

        public void LoadCardios(CardioAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows)
        {
            Cardio c1 = new Cardio("Cardio1", 200, "Beginner", "picture1");
            Cardio c2 = new Cardio("Cardio2", 300, "Intermediate", "picture2");
            Cardio c3 = new Cardio("Cardio3", 400, "Athlete", "picture3");
            cardios.Add(c1);
            cardios.Add(c2);
            cardios.Add(c3);
            myManager.AddExistingCardio(c1);
            myManager.AddExistingCardio(c2);
            myManager.AddExistingCardio(c3);
        }
    }
}
