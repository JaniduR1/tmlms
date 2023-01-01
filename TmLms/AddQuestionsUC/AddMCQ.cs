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
        public AddMCQ(TmLms.Question.Quiz quiz)
        {
            InitializeComponent();
            this.quiz = quiz;
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
                List<string> falseAnswers = new List<string>();
                falseAnswers.Add(fAnswer2TxtBox.Text);
                falseAnswers.Add(fAnswer3TxtBox.Text);
                falseAnswers.Add(fAnswer4TxtBox.Text);

                Random random = new Random();
                var MixedAnswers = falseAnswers.OrderBy(_ => random.Next()).ToList();

                Question.Question question = new Question.MultipleChoiceQ(quiz, GetQuestion, GetCorrectAnswer, MixedAnswers);
                quiz.addQuestionList(question); // Add to List
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
