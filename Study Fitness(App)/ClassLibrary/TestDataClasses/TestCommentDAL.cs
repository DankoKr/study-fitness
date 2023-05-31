using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.TestDataClasses
{
    public class TestCommentDAL : ICommentDAL
    {
        List<Comment> comments = new List<Comment>();

        public void AddCommentCardio(Comment c, int userId, int cId)
        {
            comments.Add(c);
        }

        public void AddCommentExercise(Comment c, int userId, int exId)
        {
            comments.Add(c);
        }

        public void DeleteComment(Comment c)
        {
            comments.Remove(c);
        }

        public void EditComment(Comment c, string description, int rating)
        {
            c.Description = description;
            c.Rating = rating;
        }

        public int GetCardioId(string nameCardio, int cId)
        {
            throw new NotImplementedException();
        }

        public Comment GetComment(string title)
        {
            foreach (Comment comment in comments)
            {
                if (title == comment.Title)
                {
                    return comment;
                }
            }
            return null;
        }

        public Comment GetComment(string title, Comment c)
        {
            foreach (Comment comment in comments)
            {
                if (title == comment.Title)
                {
                    c = comment;
                    return c;
                }
            }
            return c;
        }

        public int GetCommentsByRating(int rating)
        {
            throw new NotImplementedException();
        }

        public void GetExerciseComments(int exercise_id, CommentAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows)
        {
            throw new NotImplementedException();
        }

        public int GetExerciseId(string nameEx, int exId)
        {
            throw new NotImplementedException();
        }

        public void GetUserComments(int user_id, CommentAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows)
        {
            throw new NotImplementedException();
        }

        public int GetUserId(string username, int userId)
        {
            throw new NotImplementedException();
        }

        public void LoadComments(CommentAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows)
        {
            Comment c1 = new Comment("Com1", "desc1", 1);
            Comment c2 = new Comment("Com2", "desc2", 2);
            comments.Add(c1);
            comments.Add(c2);
            myManager.AddExistingComment(c1);
            myManager.AddExistingComment(c2);
        }

    }
}
