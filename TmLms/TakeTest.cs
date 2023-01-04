using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TmLms
{
    public partial class TakeTest : Form
    {
        int i;
        TM.Module module;
        Question.Quiz quiz;
        List<UserControl> QuestionUCs;
        string index;//
        public TakeTest()
        {
            InitializeComponent();
            setModuleComboBox();
            i = 0;
        }

        private void setModuleComboBox()
        {
            moduleComboBox.Items.Clear();
            foreach (TM.Module m in TMEngine.Instance.ModuleDictionary.Values)
            {
                moduleComboBox.Items.Add(m.Name);
            }
        }

        private void setAvailableQuiz()
        {
            quizComboBox.Items.Clear();
            foreach (Question.Quiz q in module.GetQuizList())
            {
                quizComboBox.Items.Add(q.quizCode);
            }
        }

        private void moduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (TM.Module m in TMEngine.Instance.ModuleDictionary.Values)
            {
                if (moduleComboBox.SelectedItem.ToString().Equals(m.Name))
                {
                    this.module = m;
                    break;
                }
            }
            setAvailableQuiz();
        }

        private void SetQuiz()
        {
            foreach (Question.Quiz q in module.GetQuizList())
            {
                if (quizComboBox.SelectedItem.ToString().Contains(q.quizCode))
                {
                    this.quiz = q;
                    break;
                }
            }
        }

        private void quizComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            moduleComboBox.Enabled = false;
            quizComboBox.Enabled = false;
            SetQuiz();
            QuestionUCs = new List<UserControl>();
            prepareQuiz();
            takeExamLbl.Text = "Good Luck!";
        }

        private void prepareQuiz()
        {
            i = 0;
            leftArrowPic.Enabled = false;
            questionsPanel.Controls.Clear();
            QuestionUCs.Clear();
            foreach (Question.Question q in quiz.GetQuestions())
            {
                if (q.GetType() == typeof(Question.EssayQ))
                {
                    TestViewUC.TakeEQ eq = new TestViewUC.TakeEQ(q, quiz.quizCode, module.Code, index);
                    QuestionUCs.Add(eq);
                }
                else if(q.GetType() == typeof(Question.MultipleChoiceQ))
                {
                    TestViewUC.TakeMCQ mcq = new TestViewUC.TakeMCQ(q, quiz.quizCode, module.Code, index);
                    QuestionUCs.Add(mcq);
                }
                else if(q.GetType() == typeof(Question.MultipleAnswerQ))
                {
                    TestViewUC.TakeMAQ maq = new TestViewUC.TakeMAQ(q, quiz.quizCode, module.Code, index);
                    QuestionUCs.Add(maq);
                }
                else if (q.GetType() == typeof(Question.ShortAnswerQ))
                {
                    TestViewUC.TakeSAQ saq = new TestViewUC.TakeSAQ(q, quiz.quizCode, module.Code, index);
                    QuestionUCs.Add(saq);
                }
                else if (q.GetType() == typeof(Question.MatchingQ))
                {
                    TestViewUC.TakeMQ mq = new TestViewUC.TakeMQ(q);
                    QuestionUCs.Add(mq);
                }
                questionsPanel.Controls.Clear();
                questionsPanel.Controls.Add(QuestionUCs.ElementAt(i));
            }
        }

        private void navigateQuiz()
        {

            if (i == 0)
            {
                leftArrowPic.Enabled = false;
            }
            else
            {
                leftArrowPic.Enabled = true;
            }
            if (i == QuestionUCs.Count - 1)
            {
                rightArrowPic.Enabled = false;
            }
            else
            {
                rightArrowPic.Enabled = true;

            }
            questionsPanel.Controls.Clear();
            questionsPanel.Controls.Add(QuestionUCs.ElementAt(i));
        }

        private void rightArrowPic_Click(object sender, EventArgs e)
        {
            i -= 1;
            navigateQuiz();
        }

        private void leftArrowPic_Click(object sender, EventArgs e)
        {
            i += 1;
            navigateQuiz();
        }
    }
}
