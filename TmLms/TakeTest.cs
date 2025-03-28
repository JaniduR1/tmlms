﻿using System;
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
        string index;
        public TakeTest()
        {
            InitializeComponent();
            setModuleComboBox();
            leftArrowPic.Enabled = false;
            rightArrowPic.Enabled = false;
            startExamBtn.Enabled = false;
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
            if (moduleComboBox.SelectedIndex >= 0 && quizComboBox.SelectedIndex >= 0)
            {
                moduleComboBox.Enabled = false;
                quizComboBox.Enabled = false;
                leftArrowPic.Enabled = true;
                rightArrowPic.Enabled = true;
                startExamBtn.Enabled = true;
                SetQuiz();
                QuestionUCs = new List<UserControl>();
            }
        }

        private void prepareQuiz()
        {
            try
            {
                if (studentIndexTxtBox.Text != "")
                {
                    index = studentIndexTxtBox.Text;
                }
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
                    else if (q.GetType() == typeof(Question.MultipleChoiceQ))
                    {
                        TestViewUC.TakeMCQ mcq = new TestViewUC.TakeMCQ(q, quiz.quizCode, module.Code, index);
                        QuestionUCs.Add(mcq);
                    }
                    else if (q.GetType() == typeof(Question.MultipleAnswerQ))
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
                        TestViewUC.TakeMQ mq = new TestViewUC.TakeMQ(q, quiz.quizCode, module.Code, index);
                        QuestionUCs.Add(mq);
                    }
                    questionsPanel.Controls.Clear();
                    questionsPanel.Controls.Add(QuestionUCs.ElementAt(i));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void navigateQuiz()
        {
            if (index != null)
            {
                if (QuestionUCs != null)
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
                    //MessageBox.Show(i.ToString());
                    try
                    {
                        questionsPanel.Controls.Add(QuestionUCs.ElementAt(i));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("End Of The Test");
                    }

                }
            }
            else
            {
                MessageBox.Show("Please Give a Student Index");
            }
        }

        private void rightArrowPic_Click(object sender, EventArgs e)
        {
            i += 1;
            navigateQuiz();
        }

        private void leftArrowPic_Click(object sender, EventArgs e)
        {
            i = i - 1;
            navigateQuiz();
        }

        private void startExamBtn_Click(object sender, EventArgs e)
        {
            if (studentIndexTxtBox.Text.Length > 0)
            {
                studentIndexTxtBox.Enabled = false;
                prepareQuiz();
                takeExamLbl.Text = "Good Luck!";
            }
            else
            {
                MessageBox.Show("Please Insert Your Student Index");
            }
        }
    }
}
