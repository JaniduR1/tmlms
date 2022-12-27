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
    public partial class AddEQ : UserControl
    {
        TmLms.Question.Quiz quiz;
        public AddEQ(TmLms.Question.Quiz quiz)
        {
            InitializeComponent();
            this.quiz = quiz;
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
            if (questionTxtBox.Text != "")
            {
                Question.Question question = new Question.EssayQ(quiz, GetQuestion);
                question.AddQuestion(question);
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
