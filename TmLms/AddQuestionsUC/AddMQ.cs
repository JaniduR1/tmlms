using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TmLms;
using TmLms.Question;

namespace TmLms.AddQuestionsUC
{
    public partial class AddMQ : UserControl
    {
        Quiz quiz;
        public AddMQ(CreateTests containerForm)
        {
            InitializeComponent();
            this.quiz = containerForm.GetQuiz();
        }

        private bool checkValidity()
        {
            bool isValid = true;
            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {
                if (t.Text == null)
                {
                    isValid = false;
                    break;
                }

            }
            return isValid;
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
            if(checkValidity())
            {
                List<string> left = new List<string>();
                List<string> right = new List<string>();
                List<string> pairs = new List<string>();
                foreach (TextBox tb in leftPanel.Controls.OfType<TextBox>())
                {
                    //MessageBox.Show(tb.Text);
                    right.Add(tb.Text);
                }
                foreach (TextBox tb in rightPanel.Controls.OfType<TextBox>())
                {
                    //MessageBox.Show(tb.Text);
                    left.Add(tb.Text);
                }
                pairs.Add(left1TxtBox.Text + right1TxtBox.Text);
                pairs.Add(left2TxtBox.Text + right2TxtBox.Text);
                pairs.Add(left3TxtBox.Text + right3TxtBox.Text);
                pairs.Add(left4TxtBox.Text + right4TxtBox.Text);
                pairs.Add(left5TxtBox.Text + right5TxtBox.Text);

                Question.Question mq = new MatchingQ(questionTxtBox.Text, pairs, left, right);
                quiz.addQuestionList(quiz, mq);
                mq.AddQuestion(mq);
                MessageBox.Show("Done");
                ClearText();
            }
            else
            {
                MessageBox.Show("Please fill out all the fields");
            }
        }
    }
}
