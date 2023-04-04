using ClassLibrary.ExerciseClasses;

namespace TestProject
{
    [TestClass]
    public class TestUniqueExercise
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            ExerciseAdministration myManager = new ExerciseAdministration();            
            Exercise ex1 = new ChestExercise("Diamond Pushup", "Intermediate", "No", 5, 50.5, "Middle chest", "https://th.bing.com/th/id/OIP.TqVyp3bwkr8CrPCK6MjbkwHaHa?pid=ImgDet&rs=1");
			myManager.AddExercise(ex1);



			//Act - Create the same exercise
			Exercise ex2 = new ChestExercise("Diamond Pushup", "Intermediate", "No", 5, 50.5, "Middle chest", "https://th.bing.com/th/id/OIP.TqVyp3bwkr8CrPCK6MjbkwHaHa?pid=ImgDet&rs=1");



			//Assert - check if it is unique
			Assert.IsFalse(myManager.ValidateExerciseIsUnique(ex2.Name)) ;
        }
    }
}