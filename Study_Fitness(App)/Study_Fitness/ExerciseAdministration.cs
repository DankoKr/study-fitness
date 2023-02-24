using System;
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


		public void AddExercise(Exercise newEx) 
		{
			if (ValidateExerciseIsUnique(newEx.Name))
			{
				myExercises.Add(newEx);
			}
			else
			{
                MessageBox.Show("Dublication of exercise name!", "ERROR");
            }
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
			}
		}

		public void EditExercise(Exercise ex) 
		{//To be added!
		
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
