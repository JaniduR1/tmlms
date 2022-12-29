using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.TM
{
    public class Test
    {
        List<Question.Question> questionList = new List<Question.Question>();
        string testCode;
        string moduleCode;

        public void addQuestions(Question.Question q)
        {
            questionList.Add(q);
        }

        public List<Question.Question> getQuestions()
        {
            return questionList;
        }
    }
}
