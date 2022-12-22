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

        private List<string> MultiChoices { get; set; }

        public MultipleChoiceQ(string question) : base(question)
        {
            Questions = question;
            MultiChoices = new List<string>();
        }

        public void AddChoice(string choice, bool isCorrect)
        {
            MultiChoices.Add(choice);

            if (isCorrect == true)
            {
                var indexOfCor = MultiChoices.IndexOf(choice);
                MultiChoices.Add(indexOfCor.ToString());
            }
        }
        public MultipleChoiceQ()
        {

        }
    }
}
