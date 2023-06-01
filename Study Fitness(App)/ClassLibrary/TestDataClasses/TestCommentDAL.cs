using ClassLibrary.CardioClasses;
using ClassLibrary.CommentClasses;
using ClassLibrary.DatabaseClasses;
using ClassLibrary.ExerciseClasses;
using ClassLibrary.ScheduleClasses;
using ClassLibrary.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary.TestDataClasses
{
    public class TestCommentDAL : ICommentDAL
    {
        List<Comment> comments = new List<Comment>();
        List<User> users = new List<User>();
        List<Exercise> exercises = new List<Exercise>();
        List<Cardio> cardios = new List<Cardio>();

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
            foreach (Cardio c in cardios)
            {
                cId++;
                if (c.Name == nameCardio)
                {
                    return cId;
                }
            }
            return cId;
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
            int counter = 0;
            foreach (Comment comment in comments)
            {
                if (rating == comment.Rating)
                {
                    counter++;
                }
            }
            return counter;
        }

        public void GetExerciseComments(int exercise_id, CommentAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows)
        {//Cannot implement because this method requires real database
            throw new NotImplementedException();
        }

        public int GetExerciseId(string nameEx, int exId)
        {
            foreach (Exercise ex in exercises)
            {
                exId++;
                if (ex.Name == nameEx)
                {
                    return exId;
                }
            }
            return exId;
        }

        public void GetUserComments(int user_id, CommentAdministration myManager, int pageNumber, int pageSize, bool hasMoreRows)
        {//Cannot implement because this method requires real database
            throw new NotImplementedException();
        }

        public int GetUserId(string username, int userId)
        {
            foreach (User u in users)
            {
                userId++;
                if (u.Username == username)
                {
                    return userId;
                }
            }
            return userId;
        }

        public bool IsUnique(string name)
        {
            bool isUnique = true;
            foreach (Comment c in comments) 
            {
                if (c.Title == name)
                {
                    return isUnique = false;
                }
            }
            return isUnique;
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
