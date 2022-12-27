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
        TmLms.Question.Quiz quiz;

        public AddTFQ(TmLms.Question.Quiz quiz)
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
            var questionFalse = true;
            if (corrTickBox.Checked)
            { 
                questionFalse = false;
            }

            if (questionTxtBox.Text != "")
            {
                Question.Question question = new Question.TrueOrFalseQ(quiz, GetQuestion, questionFalse);
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
