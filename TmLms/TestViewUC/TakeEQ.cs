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
    public partial class TakeEQ : UserControl
    {
        EssayQ eq;

        public TakeEQ(Question.Question q)
        {
            InitializeComponent();
            eq = q as EssayQ;
            setData();
        }
        private void setData()
        {
            this.questionLbl.Text = eq.GetQuestion();
        }
    }
}
