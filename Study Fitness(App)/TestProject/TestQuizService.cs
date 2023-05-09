using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;

namespace TestProject
{
    [TestClass]
    public class TestQuizService
    {
        [TestMethod]
        public void LoadCardiosFromDatabaseTest()
        {
			//Arrange
            CardioAdministration myManager;
			ICardioDAL testCardioDAL = new TestCardioDAL();
			myManager = new CardioAdministration(testCardioDAL);

			//Act		(currently 3 cardios in fake database)	
			testCardioDAL.LoadCardios(myManager);

			//Assert
			Assert.AreEqual(3, myManager.GetCardios().Count());
		}

	}
}