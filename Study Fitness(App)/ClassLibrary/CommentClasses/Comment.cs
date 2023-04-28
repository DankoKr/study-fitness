using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CommentClasses
{
    public class Comment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        [Range(0, 5, ErrorMessage = "Please supply a rating between 0 and 5")]
        public int Rating { get; set; }

        public Comment(string title, string description, int rating)
        {
            Title = title;
            Description = description;
            Rating = rating;
        }

        public Comment() { } 

        public string GetInfo()
        {
            return $"Rating: {Rating}/5. Description: {Description}";
        }
    }
}
