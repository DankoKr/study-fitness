using ClassLibrary.CommentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseClasses
{
    public interface ICommentDAL
    {
        void LoadComments(CommentAdministration myManager);
        void AddCommentExercise(Comment c, int userId, int exId);
        void DeleteComment(Comment c);
        void EditComment(Comment c, string title, string description, int rating);
        int GetExerciseId(string nameEx, int exId);
        int GetUserId(string username, int userId);
        int GetCardioId(string nameCardio, int cId);
        void AddCommentCardio(Comment c, int userId, int cId);
    }
}
