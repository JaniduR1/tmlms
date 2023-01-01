using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Question
{
    public class ShortAnswerQ : Question
    {
        public ShortAnswerQ(string question, List<string> answer) : base(question, answer)
        {
        }
    }
}
