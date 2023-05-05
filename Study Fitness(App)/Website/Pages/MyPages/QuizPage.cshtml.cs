using ClassLibrary.QuizClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Website.Pages.MyPages
{
    public class PageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly QuizService _quizService;
        [BindProperty]
        public IList<int> QuestionResponses { get; set; }

        public PageModel()
        {
            _quizService = new QuizService();
        }

        public IReadOnlyList<Question> Questions { get; private set; }

        public int? Points { get; private set; }

        public string TrainerName { get; private set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Questions = _quizService.GetQuestions();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Questions = _quizService.GetQuestions();

            if (QuestionResponses == null || QuestionResponses.Count != Questions.Count)
            {
                return Page();
            }

            Points = _quizService.CalculatePoints(QuestionResponses);
            TrainerName = _quizService.GetTrainer(Points.Value);

            return Page();
        }
    }
}
