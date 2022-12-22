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
    public partial class MultipleChoiceCreation : Form
    {
        public MultipleChoiceCreation()
        {
            InitializeComponent();
        }

        public string GetQuestionTxt
        {
            get { return questionTxtBox.Text; }
            set { questionTxtBox.Text = value; }
        }

        public string GetCorrectAnswerTxt
        {
            get { return correctAnswerTxtBox.Text; }
            set { correctAnswerTxtBox.Text = value; }
        }

        public string GetAnswer2Txt
        {
            get { return ans2TxtBox.Text; }
            set { ans2TxtBox.Text = value; }
        }

        public string GetAnswer3Txt
        {
            get { return ans3TxtBox.Text; }
            set { ans3TxtBox.Text = value; }
        }

        public string GetAnswer4Txt
        {
            get { return ans4TxtBox.Text; }
            set { ans4TxtBox.Text = value; }
        }

        List<string> GivenChoices = new List<string>();

        private void addQuestionBtn_Click(object sender, EventArgs e)
        {
            TmLms.Question.MultipleChoiceQ multipleChoiceQ = new Question.MultipleChoiceQ(GetQuestionTxt);

            multipleChoiceQ.AddChoice(GetCorrectAnswerTxt, true);
            multipleChoiceQ.AddChoice(GetAnswer2Txt, false);
            multipleChoiceQ.AddChoice(GetAnswer3Txt, false);
            multipleChoiceQ.AddChoice(GetAnswer4Txt, false);

        }

        private void MultipleChoiceCreation_Load(object sender, EventArgs e)
        {

        }

        private void finishBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
