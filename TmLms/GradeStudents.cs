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
using TmLms.TestViewUC;
using TmLms.TM;

namespace TmLms
{
    public partial class GradeStudents : Form
    {
        Module m;
        Quiz q;
        string index;
        int totalMarks;

        int marks;

        public void setMarks(int m)
        {
            marks = m;
            totalMarks += marks;
            this.totalMarksLbl.Text = totalMarks.ToString();
        }

        public GradeStudents()
        {
            InitializeComponent();
            totalMarks = 0;
            this.totalMarksLbl.Text = totalMarks.ToString();
        }
        private void GradeStudents_Load(object sender, EventArgs e)
        {
            moduleComboBox.Items.Clear();
            foreach (Module m in TMEngine.Instance.ModuleDictionary.Values)
            {
                moduleComboBox.Items.Add(m.Code + " " + m.Name);
            }
        }

        private void setCmbTest()
        {
            qCodeComboBox.Items.Clear();
            foreach (Quiz q in m.GetQuizList())
            {
                qCodeComboBox.Items.Add(q.quizCode);
            }
        }
        private void moduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Module m in TMEngine.Instance.ModuleDictionary.Values)
            {
                if (moduleComboBox.SelectedItem.ToString().Contains(m.Code))
                {
                    this.m = m;
                    break;
                }
            }
            if (this.m != null)
            {
                setCmbTest();
            }
        }

        private void setStudents()
        {
            string[] idarr;
            foreach (StudentAnswers ans in TMEngine.Instance.AnswerDictionary.Values)
            {
                if (ans.AnswerId.Contains(q.quizCode) && ans.AnswerId.Contains(m.Code))
                {
                    idarr = ans.AnswerId.Split("#");
                    if (!stuIndexComboBox.Items.Contains(idarr[1]))
                    {
                        stuIndexComboBox.Items.Add(idarr[1]);
                    }
                }
            }
        }

        private void qCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Quiz q in m.GetQuizList())
            {
                if (q.quizCode.Equals(qCodeComboBox.SelectedItem))
                {
                    this.q = q;
                    break;
                }
            }
            setStudents();
        }

        private void stuIndexComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.index = stuIndexComboBox.SelectedItem.ToString();
            this.answerFlowPanel.Controls.Clear();
            foreach (StudentAnswers sta in TMEngine.Instance.AnswerDictionary.Values)
            {
                if (sta.AnswerId.Contains(m.Code) && sta.AnswerId.Contains(q.quizCode) && sta.AnswerId.Contains(index))
                {
                    ViewTests vt = new ViewTests(sta, this);
                    answerFlowPanel.Controls.Add(vt);

                }
            }
            totalMarks = 0;
            this.totalMarksLbl.Text = totalMarks.ToString();
        }
    }
}
