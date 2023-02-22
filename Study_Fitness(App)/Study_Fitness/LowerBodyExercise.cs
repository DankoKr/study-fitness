using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Fitness
{
	public class LowerBodyExercise : Exercise
	{
		private bool singleLegExercise;

		public LowerBodyExercise(string name, string difficulty, string equipment, int reps, double weight, bool bodyElement) : base(name, difficulty, equipment, reps, weight)
		{
			this.singleLegExercise = bodyElement;
		}

		public override string ToString()
		{
			string s = "Lower Exercise - ";
			s += $" performed with {singleLegExercise} legs; details are {base.ToString()}, ";
			return s;
		}

		public void WeightOnLeg(bool leg, double amount) 
		{
		    
		}



	}
}
