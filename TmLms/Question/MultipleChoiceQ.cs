using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Question
{
    public class MultipleChoiceQ : Question
    { 
        public string MCQuestion
        {
            get;
            set;
        }
        public string CAnswer
        {
            get;
            set;
        }

        public List<string> FAnswers
        {
            get;
            set;
        }

        public MultipleChoiceQ(Quiz quiz, string MCQuestion, string CAnswer, List<string>FAnswers)
        {
            this.quiz = quiz;
            this.MCQuestion = MCQuestion;
            this.CAnswer = CAnswer;
            this.FAnswers = FAnswers;
        }
    }
}
