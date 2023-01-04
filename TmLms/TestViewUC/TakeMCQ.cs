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
    public partial class TakeMCQ : UserControl
    {
        MultipleChoiceQ mcq;
        List<string> studentAnswer = new List<string>();
        string quizId;
        string moduleId;
        string studentIndex;

        public TakeMCQ(Question.Question q, string quizId, string moduleId, string studentIndex)
        {
            InitializeComponent();
            this.mcq = q as MultipleChoiceQ;
            setData();
            this.quizId = quizId;
            this.moduleId = moduleId;
            this.studentIndex = studentIndex;
        }

        private void setData()
        {
            //
            this.questionLbl.Text = mcq.GetQuestion();
            List<string> mixed = mcq.GetGivenAnswerSet().OrderBy(x => Guid.NewGuid()).ToList();
            int i = 0;
            foreach (RadioButton rBtn in this.Controls.OfType<RadioButton>())
            {
                rBtn.Text = mixed.ElementAt(i);
                i++;
            }

        }

        private void submitAnsBtn_Click(object sender, EventArgs e)
        {
            StudentAnswers sa = new StudentAnswers();
            sa.AnswerId = moduleId + quizId + mcq.QuestionId + studentIndex;
            foreach (RadioButton rBtn in this.Controls.OfType<RadioButton> ())
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
