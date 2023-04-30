﻿using ClassLibrary.CommentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DatabaseClasses
{
    public class TestCommentDAL : ICommentDAL
    {
        List<Comment> comments = new List<Comment>();

        public void AddCommentCardio(Comment c, int userId, int cId)
        {
            throw new NotImplementedException();
        }

        public void AddCommentExercise(Comment c, int userId, int exId)
        {
            comments.Add(c);
        }

        public void DeleteComment(Comment c)
        {
            comments.Remove(c);
        }

        public void EditComment(Comment c, string title, string description, int rating)
        {
            c.Title = title;
            c.Description = description;
            c.Rating = rating;
        }

        public int GetCardioId(string nameCardio, int cId)
        {
            throw new NotImplementedException();
        }

        public Comment GetComment(string title)
        {
            throw new NotImplementedException();
        }

        public Comment GetComment(string title, Comment c)
        {
            throw new NotImplementedException();
        }

        public void GetExerciseComments(int exercise_id, CommentAdministration myManager)
        {
            throw new NotImplementedException();
        }

        public int GetExerciseId(string nameEx, int exId)
        {
            throw new NotImplementedException();
        }

        public void GetUserComments(int user_id, CommentAdministration myManager)
        {
            throw new NotImplementedException();
        }

        public int GetUserId(string username, int userId)
        {
            throw new NotImplementedException();
        }

        public void LoadComments(CommentAdministration myManager)
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
