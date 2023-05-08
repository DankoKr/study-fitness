using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.QuizClasses
{
    public class Question
    {
        private string text;
        private int optionPointsIndex;
        private string[] options;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public string[] Options
        {
            get { return options; }
            set { options = value; }
        }

        public int OptionPointsIndex
        {
            get { return optionPointsIndex; }
            set { optionPointsIndex = value; }
        }
    }
}
