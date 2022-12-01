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

        string answer1;
        string answer2;
        string answer3;
        string answer4;
        public UserControl1()
        {
            InitializeComponent();
        }

        public string Ans1
        {
            get
            {
                return answer1;
            }
            set
            {
                answer1 = value;
                this.ans1RBtn.Text = answer1;
            }
        }

        public string Ans2
        {
            get
            {
                return answer2;
            }
            set
            {
                answer2 = value;
                this.ans2RBtn.Text = answer2;
            }
        }

        public string Ans3
        {
            get
            {
                return answer3;
            }
            set
            {
                answer3 = value;
                this.ans3RBtn.Text = answer3;
            }
        }

        public string Ans4
        {
            get
            {
                return answer4;
            }
            set
            {
                answer4 = value;
                this.ans4RBtn.Text = answer4;
            }
        }
    }
}
