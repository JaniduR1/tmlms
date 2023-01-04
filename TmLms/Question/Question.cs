using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Question
{
    public class Question
    {
        public Quiz quiz { get; set; }
        public int QuestionId { get => questionid; set => questionid = value; }

        string question;
        List<string> answer;
        int questionid;


        public Question(string question, List<string> answer)
        {
            this.question = question;
            this.answer = answer;
        }

        public string GetQuestion()
        {
            return question;
        }

        public List<string> GetAnswer()
        {
            return answer;
        }
        public void AddQuestion(Question question)
        {
            //int id = 0;
            questionid = 0;

            foreach(Question q in TmLms.TMEngine.Instance.QuestionDictionary.Values)
            {
                questionid += 1;
                question.questionid = questionid;
            }

            TmLms.Program.tmEngine.QuestionDictionary.Add(questionid, question);
        }
    }
}
