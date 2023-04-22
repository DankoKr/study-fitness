using ClassLibrary.ExerciseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseClasses
{
	public class TestExerciseDAL : IExerciseDAL
	{
		List<Exercise> myExercises = new List<Exercise>();

		public void AddExercise(Exercise ex)
		{
			myExercises.Add(ex);
		}

		public void DeleteExercise(Exercise ex)
		{
			myExercises.Remove(ex);
		}

		public void EditExercise(Exercise ex, string difficulty, int reps, double weight)
		{
			ex.Difficulty = difficulty;
			ex.RepRange = reps;
			ex.Weight = weight;
		}

		public void LoadExercises(ExerciseAdministration myManager)
		{
			Exercise ex1 = new ChestExercise("Pushup", "Beginner", "No", 5, 50.5, "Upper chest", "picture");
			Exercise ex2 = new ShoulderExercise("Vikingpress", "Advanced", "Yes", 7, 30, "Upper head", "picture");
			Exercise ex3 = new NeckExercise("Strech", "Beginner", "No", 10, 0, "picture");
			Exercise ex4 = new LegsExercise("Squats", "Athlete", "Yes", 6, 50.8, "Both chest", "picture");
			Exercise ex5 = new ArmExercise("Curls", "Beginner", "Yes", 5, 10, "Biceps", "picture");
			Exercise ex6 = new BackExercise("Pullup", "Advanced", "No", 5, 50, "Upper back", "picture");
			Exercise ex7 = new CoreExercise("Crunches", "Beginner", "No", 5, 50, "picture");
			myExercises.Add(ex1);
			myExercises.Add(ex2);
			myExercises.Add(ex3);
			myExercises.Add(ex4);
			myExercises.Add(ex5);
			myExercises.Add(ex6);
			myExercises.Add(ex7);
			myManager.AddExistingEx(ex1);
			myManager.AddExistingEx(ex2);
			myManager.AddExistingEx(ex3);
			myManager.AddExistingEx(ex4);
			myManager.AddExistingEx(ex5);
			myManager.AddExistingEx(ex6);
			myManager.AddExistingEx(ex7);

		}
	}
}
