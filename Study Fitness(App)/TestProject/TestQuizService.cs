using ClassLibrary.CardioClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.QuizClasses;

namespace TestProject
{
    [TestClass]
    public class TestQuizService
    {
        private QuizService quizService = new QuizService();

        [TestMethod]
        public void GetQuestionsQuestions()
        {
            var questions = quizService.GetQuestions();
            Assert.AreEqual(5, questions.Count);
        }

        [TestMethod]
        public void CalculatePointsWhenNoQuestionsAreAnswered()
        {
            // Arrange
            QuizService quizService = new QuizService();
            IList<int> emptyUserAnswers = new List<int>();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => quizService.CalculatePoints(emptyUserAnswers), "Empty list of user answers is not allowed.");
        }

        [TestMethod]
        public void CalculatePointsWhenAllQuestionsAreAnswered()
        {
            var userAnswers = new List<int> { 0, 0, 0, 0, 0 };
            var points = quizService.CalculatePoints(userAnswers);
            Assert.AreEqual(5, points);
        }

        [TestMethod]
        public void CalculatePointsWhenZeroPoints()
        {
            var trainers = quizService.GetTrainer(0);
            Assert.IsTrue(trainers.Contains("level0"));
        }

        [TestMethod]
        public void GetTrainerWhenPointsAreBetweenOneAndTwo()
        {
            var trainers = quizService.GetTrainer(1);
            Assert.IsTrue(trainers.Contains("level1"));
        }

        [TestMethod]
        public void GetTrainerWhenPointsAreThreeOrMore()
        {
            var trainers = quizService.GetTrainer(2);
            Assert.IsTrue(!string.IsNullOrEmpty(trainers));
        }

    }
}