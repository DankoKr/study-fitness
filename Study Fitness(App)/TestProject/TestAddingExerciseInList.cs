using ClassLibrary.ExerciseClasses;

namespace TestProject
{
    [TestClass]
    public class TestAddingExerciseInList
    {
        [TestMethod]
        public void TestMethod1()
        {
			//Arrange
            ExerciseAdministration myManager = new ExerciseAdministration();
			Exercise ex1 = new CoreExercise("Crunches", "Beginner", "No", 5, 50, "https://th.bing.com/th/id/R.09eb77625ee42fe2564230c81d8eb9c0?rik=6e7oIK79MLDHEA&pid=ImgRaw&r=0");


			//Act			
			myManager.AddExercise(ex1);

			//Assert
			Assert.IsNotNull(myManager);
        }
    }
}