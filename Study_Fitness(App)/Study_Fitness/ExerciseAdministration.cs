using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Fitness
{
	public class ExerciseAdministration
	{
		List<Exercise> myExercises = new List<Exercise>();
		public ExerciseAdministration() { }


		public void AddExercise(Exercise ex) 
		{ 
		
		}

		public void RemoveExercise(Exercise ex) 
		{
		
		}

		public void EditExercise(Exercise ex) 
		{
		
		}

		public Exercise[] GetExercise() 
		{
		    return this.myExercises.ToArray();
		}

		public Exercise GetExercise(string name) 
		{
			foreach (Exercise ex in myExercises)
			{
				if (name == ex.Name)
				{
					return ex;
				}
			}
			return null;
		}



	}
}
