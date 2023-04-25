﻿using ClassLibrary.CommentClasses;
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
        void DeleteComment(Comment c);
        void EditComment(Comment c, string title, string description, int rating);
    }
}
