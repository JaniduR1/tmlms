using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TmLms.Question;


namespace TmLms.TestViewUC
{
    public partial class TakeMCQ : UserControl
    {
        MultipleChoiceQ mcq;

        public TakeMCQ(Question.Question q)
        {
            InitializeComponent();
            this.mcq = q as MultipleChoiceQ;
            setData();
        }

        private void setData()
        {
            //
            this.questionLbl.Text = mcq.GetQuestion();
            List<string> mixed = mcq.GetGivenAnswerSet().OrderBy(x => Guid.NewGuid()).ToList();
            int i = 0;
            foreach (RadioButton rBtn in this.Controls.OfType<RadioButton>())
            {
                rBtn.Text = mixed.ElementAt(i);
                i++;
            }

        }
    }
}
