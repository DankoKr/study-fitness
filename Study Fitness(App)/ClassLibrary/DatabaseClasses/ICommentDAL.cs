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
        void AddComment(Comment c, int userId);
        public void DeleteComment(Comment c);
        public void EditComment(Comment c, string title, string description, int rating);
    }
}
