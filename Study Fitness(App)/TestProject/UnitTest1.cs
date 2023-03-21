using ClassLibrary.ExerciseClasses;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Exercise ex1 = new ChestExercise("Pushup", "Beginner", "No", 5, 50.5, "Upper chest", "picture");
            Exercise ex2 = new ShoulderExercise("Vikingpress", "Advanced", "Yes", 7, 30, "Upper head", "picture");
            Exercise ex3 = new NeckExercise("Strech", "Beginner", "No", 10, 0, "picture");
            Exercise ex4 = new LegsExercise("Squats", "Athlete", "Yes", 6, 50.8, "Both chest", "picture");
            Exercise ex5 = new ArmExercise("Curls", "Beginner", "Yes", 5, 10, "Biceps", "picture");
            Exercise ex6 = new BackExercise("Pullup", "Advanced", "No", 5, 50, "Upper back", "picture");
            Exercise ex7 = new CoreExercise("Crunches", "Beginner", "No", 5, 50, "picture");
            Cardio ex8 = new Cardio("Running", 200, "Beginner", "picture");


            //Act
            double weight = ex1.Weight;
            string difficulty = ex8.Difficulty;


            //Assert
            Assert.AreEqual("Beginner", difficulty);
        }
    }
}