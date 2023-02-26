using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Fitness
{
	public class UpperBodyExercise : Exercise
	{
		private string bodyElement;

		public UpperBodyExercise(string name, string difficulty, string equipment, int reps, double weight, string bodyElement) : base(name, difficulty, equipment, reps, weight)
		{ 
		    this.bodyElement = bodyElement;
		}

		public override string ToString()
		{
			string s = "Upper Exercise - ";
			s += $" affects the {bodyElement}. {base.ToString()}. ";			
			return s;
		}



	}
}
