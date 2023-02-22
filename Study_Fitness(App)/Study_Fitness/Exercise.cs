using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Study_Fitness
{
	public abstract class Exercise
	{
		protected string name;
		protected string difficulty;
		protected string equipment;
		protected int repRange;
		protected double weight;

		public string Name { get; protected set; }
		public string Difficulty { get; protected set; }
		public string Equipment { get; protected set; }
		public int RepRange { get; protected set; }
		public double Weight { get; protected set; }

		public Exercise(string name, string difficulty, string equipment, int reps, double weight) 
		{
		    this.Name = name;
			this.Difficulty = difficulty;
			this.Equipment = equipment;
			this.RepRange = reps;
		    this.Weight = weight;
		}

		public override string ToString()
		{
			return $"";
		}

		public void AddWeight(double weight) 
		{
		
		}

		public void RemoveWeight(double weight)
		{

		}

		public void AddRep(int rep) 
		{
		
		}

		public void RemoveRep(int rep)
		{

		}

	}
}
