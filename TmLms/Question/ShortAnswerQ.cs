using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Question
{
    public class ShortAnswerQ : Question
    {
        public string SAQuestion
        {
            get;
            set;
        }

        public ShortAnswerQ(Quiz quiz, string SAQuestion)
        {
            this.quiz = quiz;
            this.SAQuestion = SAQuestion;
        }
    }
}
