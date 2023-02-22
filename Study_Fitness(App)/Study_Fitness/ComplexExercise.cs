using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Fitness
{
	public class ComplexExercise : Exercise
	{
		private int numCombinedExercises;
		private string bodyElement;

		public ComplexExercise(string name, string difficulty, string equipment, int reps, double weight, int exercises, string bodyElement) : base(name, difficulty, equipment, reps, weight)
		{
			this.bodyElement = bodyElement;
			this.numCombinedExercises = exercises;
		}

		public override string ToString()
		{
			string s = "ComplexExercise - ";
			s += $" performed with {bodyElement} from {numCombinedExercises} exercises; details are {base.ToString()}, ";
			return s;
		}

		public void WeightPerElement(int numExercises)
		{

		}




	}
}
