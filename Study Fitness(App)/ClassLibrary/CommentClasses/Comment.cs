using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CommentClasses
{
    public class Comment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }

        public Comment(string title, string description, int rating)
        {
            Title = title;
            Description = description;
            Rating = rating;
        }

        public string GetInfo()
        {
            return $"Rating: {Rating}/5. Description: {Description}";
        }
    }
}
