using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmLms.TM;

namespace TmLms.Question
{
    public class Quiz
    {
        TM.Module module;
        List<Question> questionList = new List<Question>();

        public string quizCode { get; set; }

        public Quiz(TM.Module module, string quizCode)
        {
            this.module = module;
            this.quizCode = quizCode;
        }

        public void saveQuiz(Quiz q)
        {
            TMEngine.Instance.QuizDictionary.Add(quizCode, q);
        }

        public void addQuestionList(Question q)
        {
            if (!questionList.Contains(q))
            {
                questionList.Add(q);
            }
        }
    }
}
