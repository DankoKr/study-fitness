using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ExerciseClasses
{
    interface IAdministration
    {
        bool ValidateExerciseIsUnique(string name);
        bool ExerciseExists(string name);
        void RemoveExercise(string name);
    }
}
