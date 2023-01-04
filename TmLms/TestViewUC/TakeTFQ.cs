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
    public partial class TakeTFQ : UserControl
    {
        TrueOrFalseQ tfq;
        public TakeTFQ(Question.Question q)
        {
            InitializeComponent();
            tfq = q as TrueOrFalseQ;
            setData();
        }

        private void setData()
        {
            this.questionLbl.Text = tfq.GetQuestion();
            this.trueRadioBtn.Text = "TRUE";
            this.falseRadioBtn.Text = "FALSE";
        }
    }
}
