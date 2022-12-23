using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Question
{
    public class MultipleAnswerQ : Question
    {

        public string MAQuestion
        {
            get;
            set;
        }

        public List<string> Answers
        {
            get;
            set;
        }

        public List<string> CorrectAnswers
        {
            get;
            set;
        }


        public MultipleAnswerQ(Quiz quiz, string MAQuestion, List<string> Answers, List<string> CorrectAnswers)
        {
            this.quiz = quiz;
            this.MAQuestion = MAQuestion;
            this.Answers = Answers;
            this.CorrectAnswers = CorrectAnswers;
        }
    }
}
