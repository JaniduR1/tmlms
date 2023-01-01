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
    public partial class AddTFQ : UserControl
    {
        bool answer;
        TmLms.Question.Quiz quiz;

        public AddTFQ(CreateTests containerForm)
        {
            InitializeComponent();
            this.quiz = containerForm.GetQuiz();
        }

        public string GetQuestion
        {
            get { return questionTxtBox.Text; }
            set { questionTxtBox.Text = value; }
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
            List<string> ans = new List<string>();
            if (answer)
            {
                ans.Clear();
                ans.Add("True");
            }
            else
            {
                ans.Clear();
                ans.Add("False");
            }

            if (questionTxtBox.Text != "")
            {
                Question.Question question = new Question.TrueOrFalseQ(GetQuestion, ans);
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
