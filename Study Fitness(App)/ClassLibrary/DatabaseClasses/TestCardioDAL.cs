using ClassLibrary.ExerciseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseClasses
{
	public class TestCardioDAL : ICardioDAL
	{
		private List<Cardio> cardios = new List<Cardio>();
		public void AddCardio(Cardio c)
		{
			cardios.Add(c);
		}

		public void DeleteCardio(Cardio c)
		{
			cardios.Remove(c);
		}

		public void EditCardio(Cardio c, string newName, string newDifficulty, int newCalories, string newPicture)
		{
			if (newCalories > 0 && newName != "")
			{
				c.Name = newName;
				c.Calories = newCalories;
				c.Difficulty = newDifficulty;
				c.PictureURL = newPicture;
			}
		}

		public void LoadCardios(CardioAdministration myManager)
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
