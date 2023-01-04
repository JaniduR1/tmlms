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
    public partial class TakeMQ : UserControl
    {
        MatchingQ mq;

        public TakeMQ(Question.Question q)
        {
            InitializeComponent();
            mq = q as MatchingQ;
        }

        private void SetData()
        {
            this.questionLbl.Text = mq.GetQuestion();

            foreach(ComboBox cmbox in LeftPanel.Controls.OfType<ComboBox>())
            {
                cmbox.Items.Clear();
                var randomList = mq.GetLeft().OrderBy(x => Guid.NewGuid()).ToList();
                foreach (string s in randomList)
                {
                    cmbox.Items.Add(s);
                }
            }
            foreach (ComboBox cmbox in RightPanel.Controls.OfType<ComboBox>())
            {
                cmbox.Items.Clear();
                var randomList = mq.GetRight().OrderBy(x => Guid.NewGuid()).ToList();
                foreach (string s in randomList)
                {
                    cmbox.Items.Add(s);
                }
            }


        }
    }
}
