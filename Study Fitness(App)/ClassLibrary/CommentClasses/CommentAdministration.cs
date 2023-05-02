using ClassLibrary.DatabaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CommentClasses
{
    public class CommentAdministration
    {
        List<Comment> comments = new List<Comment>();
        ICommentDAL db = new CommentDAL();
        public CommentAdministration(ICommentDAL db) 
        {
            this.db = db;
        }

        public void AddCommentExercise(Comment c, int userId, int exId)
        {
            if (c.Rating < 6 && c.Rating >= 0 && c.Title != "")
            {
                comments.Add(c);
                db.AddCommentExercise(c, userId, exId);
            }
        }

        public void AddCommentCardio(Comment c, int userId, int cId)
        {
            if (c.Rating < 6 && c.Rating >= 0 && c.Title != "")
            {
                comments.Add(c);
                db.AddCommentCardio(c, userId, cId);
            }
        }

        public void AddExistingComment(Comment c)
        {
            comments.Add(c);
        }

        public void RemoveComment(Comment c)
        {
            comments.Remove(c);
            db.DeleteComment(c);
        }

        public void EditComment(Comment c, string newTtile, string newDescription, int newRate)
        {
            if (newTtile != "" && newDescription != "" && newRate < 6)
            {
                db.EditComment(c, newTtile, newDescription, newRate);
                c.Description = newDescription;
                c.Title = newTtile;
                c.Rating = newRate;
            }
        }

        public Comment[] GetComments() { return comments.ToArray(); }
        public Comment GetComment(string title) 
        {
            foreach (Comment c in comments) 
            {
                if (c.Title == title)
                {
                    return c;
                }
            }
            return null;
        }
        public int GetExerciseId(string nameEx, int id) 
        {
            int exId = db.GetExerciseId(nameEx, id);
            return exId;
        }
        public int GetCardioId(string nameCardio, int id)
        {
            int exId = db.GetCardioId(nameCardio, id);
            return exId;
        }
    }
}
