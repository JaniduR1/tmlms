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
    
    public partial class TakeMAQ : UserControl
    {
        MultipleAnswerQ maq;
        List<string> studentAnswer = new List<string>();
        string quizId;
        string moduleId;
        string studentIndex;
        public TakeMAQ(Question.Question q, string quizId, string moduleId, string studentIndex)
        {
            InitializeComponent();
            maq = q as MultipleAnswerQ;
            setData();
            this.quizId = quizId;
            this.moduleId = moduleId;
            this.studentIndex = studentIndex;
        }

        private void setData()
        {
            this.questionLbl.Text = maq.GetQuestion();
            List<string> mixed = maq.GetGivenAnswerSet().OrderBy(x => Guid.NewGuid()).ToList();
            int i = 0;
            foreach (CheckBox chkBox in this.Controls.OfType<CheckBox>())
            {
                chkBox.Text = mixed.ElementAt(i);
                i++;
            }
        }

        private void submitAnsBtn_Click(object sender, EventArgs e)
        {
            StudentAnswers sa = new StudentAnswers();
            sa.AnswerId = moduleId + quizId + maq.QuestionId + "O_o" + studentIndex;
            foreach (CheckBox checkBox in this.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    studentAnswer.Add(checkBox.Text);
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
