using ClassLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseClasses
{
	public interface IUserDAL
	{
		void LoadUsers(UserAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows);
		void DeleteUser(User u);
		void EditUser(User u, string name);
		bool CreateUser(User u);
		void GetUserByUsername(UserAdministration myManager, string username);
		void EditUserFirstName(User u, string newFirstName);
		bool CheckLogin(string username, string password);
		string GetSalt(string username);
		void GetTrainerNameByPoints(int points, List<string> trainers);
		void SetTrainerLevel(string trainerUsername, int level);
		int UserId(string username);
        bool IsUnique(string name);
    }
}
