using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Question
{
    public class Question
    {
        public string QuestionText { get; set; }

        public Question()
        {

        }

        public Question (string questionText)
        {
            QuestionText = questionText;
        }
    }
}
