using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Fitness
{
	public class LowerBodyExercise : Exercise
	{
		private string legs;

		public LowerBodyExercise(string name, string difficulty, string equipment, int reps, double weight, string legs) : base(name, difficulty, equipment, reps, weight)
		{
			this.legs = legs;
		}

		public override string ToString()
		{
			string s = "Lower Exercise - ";
			s += $" performed with {legs}. {base.ToString()}.";
			return s;
		}

	}
}
