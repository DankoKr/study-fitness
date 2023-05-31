using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.TestDataClasses;

namespace TestProject
{
    [TestClass]
    public class TestCardioAdministration
    {
        private int currentPage = 1;
        private const int pageSize = 8;
        private bool hasRows = true;

        [TestMethod]
        public void LoadCardiosFromDatabaseTest()
        {
			//Arrange
            CardioAdministration myManager;
			ICardioDAL testCardioDAL = new TestCardioDAL();
			myManager = new CardioAdministration(testCardioDAL);

			//Act		(currently 3 cardios in fake database)	
			testCardioDAL.LoadCardios(myManager, currentPage, pageSize, hasRows);

			//Assert
			Assert.AreEqual(3, myManager.GetCardios().Count());
		}

		[TestMethod]
		public void CreateCardioTest()
		{
			//Arrange
			CardioAdministration myManager;
			ICardioDAL testCardioDAL = new TestCardioDAL();
			myManager = new CardioAdministration(testCardioDAL);


			//Act			
			myManager.CreateCardio("Cardio1", 200, "Beginner", "picture1");

			//Assert
			Assert.AreEqual(1, myManager.GetCardios().Count());
		}

		[TestMethod]
		public void AddDublicateCardioTest()
		{
			//Arrange
			CardioAdministration myManager;
			ICardioDAL testCardioDAL = new TestCardioDAL();
			myManager = new CardioAdministration(testCardioDAL);
			myManager.CreateCardio("Cardio1", 200, "Beginner", "picture1");


			//Act			
			myManager.CreateCardio("Cardio1", 200, "Beginner", "picture1");

			//Assert
			Assert.AreEqual(1, myManager.GetCardios().Count());
		}

		[TestMethod]
		public void RemoveCardioTest()
		{
			//Arrange
			CardioAdministration myManager;
			ICardioDAL testCardioDAL = new TestCardioDAL();
			myManager = new CardioAdministration(testCardioDAL);
			myManager.CreateCardio("Cardio1", 200, "Beginner", "picture1");


			//Act			
			myManager.RemoveCardio("Cardio1");

			//Assert
			Assert.AreEqual(0, myManager.GetCardios().Count());
		}


		[TestMethod]
		public void EditCardioTest()
		{
			//Arrange
			CardioAdministration myManager;
			ICardioDAL testCardioDAL = new TestCardioDAL();
			myManager = new CardioAdministration(testCardioDAL);
			myManager.CreateCardio("Cardio",200, "Beginner", "picture1");
			Cardio oldCardio = myManager.GetCardio("Cardio");

			//Act		
			myManager.EditCardioData(oldCardio, 100, "Intermediate", "newPicture");


			//Assert
			Assert.AreNotEqual("Beginner", oldCardio.Difficulty);
		}

		[TestMethod]
		public void CheckExerciseUniqueTest()
		{
		 //Arrange
			CardioAdministration myManager;
			ICardioDAL testCardioDAL = new TestCardioDAL();
			myManager = new CardioAdministration(testCardioDAL);
			testCardioDAL.LoadCardios(myManager, currentPage, pageSize, hasRows);
			Cardio uniqueC = new Cardio("Unique", 243, "Beginner", "pictureUrl");

			//Act		
			bool isUnique = myManager.ValidateCardioIsUnique(uniqueC.Name);


			//Assert
			Assert.IsTrue(isUnique);
		}
	}
}