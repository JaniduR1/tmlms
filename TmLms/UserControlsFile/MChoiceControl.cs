using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MultipleChoice
{
    public partial class UserControl1: UserControl
    {
        string questions;

        List<string> choices = new List<string>();
        public UserControl1()
        {
            InitializeComponent();
        }

        public string GetQuestion 
        {
            get { return questionTxtBox.Text; } 
            set { questionTxtBox.Text = value; }
        }
        public void GetChoices()
        {
            for(int i = 0; i < 4; i++)
            {
                choices.Add(ans1TxtBox.Text);
                choices.Add(ans2TxtBox.Text);
                choices.Add(ans3TxtBox.Text);
                choices.Add(ans4TxtBox.Text);
            }
        }

        public (bool, TmLms.Question.MultipleChoiceQ) GetQandAns()
        {
            bool returnBool = false;
            TmLms.Question.MultipleChoiceQ multipleChoiceQu = new TmLms.Question.MultipleChoiceQ();

            return (returnBool, multipleChoiceQu);

            UserControl userControl = new UserControl1();

            //panel1.Controls.Add(userControl);

            UserControl1 multiChoice = (UserControl1)userControl;

            multiChoice.GetQandAns();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //GetChoices();
            //TmLms.Question.MultipleChoiceQ MCQ = new TmLms.Question.MultipleChoiceQ(GetQuestion);

            //foreach (string i in choices)
            //{
            //    MCQ.Answers.Add(i);
            //}
        }
    }
}
