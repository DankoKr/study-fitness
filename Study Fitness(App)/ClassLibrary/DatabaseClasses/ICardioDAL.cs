using ClassLibrary.CardioClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ClassLibrary.DatabaseClasses
{
    public interface ICardioDAL
	{
		void AddCardio(Cardio c);
		void DeleteCardio(Cardio c);
		void EditCardio(Cardio c, string name, string difficulty, int calories, string picture);
		void LoadCardios(CardioAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows);
		int CardioId(string name);
        bool isUnique(string name);
    }
}
