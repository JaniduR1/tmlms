using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Question
{
    public class StudentAnswers
    {
        string answerId;
        List<string> studentAnswer;
        string instructorFeedback;

        public string AnswerId 
        { 
            get => answerId; 
            set => answerId = value; 
        }
        public List<string> StudentAnswer 
        { 
            get => studentAnswer; 
            set => studentAnswer = value; 
        }
        public string InstructorFeedback 
        { 
            get => instructorFeedback; 
            set => instructorFeedback = value; 
        }

        public void SaveAnswer(StudentAnswers studentA)
        {
            TMEngine.Instance.AnswerDictionary.Add(studentA.answerId, studentA);
        }

        public void UpdateAnswer(StudentAnswers studentA)
        {
            TMEngine.Instance.AnswerDictionary.Remove(studentA.answerId);
            TMEngine.Instance.AnswerDictionary.Add(studentA.answerId, studentA);
        }
    }
}
