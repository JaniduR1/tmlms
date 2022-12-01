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


        private void addQuestionBtn_Click(object sender, EventArgs e)
        {
            //multipleChoiceTest multipleChoice = new multipleChoiceTest();
            //TmLms.TMEngine.Instance.mQuestionTest.Add(GetModuleCodde, )
        }

        private void MultipleChoiceCreation_Load(object sender, EventArgs e)
        {

        }
    }
}
