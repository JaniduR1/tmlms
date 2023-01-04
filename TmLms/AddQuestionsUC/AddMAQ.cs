using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TmLms.AddQuestionsUC
{
    public partial class AddMAQ : UserControl
    {
        TmLms.Question.Quiz quiz;

        public AddMAQ(CreateTests containerForm)
        {
            InitializeComponent();
            this.quiz = containerForm.GetQuiz();
        }

        private void ClearFields()
        {
            foreach (TextBox txtBox in this.Controls.OfType<TextBox>())
            {
                txtBox.Text = "";
            }

            foreach (CheckBox chkb in this.Controls.OfType<CheckBox>())
            {
                chkb.Checked = false;
            }
        }

        private void addQuestionBtn_Click(object sender, EventArgs e)
        {

            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                if (textBox.Text != "")
                {
                    List<string> answers = new List<string>();
                    foreach (TextBox txtBox in this.Controls.OfType<TextBox>())
                    {
                        answers.Add(txtBox.Text);
                    }
                    List<string> cAnswers = new List<string>();
                    if (corrAns1.Checked)
                    {
                        cAnswers.Add(answerTxtBox1.Text);
                    }
                    if (corrAns2.Checked)
                    {
                        cAnswers.Add(answerTxtBox2.Text);
                    }
                    if (corrAns3.Checked)
                    {
                        cAnswers.Add(answerTxtBox3.Text);
                    }
                    if (corrAns4.Checked)
                    {
                        cAnswers.Add(answerTxtBox1.Text);
                    }
                    Question.Question question = new TmLms.Question.MultipleAnswerQ(questionTxtBox.Text, answers, cAnswers);
                    quiz.addQuestionList(quiz, question); // Add to List
                    question.AddQuestion(question); // Add to Dictionary
                    MessageBox.Show("Question Added");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please fill out all the fields");
                }
            }
        }
    }
}
