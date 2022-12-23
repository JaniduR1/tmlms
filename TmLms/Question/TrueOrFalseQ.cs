using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Question
{
    public class TrueOrFalseQ : Question
    {

        public string TFQuestion
        {
            get;
            set;
        }
        
        public bool Answer
        {
            get;
            set;
        }

        public TrueOrFalseQ(Quiz quiz, string TFQuestion, bool Answer)
        {
            this.quiz = quiz;
            this.TFQuestion = TFQuestion;
            this.Answer = Answer;
        }
    }
}
