using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms
{
    //class quiz
    //{
    //    List<Question> 
    //}


    //public static Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
    //public static MainScreen mainScreen = Application.OpenForms.OfType<MainScreen>().FirstOrDefault();
    public sealed class TMEngine
    {
        public Dictionary<string,TM.Course> CourseDictionary { get; set; }

        public Dictionary<string, TM.Module> ModuleDictionary { get; set; }

        //public Dictionary<Question.Question, Question.MultipleChoiceQ> MCQDictionary { get; set; }

        public Dictionary<int, Question.Question> QuestionDictionary { get; set; }

        public Dictionary<string, Question.Quiz> QuizDictionary { get; set; }

        public Dictionary<string, Question.StudentAnswers> AnswerDictionary { get; set; }




        private static readonly TMEngine instance = new TMEngine();

        static TMEngine()
        {
        }

        private TMEngine()
        {
            CourseDictionary = new Dictionary<string, TM.Course>();
            ModuleDictionary = new Dictionary<string, TM.Module>();
            QuestionDictionary = new Dictionary<int, Question.Question>();
            QuizDictionary = new Dictionary<string, Question.Quiz>();
            AnswerDictionary = new Dictionary<string, Question.StudentAnswers>();
        }

        public static TMEngine Instance
        {
            get
            {
                return instance;
            }
        }

    }
}
