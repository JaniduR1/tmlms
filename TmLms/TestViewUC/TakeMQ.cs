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
    public partial class TakeMQ : UserControl
    {
        MatchingQ mq;
        List<string> studentAns = new List<string>();
        string quizId;
        string moduleId;
        string studentIndex;

        public TakeMQ(Question.Question q, string quizId, string moduleId, string studentIndex)
        {
            InitializeComponent();
            mq = q as MatchingQ;
            this.quizId = quizId;
            this.moduleId = moduleId;
            this.studentIndex = studentIndex;
            SetData();
        }

        private void SetData()
        {
            this.questionLbl.Text = mq.GetQuestion();

            foreach(ComboBox cmbox in LeftPanel.Controls.OfType<ComboBox>())
            {
                cmbox.Items.Clear();
                var randomList = mq.GetLeft().OrderBy(x => Guid.NewGuid()).ToList();
                foreach (string s in randomList)
                {
                    cmbox.Items.Add(s);
                }
            }
            foreach (ComboBox cmbox in RightPanel.Controls.OfType<ComboBox>())
            {
                cmbox.Items.Clear();
                var randomList = mq.GetRight().OrderBy(x => Guid.NewGuid()).ToList();
                foreach (string s in randomList)
                {
                    cmbox.Items.Add(s);
                }
            }


        }

        private void submitAnsBtn_Click(object sender, EventArgs e)
        {
            StudentAnswers sa = new StudentAnswers();
            sa.AnswerId = moduleId + quizId + mq.QuestionId + "O_o" + studentIndex;

            studentAns.Add(left1ComboBox.Text + right1ComboBox.Text);
            studentAns.Add(left2ComboBox.Text + right2ComboBox.Text);
            studentAns.Add(left3ComboBox.Text + right3ComboBox.Text);
            studentAns.Add(left4ComboBox.Text + right4ComboBox.Text);
            studentAns.Add(left5ComboBox.Text + right5ComboBox.Text);

            sa.QuestionId = mq.QuestionId;

            sa.StudentAnswer = studentAns;
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
