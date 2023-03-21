using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary.ExerciseClasses
{
    public class CardioAdministration : IAdministration
    {
        List<Cardio> myCardios = new List<Cardio>();
        public CardioAdministration() { }

        public void AddCardio(string name, int calories, string difficulty, string picture) 
        {
            Cardio cardio = new Cardio(name, calories, difficulty, picture);
            if (ValidateExerciseIsUnique(cardio.Name))
            {
                myCardios.Add(cardio);
            }
        }

        public bool ValidateExerciseIsUnique(string name) 
        {
            foreach (Cardio cardio in myCardios)
            {
                if (cardio.Name == name)
                {
                    return false;
                }
            }
            return true;
        }

        public bool ExerciseExists(string name) 
        {
            if (ValidateExerciseIsUnique(name))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void RemoveExercise(string name) 
        {
            if (ExerciseExists(name))
            {
                myCardios.Remove(GetCardio(name));
            }
        }

        public Cardio GetCardio(string name)
        {
            foreach (Cardio cardio in myCardios)
            {
                if (name == cardio.Name)
                {
                    return cardio;
                }
            }
            return null;
        }

    }
}
