﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Study_Fitness
{
	public class ExerciseAdministration 
    {
		List<Exercise> myExercises = new List<Exercise>();
		public ExerciseAdministration() { }

		public void CreateExercise(string typeEx, string nameEx, string difficulty, string equipment, int numReps, double weight, string specialty) 
		{
            if (typeEx == "Lower body")
            {
                Exercise ex = new LowerBodyExercise(nameEx, difficulty, equipment, numReps, weight, specialty);
                AddExercise(ex);
            }
            else if (typeEx == "Upper body")
            {
                Exercise ex = new UpperBodyExercise(nameEx, difficulty, equipment, numReps, weight, specialty);
                AddExercise(ex);
            }
            else if (typeEx == "Complex")
            {
                Exercise ex = new ComplexExercise(nameEx, difficulty, equipment, numReps, weight, specialty);
                AddExercise(ex);
            }
            else
            {
                MessageBox.Show("Incorrect data!", "ERROR");
            }
        }

		public void AddExercise(Exercise newEx) 
		{
			if (ValidateExerciseIsUnique(newEx.Name))
			{
				myExercises.Add(newEx);
                MessageBox.Show("Exercise created!", "Done");
            }
			else
			{
                MessageBox.Show("Dublication of exercise name!", "ERROR");
            }
		}

		public void AddDummyData(Exercise ex) 
		{// This exists only for the dummy data before connection to a database
			myExercises.Add(ex);
		}

        public bool ValidateExerciseIsUnique(string name)
        {
            foreach (Exercise ex in myExercises)
            {
                if (ex.Name == name)
                {
                    return false;
                }
            }
            return true;
        }

		public bool ExerciseExists(string exName) 
		{
			if (ValidateExerciseIsUnique(exName))
			{
				MessageBox.Show("Exercise does not exist!", "ERROR");
				return false;
			}
			else
			{
				return true;
			}
		}

        public void RemoveExercise(string exName) 
		{
			if (ExerciseExists(exName))
			{				
				myExercises.Remove(GetExercise(exName));
                MessageBox.Show("Exercise deleted!", "Done");
            }
		}

		public void EditExercise(string exName, int numReps, double amount, string difficulty) 
		{
            Exercise selectedEx = GetExercise(exName);
            myExercises.Remove(GetExercise(exName));
			selectedEx.EditExerciseData(selectedEx, numReps, amount, difficulty);
			myExercises.Add(selectedEx);
		}

		public Exercise[] GetExercises() 
		{
		    return myExercises.ToArray();
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
