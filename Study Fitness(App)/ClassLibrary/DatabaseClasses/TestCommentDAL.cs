using ClassLibrary.CommentClasses;
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
        public void AddComment(Comment c, int userId)
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
