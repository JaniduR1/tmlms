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
    public partial class TakeTest : Form
    {
        TM.Module module;
        Question.Quiz quiz;
        public TakeTest()
        {
            InitializeComponent();
            setModuleComboBox();
        }

        private void setModuleComboBox()
        {
            moduleComboBox.Items.Clear();
            foreach (TM.Module m in TMEngine.Instance.ModuleDictionary.Values)
            {
                moduleComboBox.Items.Add(m.Name);
            }
        }

        private void setAvailableQuiz()
        {
            quizComboBox.Items.Clear();
            foreach (Question.Quiz q in module.GetQuizList())
            {
                quizComboBox.Items.Add(q.quizCode);
            }
        }

        private void moduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (TM.Module m in TMEngine.Instance.ModuleDictionary.Values)
            {
                if (moduleComboBox.SelectedItem.ToString().Equals(m.Name))
                {
                    this.module = m;
                    break;
                }
            }
            setAvailableQuiz();
        }

        private void quizComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            moduleComboBox.Enabled = false;
            quizComboBox.Enabled = false;
            takeExamLbl.Text = "Good Luck!";
        }
    }
}
