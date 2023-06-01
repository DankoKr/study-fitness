using ClassLibrary.ExerciseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseClasses
{
	public interface IExerciseDAL
	{
		void AddExercise(Exercise ex);

		void DeleteExercise(Exercise ex);

		void EditExercise(Exercise ex, string difficulty, int reps, double weight);

		void LoadExercises(ExerciseAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows);
		int ExerciseId(string name);
		bool IsUnique(string name);
	}
}
