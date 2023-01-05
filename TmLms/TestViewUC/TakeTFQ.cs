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
    public partial class TakeTFQ : UserControl
    {
        TrueOrFalseQ tfq;
        List<string> studentAnswer = new List<string>();
        string quizId;
        string moduleId;
        string studentIndex;
        public TakeTFQ(Question.Question q, string quizId, string moduleId, string studentIndex)
        {
            InitializeComponent();
            tfq = q as TrueOrFalseQ;
            setData();
            this.quizId = quizId;
            this.moduleId = moduleId;
            this.studentIndex = studentIndex;
        }

        private void setData()
        {
            this.questionLbl.Text = tfq.GetQuestion();
            this.trueRadioBtn.Text = "TRUE";
            this.falseRadioBtn.Text = "FALSE";
        }

        private void submitAnsBtn_Click(object sender, EventArgs e)
        {
            StudentAnswers sa = new StudentAnswers();
            sa.QuestionId = tfq.QuestionId;
            sa.AnswerId = moduleId + quizId + tfq.QuestionId + "O_o" + studentIndex;

            foreach (RadioButton rBtn in this.Controls.OfType<RadioButton>())
            {
                if (rBtn.Checked)
                {
                    studentAnswer.Add(rBtn.Text);
                }
            }
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
    }
}
