using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Question
{
    public class EssayQ : Question
    {
        public string EQuestion
        {
            get;
            set;
        }

        public EssayQ(Quiz quiz, string EQuestion)
        {
            this.quiz = quiz;
            this.EQuestion = EQuestion;
        }
    }
}
