using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using ClassLibrary.TestDataClasses;
using ClassLibrary.UserClasses;

namespace TestProject
{
    [TestClass]
    public class TestExerciseAdministration
    {
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows = true;

        [TestMethod]
        public void LoadUsersFromDatabaseTest()
        {
			//Arrange
            ExerciseAdministration myManager;
			IExerciseDAL testExerciseDAL = new TestExerciseDAL();
			myManager = new ExerciseAdministration(testExerciseDAL);

			//Act		(currently 7 exercises in fake database)	
			testExerciseDAL.LoadExercises(myManager, currentPage, pageSize, hasRows);

			//Assert
			Assert.AreEqual(7, myManager.GetExercises().Count());
		}

		[TestMethod]
		public void CreateExerciseTest()
		{
			//Arrange
			ExerciseAdministration myManager;
			IExerciseDAL testExerciseDAL = new TestExerciseDAL();
			myManager = new ExerciseAdministration(testExerciseDAL);

			//Act		
			myManager.CreateExercise("Neck", "Test", "Beginner", "Yes", 5, 10, "Biceps", "https://th.bing.com/th/id/OIP.3MDxaU5izP9WJ-cRICZYhgHaHa?pid=ImgDet&rs=1");

			//Assert
			Assert.AreEqual(1, myManager.GetExercises().Count());
		}

		[TestMethod]
		public void AddDublicateExerciseTest()
		{
			//Arrange
			ExerciseAdministration myManager;
			IExerciseDAL testExerciseDAL = new TestExerciseDAL();
			myManager = new ExerciseAdministration(testExerciseDAL);
			testExerciseDAL.LoadExercises(myManager, currentPage, pageSize, hasRows);

			//Act		(currently 7 exercises in fake database)
			myManager.CreateExercise("Arm", "Curls", "Beginner", "Yes", 5, 10, "Biceps", "picture");

			//Assert
			Assert.AreNotEqual(8, myManager.GetExercises().Count());
		}

		[TestMethod]
		public void RemoveExerciseTest()
		{
			//Arrange
			ExerciseAdministration myManager;
			IExerciseDAL testExerciseDAL = new TestExerciseDAL();
			myManager = new ExerciseAdministration(testExerciseDAL);
			testExerciseDAL.LoadExercises(myManager, currentPage, pageSize, hasRows);

			//Act		(currently 7 exercises in fake database)
			myManager.RemoveExercise("Curls");

			//Assert
			Assert.AreNotEqual(7, myManager.GetExercises().Count());
		}

		[TestMethod]
		public void EditExerciseTest()
		{
			//Arrange
			ExerciseAdministration myManager;
			IExerciseDAL testExerciseDAL = new TestExerciseDAL();
			myManager = new ExerciseAdministration(testExerciseDAL);
			testExerciseDAL.LoadExercises(myManager, currentPage, pageSize, hasRows);
			myManager.CreateExercise("Neck", "Test", "Beginner", "Yes", 5, 10, "Biceps", "https://th.bing.com/th/id/OIP.3MDxaU5izP9WJ-cRICZYhgHaHa?pid=ImgDet&rs=1");

			//Act		
			myManager.EditExercise("Test", 1, 1, "Intermediate");
			Exercise editedEx = myManager.GetExercise("Test");

			//Assert
			Assert.AreNotEqual(5, editedEx.RepRange);
		}

		[TestMethod]
		public void ValidExercisePictureURLTest()
		{
			//Arrange
			ExerciseAdministration myManager;
			IExerciseDAL testExerciseDAL = new TestExerciseDAL();
			myManager = new ExerciseAdministration(testExerciseDAL);
			Exercise ex = new BackExercise("Pullup", "Advanced", "No", 5, 50, "Upper back", "picture");

			//Act		
			bool isValid = myManager.IsPictureValid(ex.PictureUrl);

			//Assert
			Assert.IsFalse(isValid);
		}

		[TestMethod]
		public void GetExerciseTest()
		{
			//Arrange
			Exercise ex;
			ExerciseAdministration myManager;
			IExerciseDAL testExerciseDAL = new TestExerciseDAL();
			myManager = new ExerciseAdministration(testExerciseDAL);
			testExerciseDAL.LoadExercises(myManager, currentPage, pageSize, hasRows);

			//Act		there is an ex called "Curls" in the database
			ex = myManager.GetExercise("Curls");

			//Assert
			Assert.IsNotNull(ex);
		}

		[TestMethod]
		public void ExerciseExistsTest()
		{
			//Arrange
			Exercise ex;
			ExerciseAdministration myManager;
			IExerciseDAL testExerciseDAL = new TestExerciseDAL();
			myManager = new ExerciseAdministration(testExerciseDAL);
			testExerciseDAL.LoadExercises(myManager, currentPage, pageSize, hasRows);

			//Act		
			bool fakeEx = myManager.ExerciseExists("Not existing");

			//Assert
			Assert.IsFalse(fakeEx);
		}

		[TestMethod]
		public void ValidateExerciseIsUniqueTest()
		{
			//Arrange
			Exercise ex = new BackExercise("Test", "Advanced", "No", 5, 50, "Upper back", "https://th.bing.com/th/id/OIP.3MDxaU5izP9WJ-cRICZYhgHaHa?pid=ImgDet&rs=1");
			ExerciseAdministration myManager;
			IExerciseDAL testExerciseDAL = new TestExerciseDAL();
			myManager = new ExerciseAdministration(testExerciseDAL);
			testExerciseDAL.LoadExercises(myManager, currentPage, pageSize, hasRows);

			//Act		
			bool IsUnique = myManager.ValidateExerciseIsUnique("Test");

			//Assert
			Assert.IsTrue(IsUnique);
		}
	}
}