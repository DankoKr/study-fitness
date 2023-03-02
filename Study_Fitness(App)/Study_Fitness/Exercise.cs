using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

		public virtual string ToString()
		{
			return $"This is an exercise called {Name} (difficulty: {Difficulty}, required equipment: {Equipment}, rep range: {RepRange}, weight: {Weight})";
		}

		public void AddWeight(double weight) 
		{
			if (weight > 0)
			{
                Weight += weight;
            }
			else
			{
				MessageBox.Show("Cannot add negative/zero value!", "ERROR");
			}
		}

		public void RemoveWeight(double amount)
		{
			if (amount > 0 && Weight > 0)
			{
				if (Weight - amount < 0)
				{
                    Weight = 0;
                }
				else
				{
					Weight -= amount;
				}
            }
		}

		public void AddRep(int rep) 
		{
            if (rep > 0)
            {
                RepRange += rep;
            }
            else
            {
                MessageBox.Show("Cannot add negative/zero value!", "ERROR");
            }
        }

		public void RemoveRep(int rep)
		{
			if (rep > 0 && RepRange > 1)
			{
                if (RepRange - rep <= 1)
                {
                    RepRange -= rep;
                }
                else
                {
                    RepRange = 1;
                }
            }
		}

		public void EditExerciseData(Exercise ex,int newReps, double newWeight, string difficulty) 
		{
			if (newReps > 0 && newWeight >0)
			{
				ex.RepRange = newReps;
				ex.Weight = newWeight;
				ex.Difficulty = difficulty;
                MessageBox.Show("Exercise edited!", "Done");
            }
			else
			{
				MessageBox.Show("Inccorect data!", "ERROR");
			}
		}


    }
}
