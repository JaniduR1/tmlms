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

        public AddMAQ(TmLms.Question.Quiz quiz)
        {
            InitializeComponent();
            this.quiz = quiz;
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
            List<string> answers = new List<string>();
            List<string> cAnswers = new List<string>();
            answers.Add(answerTxtBox1.Text);
            answers.Add(answerTxtBox2.Text);
            answers.Add(answerTxtBox3.Text);
            answers.Add(answerTxtBox4.Text);

            foreach(CheckBox cb in this.Controls.OfType<CheckBox>())
            {
                if (cb.Checked)
                {
                    //
                }
            }

            ClearText();
        }
    }
}
