using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Fitness
{
	public class ComplexExercise : Exercise
	{
		private string bodyElement;

		public ComplexExercise(string name, string difficulty, string equipment, int reps, double weight, string bodyElement) : base(name, difficulty, equipment, reps, weight)
		{
			this.bodyElement = bodyElement;
		}

		public override string ToString()
		{
			string s = "ComplexExercise - ";
			s += $" performed with {bodyElement}; details are {base.ToString()}, ";
			return s;
		}


	}
}
