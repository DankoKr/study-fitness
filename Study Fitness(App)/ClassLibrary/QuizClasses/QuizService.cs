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
            new Question { Text = "Do you have knowledge about training?", Options = new[] { "Yes", "No" }, OptionPointsIndex = 0 },
            new Question { Text = "Do you follow a diet?", Options = new[] { "Yes", "No" }, OptionPointsIndex = 0 }
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

        public string GetPrize(int points)
        {
            return points switch
            {
                int p when p >= 3 => "Gold",
                int p when p >= 2 => "Silver",
                int p when p >= 1 => "Bronze",
                _ => "Better luck next time"
            };
        }
    }
}
