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
    public partial class AddMCQ : UserControl
    {
        TmLms.Question.Quiz quiz;
        public AddMCQ(CreateTests containerForm)
        {
            InitializeComponent();
            this.quiz = containerForm.GetQuiz();
        }

        public string GetQuestion
        {
            get { return questionTxtBox.Text; }
            set { questionTxtBox.Text = value; }
        }
        public string GetCorrectAnswer
        {
            get { return cAnswerTxtBox.Text; }
            set { cAnswerTxtBox.Text = value; }
        }

        private void ClearText()
        {
            foreach (TextBox txtBox in this.Controls.OfType<TextBox>())
            {
                txtBox.Text = "";
            }
        }


        private void addQuestionBtn_Click(object sender, EventArgs e)
        {
            if (questionTxtBox.Text != "" && cAnswerTxtBox.Text != "" && fAnswer2TxtBox.Text != "" && 
                fAnswer3TxtBox.Text != "" && fAnswer4TxtBox.Text != "")
            {
                List<string> allAnswers = new List<string>();
                allAnswers.Add(GetCorrectAnswer);
                allAnswers.Add(fAnswer2TxtBox.Text);
                allAnswers.Add(fAnswer3TxtBox.Text);
                allAnswers.Add(fAnswer4TxtBox.Text);

                List<string> CorrectAnswer = new List<string>();
                CorrectAnswer.Add(GetCorrectAnswer);

                Question.Question question = new Question.MultipleChoiceQ(GetQuestion, CorrectAnswer, allAnswers);
                quiz.addQuestionList(quiz, question); // Add to List
                question.AddQuestion(question); // Add to Dictionary
                MessageBox.Show("Question Added");
                ClearText();
            }
            else
            {
                MessageBox.Show("Please fill out all the fields");
            }

        }
    }
}
