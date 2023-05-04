using ClassLibrary;
using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Website.Models;

namespace Website.Pages.MyPages
{
    public class ExerciseDetailscshtmlModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        public ExerciseAdministration myManager;
        public Exercise? selectedEx { get; set; }
		IExerciseDAL db = new ExerciseDAL();
        public CommentAdministration myComments;
        ICommentDAL comments = new CommentDAL();

		public void OnGet(string name)
        {
            myManager = new ExerciseAdministration(db);
            db.LoadExercises(myManager);
            selectedEx = myManager.GetExercise(name);
            myComments = new CommentAdministration(comments);
            int id = 0;
            int exId = comments.GetExerciseId(selectedEx.Name, id);
            comments.GetExerciseComments(exId, myComments);
        }

    }
}
