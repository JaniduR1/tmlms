using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Question
{
    public class MultipleChoiceQ : Question
    {
        public string Questions { get; set; }

        public List<string> Answers { get; set; }
        
        public MultipleChoiceQ(string question, List<string> answers) : base(question)
        {
            Questions = question;
            Answers = answers;
        }


        public MultipleChoiceQ()
        {
            
        }



    }
}
