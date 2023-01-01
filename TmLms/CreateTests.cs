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

        private void SetComboBoxModule()
        {
            foreach (TM.Module module in TMEngine.Instance.ModuleDictionary.Values)
            {
                moduleComboBox.Items.Add(module.Code);
            }
        }

        private void addQuestionsBtn_Click(object sender, EventArgs e)
        {
            if (quizCodeTxtBox.Text != null && moduleComboBox.SelectedIndex <= 0)
            {
                quiz = new Question.Quiz(module, quizCodeTxtBox.Text);
                quizCodeTxtBox.ReadOnly = true;
                moduleComboBox.Enabled = false;
                addQuestionsBtn.Enabled = false;
                finishQuizBtn.Show();
                quizTypeComboBox.Show();
                quizTypeLbl.Show();

            }
            else
            {
                MessageBox.Show("Error, Please choose a Quiz Type and Enter a Quiz Code");

            }
        }

        private void quizTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (quizTypeComboBox.SelectedItem == "Multiple Choice")
            {
                questionsPanel.Controls.Clear();
                AddQuestionsUC.AddMCQ addmcq = new AddQuestionsUC.AddMCQ(quiz);
                questionsPanel.Controls.Add(addmcq);
            }
            else if(quizTypeComboBox.SelectedItem == "Multiple Answer")
            {
                questionsPanel.Controls.Clear();
                AddQuestionsUC.AddMAQ addmaq = new AddQuestionsUC.AddMAQ(quiz);
                questionsPanel.Controls.Add(addmaq);
            }
            else if (quizTypeComboBox.SelectedItem == "Short Answer")
            {
                questionsPanel.Controls.Clear();
                AddQuestionsUC.AddSAQ addsaq = new AddQuestionsUC.AddSAQ(quiz);
                questionsPanel.Controls.Add(addsaq);
            }
            else if (quizTypeComboBox.SelectedItem == "Essay")
            {
                questionsPanel.Controls.Clear();
                AddQuestionsUC.AddEQ addeq = new AddQuestionsUC.AddEQ(quiz);
                questionsPanel.Controls.Add(addeq);
            }
            //else if(quizTypeComboBox.SelectedItem == "Matching")
            //{
            //    questionsPanel.Controls.Clear();
            //    AddQuestionsUC.AddMAQ addmaq = new AddQuestionsUC.AddMAQ(quiz);
            //    questionsPanel.Controls.Add(addmaq);
            //}            
            else if (quizTypeComboBox.SelectedItem == "True/False")
            {
                questionsPanel.Controls.Clear();
                AddQuestionsUC.AddTFQ addtfq = new AddQuestionsUC.AddTFQ(quiz);
                questionsPanel.Controls.Add(addtfq);
            }

        }
    }
}
