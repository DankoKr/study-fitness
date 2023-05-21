using ClassLibrary.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ClassLibrary.ExerciseClasses
{
    public class ExerciseAdministration : IExerciseComparer
    {
        List<Exercise> myExercises = new List<Exercise>();
        IExerciseDAL ExerciseDAL = new ExerciseDAL();

        public ExerciseAdministration(IExerciseDAL ExerciseDAL)
        {
            this.ExerciseDAL = ExerciseDAL;
        }

        public void CreateExercise(string typeEx, string nameEx, string difficulty, string equipment, int numReps, double weight, string specialty, string picture)
        {
            if (typeEx == "Chest")
            {
                Exercise ex = new ChestExercise(nameEx, difficulty, equipment, numReps, weight, specialty, picture);
                AddExercise(ex);
            }
            else if (typeEx == "Arm")
            {
                Exercise ex = new ArmExercise(nameEx, difficulty, equipment, numReps, weight, specialty, picture);
                AddExercise(ex);
            }
            else if (typeEx == "Back")
            {
                Exercise ex = new BackExercise(nameEx, difficulty, equipment, numReps, weight, specialty, picture);
                AddExercise(ex);
            }
            else if (typeEx == "Core")
            {
                Exercise ex = new CoreExercise(nameEx, difficulty, equipment, numReps, weight, picture);
                AddExercise(ex);
            }
            else if (typeEx == "Legs")
            {
                Exercise ex = new LegsExercise(nameEx, difficulty, equipment, numReps, weight, specialty, picture);
                AddExercise(ex);
            }
            else if (typeEx == "Neck")
            {
                Exercise ex = new NeckExercise(nameEx, difficulty, equipment, numReps, weight, picture);
                AddExercise(ex);
            }
            else if (typeEx == "Shoulder")
            {
                Exercise ex = new ShoulderExercise(nameEx, difficulty, equipment, numReps, weight, specialty, picture);
                AddExercise(ex);
            }
        }

        public void AddExercise(Exercise newEx)
        {
            if (ValidateExerciseIsUnique(newEx.Name))
            {
                myExercises.Add(newEx);
                ExerciseDAL.AddExercise(newEx);
            }
        }

        public void AddExistingEx(Exercise loadEx)
        {
            myExercises.Add(loadEx);
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
                ExerciseDAL.DeleteExercise(GetExercise(exName));
                myExercises.Remove(GetExercise(exName));

            }
        }

        public void EditExercise(string exName, int numReps, double amount, string difficulty)
        {
            Exercise selectedEx = GetExercise(exName);
            myExercises.Remove(GetExercise(exName));
            EditExerciseData(selectedEx, numReps, amount, difficulty);
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

        public List<Exercise> GetExercisesList()
        {
            return myExercises;
        }

        public void EditExerciseData(Exercise ex, int newReps, double newWeight, string difficulty)
        {
            if (newReps > 0 && newWeight > 0)
            {
                ex.RepRange = newReps;
                ex.Weight = newWeight;
                ex.Difficulty = difficulty;
                ExerciseDAL.EditExercise(ex, difficulty, newReps, newWeight);
            }
        }

        public void SortExercises(List<Exercise> exercises)
        {
            exercises.Sort((ex1, ex2) => CompareExercises(ex1, ex2));
        }

        private int CompareExercises(Exercise ex1, Exercise ex2)
        {
            // First, compare by weight
            int weightComparison = ex1.Weight.CompareTo(ex2.Weight);
            if (weightComparison != 0)
            {
                return weightComparison;
            }

            // If weights are the same, compare by reps
            int repsComparison = ex1.RepRange.CompareTo(ex2.RepRange);
            if (repsComparison != 0)
            {
                return repsComparison;
            }

            // If reps are the same, compare by name alphabetically
            return string.Compare(ex1.Name, ex2.Name, StringComparison.OrdinalIgnoreCase);
        }

        public void SortExercisesByName(List<Exercise> exercises)
        {
            exercises.Sort((ex1, ex2) => string.Compare(ex1.Name, ex2.Name, StringComparison.OrdinalIgnoreCase));
        }

        public void SortExercisesDescending(List<Exercise> exercises, Func<Exercise, IComparable> keySelector)
        {
            exercises.Sort((ex1, ex2) => keySelector(ex2).CompareTo(keySelector(ex1)));
        }

        public bool IsPictureValid(string pictureUrl)
        {
            string pattern = @"^(http|https):\/\/.{1,140}$";


            bool isValid = Regex.IsMatch(pictureUrl, pattern);
            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isExerciseTypeValid(string type) 
        {
            if (type != "Arm" && type != "Chest" && type != "Shoulder" && type != "Back" && type != "Core" && type != "Legs" && type != "Neck")
            {
                return false;
            }
            return true;
        }

    }
}
