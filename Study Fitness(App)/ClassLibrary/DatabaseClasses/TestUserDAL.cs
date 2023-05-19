using ClassLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseClasses
{
	public class TestUserDAL : IUserDAL
	{
		List<User> myUsers = new List<User>();
		public bool CheckLogin(string username, string password)
		{
			throw new NotImplementedException();
		}

		public bool CreateUser(User u)
		{
			myUsers.Add(u);
			return true;
		}

		public void DeleteUser(User u)
		{
			myUsers.Remove(u);
		}

		public void EditUser(User u, string username)
		{
			u.Username = username;
		}

		public void EditUserFirstName(User u, string newFirstName)
		{
			u.FirstName = newFirstName;
		}

		public string GetSalt(string username)
		{
			throw new NotImplementedException();
		}

        public void GetTrainerNameByPoints(int points, List<string> trainers)
        {
            throw new NotImplementedException();
        }

        public void GetUserByUsername(UserAdministration myManager, string username)
		{
			foreach (var user in myUsers) 
			{
				if (user.Username == username) 
				{
					myManager.AddExistingUser(user);
				}
			}
		}

		public void LoadUsers(UserAdministration myManager)
		{
			User u1 = new User("User1", "First", "1234", "Member");
			User u2 = new User("User2", "Second", "1234", "Admin");
			User u3 = new User("User3", "Third", "1234", "Member");
			myUsers.Add(u1);
			myUsers.Add(u2);
			myUsers.Add(u3);
			myManager.AddExistingUser(u1);
			myManager.AddExistingUser(u2);
			myManager.AddExistingUser(u3);
		}

        public void SetTrainerLevel(string trainerUsername, int level)
        {
            throw new NotImplementedException();
        }

        public int UserId(string username)
        {
            throw new NotImplementedException();
        }
    }
}
