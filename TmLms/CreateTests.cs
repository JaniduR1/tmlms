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
    public partial class CreateTests : Form
    {
        Question.Quiz quiz;
        TM.Module module;
        public CreateTests()
        {
            InitializeComponent();
            SetComboBoxModule();
        }

        private void CreateTests_Load(object sender, EventArgs e)
        {
            quizTypeComboBox.Hide();
            quizTypeLbl.Hide();
            finishQuizBtn.Hide();

            quizTypeComboBox.Items.Add("Multiple Choice");
            quizTypeComboBox.Items.Add("Multiple Answer");
            quizTypeComboBox.Items.Add("Short Answer");
            quizTypeComboBox.Items.Add("Essay");
            quizTypeComboBox.Items.Add("Matching");
            quizTypeComboBox.Items.Add("True/False");

        }

        private void selectQuizType_Click(object sender, EventArgs e)
        {
        }

        public Question.Quiz GetQuiz()
        {
            return quiz;
        }

        private void SetComboBoxModule()
        {
            foreach (TM.Module module in TMEngine.Instance.ModuleDictionary.Values)
            {
                moduleComboBox.Items.Add(module.Code);
            }
        }

        private void addQuestionsBtn_Click(object sender, EventArgs e)
        {
            if (quizCodeTxtBox.Text != "" && moduleComboBox.SelectedIndex > -1)
            {
                quiz = new Question.Quiz(module, quizCodeTxtBox.Text);
                module.addQuiz(quiz);

                quizCodeTxtBox.ReadOnly = true;
                moduleComboBox.Enabled = false;
                addQuestionsBtn.Enabled = false;
                finishQuizBtn.Show();
                quizTypeComboBox.Show();
                quizTypeLbl.Show();

            }
            else
            {
                MessageBox.Show("Error, Please choose a Module and Enter a Quiz Code");

            }
        }

        private void quizTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (quizTypeComboBox.SelectedItem == "Multiple Choice")
            {
                questionsPanel.Controls.Clear();
                AddQuestionsUC.AddMCQ addmcq = new AddQuestionsUC.AddMCQ(this);
                questionsPanel.Controls.Add(addmcq);
            }
            else if(quizTypeComboBox.SelectedItem == "Multiple Answer")
            {
                questionsPanel.Controls.Clear();
                AddQuestionsUC.AddMAQ addmaq = new AddQuestionsUC.AddMAQ(this);
                questionsPanel.Controls.Add(addmaq);
            }
            else if (quizTypeComboBox.SelectedItem == "Short Answer")
            {
                questionsPanel.Controls.Clear();
                AddQuestionsUC.AddSAQ addsaq = new AddQuestionsUC.AddSAQ(this);
                questionsPanel.Controls.Add(addsaq);
            }
            else if (quizTypeComboBox.SelectedItem == "Essay")
            {
                questionsPanel.Controls.Clear();
                AddQuestionsUC.AddEQ addeq = new AddQuestionsUC.AddEQ(this);
                questionsPanel.Controls.Add(addeq);
            }
            else if (quizTypeComboBox.SelectedItem == "Matching")
            {
                questionsPanel.Controls.Clear();
                AddQuestionsUC.AddMQ addmq= new AddQuestionsUC.AddMQ(this);
                questionsPanel.Controls.Add(addmq);
            }
            else if (quizTypeComboBox.SelectedItem == "True/False")
            {
                questionsPanel.Controls.Clear();
                AddQuestionsUC.AddTFQ addtfq = new AddQuestionsUC.AddTFQ(this);
                questionsPanel.Controls.Add(addtfq);
            }

        }

        private void finishQuizBtn_Click(object sender, EventArgs e)
        {
            quiz.saveQuiz(quiz);
            MessageBox.Show("Quiz Created!");
        }

        private void moduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (TM.Module module in TMEngine.Instance.ModuleDictionary.Values)
            {
                if (moduleComboBox.SelectedItem.ToString().Contains(module.Code))
                {
                    this.module = module;
                    break;
                }
            }
        }
    }
}
