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
    public partial class ViewTests : UserControl
    {
        StudentAnswers stAns;
        GradeStudents gStu;
        public ViewTests(StudentAnswers stAns, GradeStudents gStu)
        {
            InitializeComponent();
            this.stAns = stAns;
            this.gStu = gStu;
            setData();
        }

        private void setData()
        {
            foreach (Question.Question q in TMEngine.Instance.QuestionDictionary.Values)
            {
                if (stAns.QuestionId == q.QuestionId)
                {
                    this.questionText.Text = q.GetQuestion();

                    //foreach (string s in q.GetAnswer())
                    //{
                    //    MessageBox.Show(s + "ViewAnswer");
                    //}
                    // MessageBox.Show("In If");
                    this.corrAnsText.Text = String.Join("\n", q.GetAnswer());

                }
            }
            this.givenAnsText.Text = String.Join("\n", stAns.StudentAnswer);

        }

        private void markBtn_Click(object sender, EventArgs e)
        {
            try
            {
                gStu.setMarks(Convert.ToInt32(marksTxtBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
