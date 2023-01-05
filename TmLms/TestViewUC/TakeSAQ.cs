using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TmLms.Question;


namespace TmLms.TestViewUC
{
    public partial class TakeSAQ : UserControl
    {
        ShortAnswerQ saq;
        List<string> studentAnswer = new List<string>();
        string quizId;
        string moduleId;
        string studentIndex;
        public TakeSAQ(Question.Question q, string quizId, string moduleId, string studentIndex)
        {
            InitializeComponent();
            saq = q as ShortAnswerQ;
            setData();
            this.quizId = quizId;
            this.moduleId = moduleId;
            this.studentIndex = studentIndex;
        }

        private void setData()
        {
            this.questionLbl.Text = saq.GetQuestion();
        }

        private void submitAnsBtn_Click(object sender, EventArgs e)
        {
            StudentAnswers sa = new StudentAnswers();
            sa.AnswerId = moduleId + quizId + saq.QuestionId + "O_o" + studentIndex;
            sa.StudentAnswer = this.studentAnswer;
            if (TMEngine.Instance.AnswerDictionary.ContainsKey(sa.AnswerId))
            {
                sa.UpdateAnswer(sa);
            }
            else
            {
                sa.SaveAnswer(sa);
            }
        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {
            studentAnswer.Clear();
            studentAnswer.Add(answerTextBox.Text);
        }
    }
}
