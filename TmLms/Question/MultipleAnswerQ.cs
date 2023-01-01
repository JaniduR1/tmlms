using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Question
{
    public class MultipleAnswerQ : Question
    {
        List<string> GivenAnswerSet;
        public MultipleAnswerQ(string question, List<string> answer, List<string> givenAnswerSet) : base(question, answer)
        {
            GivenAnswerSet = givenAnswerSet;
        }
    }
}

