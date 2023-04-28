using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ExerciseClasses
{
    public interface IExerciseComparer
    {
        void SortExercises(List<Exercise> exercises);
        void SortExercisesByName(List<Exercise> exercises);
		void SortExercisesDescending(List<Exercise> exercises, Func<Exercise, IComparable> keySelector);
        //List<Exercise> GetExercisesByType(List<Exercise> exercises, string exerciseType);
    }
}

