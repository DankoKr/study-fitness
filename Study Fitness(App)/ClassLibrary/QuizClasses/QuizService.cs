using ClassLibrary.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.QuizClasses
{
    public class QuizService
    {
        private readonly List<Question> questions = new List<Question>
        {
            new Question { Text = "Do you train more than twice a week?", Options = new[] { "Yes", "No" }, OptionPointsIndex = 0 },
            new Question { Text = "Do you follow a diet?", Options = new[] { "Yes", "No" }, OptionPointsIndex = 0 },
            new Question { Text = "Any experience in the gym?", Options = new[] { "Yes", "No" }, OptionPointsIndex = 0 },
            new Question { Text = "Any allergies?", Options = new[] { "Yes", "No" }, OptionPointsIndex = 0 },
            new Question { Text = "Any injuries??", Options = new[] { "Yes", "No" }, OptionPointsIndex = 0 }
        };

        public IReadOnlyList<Question> GetQuestions()
        {
            return questions.AsReadOnly();
        }

        public int CalculatePoints(IList<int> userAnswers)
        {
            int points = 0;

            for (int i = 0; i < questions.Count; i++)
            {
                if (userAnswers[i] == questions[i].OptionPointsIndex)
                {
                    points++;
                }
            }

            return points;
        }

        public string GetTrainer(int points)
        {
            IUserDAL db = new UserDAL();
            List<string> trainers = new List<string>();

            int result = 0;

            switch (points)
            {
                case int n when (n >= 1 && n < 3):
                    result = 1;
                    break;
                case int n when (n < 0):
                    result = 0;
                    break;
                case int n when (n >= 3):
                    result = 2;
                    break;
            }

            db.GetTrainerNameByPoints(result, trainers);
            string trainersNames = "";
            foreach (string trainer in trainers) 
            {
                trainersNames += trainer + "\n";
            }

            return trainersNames;
        }
    }
}
