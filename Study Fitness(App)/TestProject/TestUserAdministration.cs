using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using ClassLibrary.TestDataClasses;
using ClassLibrary.UserClasses;

namespace TestProject
{
    [TestClass]
    public class TestUserAdministration
    {
        private int currentPage = 1;
        private const int pageSize = 20;
        private bool hasRows;

        [TestMethod]
        public void LoadUsersFromDatabaseTest()
        {
			//Arrange
            UserAdministration myManager;
			IUserDAL testUserDAL = new TestUserDAL();
			myManager = new UserAdministration(testUserDAL);

			//Act		(currently 3 cardios in fake database)	
			testUserDAL.LoadUsers(myManager, currentPage, pageSize, hasRows);

			//Assert
			Assert.AreEqual(3, myManager.GetUsers().Count());
		}

		[TestMethod]
		public void AddUser()
		{
			//Arrange
			UserAdministration myManager;
			IUserDAL testUserDAL = new TestUserDAL();
			myManager = new UserAdministration(testUserDAL);
			User u4 = new User("User4", "Forth", "1234", "Member");
			testUserDAL.LoadUsers(myManager, currentPage, pageSize, hasRows);

			//Act		(currently 3 cardios in fake database)	
			myManager.AddUser(u4);

			//Assert
			Assert.AreEqual(4, myManager.GetUsers().Count());
		}

		[TestMethod]
		public void AddDublicatedUser()
		{
			//Arrange
			UserAdministration myManager;
			IUserDAL testUserDAL = new TestUserDAL();
			myManager = new UserAdministration(testUserDAL);
			User dublicatedUser = new User("User3", "Third", "1234", "Member");
			testUserDAL.LoadUsers(myManager, currentPage, pageSize, hasRows);

			//Act		(currently 3 cardios in fake database)	
			myManager.AddUser(dublicatedUser);

			//Assert
			Assert.AreEqual(3, myManager.GetUsers().Count());
		}

		[TestMethod]
		public void DeleteUser()
		{
			//Arrange
			IUserDAL testUserDAL = new TestUserDAL();
			UserAdministration myManager = new UserAdministration(testUserDAL);
			User u1 = new User("User1", "First", "1234", "Member");
			myManager.AddUser(u1);
			User selectedUser = myManager.GetUser(u1.Username);

			//Act		
			myManager.DeleteUser(selectedUser);

			//Assert
			Assert.AreEqual(0, myManager.GetUsers().Count());
		}

		[TestMethod]
		public void TestUniqueUser()
		{
			//Arrange
			UserAdministration myManager;
			IUserDAL testUserDAL = new TestUserDAL();
			myManager = new UserAdministration(testUserDAL);
			testUserDAL.LoadUsers(myManager, currentPage, pageSize, hasRows);
			User uniqueUser = new User("Unique", "Fifth", "1234", "Member");

			//Act			
			bool isUnique = myManager.ValidateUserIsUnique(uniqueUser.Username);

			//Assert
			Assert.IsTrue(isUnique);
		}

		[TestMethod]
		public void TestGetUser()
		{
			//Arrange			
			IUserDAL testUserDAL = new TestUserDAL();
			UserAdministration myManager = new UserAdministration(testUserDAL);
			testUserDAL.LoadUsers(myManager, currentPage, pageSize, hasRows);

			//Act			
			User user = myManager.GetUser("First");

			//Assert
			Assert.IsNotNull(user);
		}

		[TestMethod]
		public void ChangeFirstNameUser()
		{
			//Arrange
			UserAdministration myManager;
			IUserDAL testUserDAL = new TestUserDAL();
			myManager = new UserAdministration(testUserDAL);
			User user = new User("Bob", "Bill", "1234", "Member");
			myManager.AddUser(user);

			//Act			
			myManager.ChangeFirstName(user, "John");

			//Assert
			Assert.AreNotEqual("Bob", user.FirstName);
		}

		[TestMethod]
		public void ChangeUsernameUser()
		{
			//Arrange
			UserAdministration myManager;
			IUserDAL testUserDAL = new TestUserDAL();
			myManager = new UserAdministration(testUserDAL);
			User user = new User("Bob", "Bill", "1234", "Member");
			myManager.AddUser(user);

			//Act			
			myManager.ChangeUsername(user, "John");

			//Assert
			Assert.AreNotEqual("Bill", user.Username);
		}
	}
}