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
    public partial class TakeSAQ : UserControl
    {
        ShortAnswerQ saq;
        public TakeSAQ(Question.Question q)
        {
            InitializeComponent();
            saq = q as ShortAnswerQ;
            setData();
        }

        private void setData()
        {
            this.questionLbl.Text = saq.GetQuestion();
        }
    }
}
