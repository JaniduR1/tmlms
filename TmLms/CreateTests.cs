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

            quizTypeComboBox.Items.Add("Multiple Choice");
            quizTypeComboBox.Items.Add("Multiple Answer");
            quizTypeComboBox.Items.Add("Short Answer");
            quizTypeComboBox.Items.Add("Essay");
            quizTypeComboBox.Items.Add("Matching");
            quizTypeComboBox.Items.Add("True/False");

        }

        private void selectQuizType_Click(object sender, EventArgs e)
        {
            //if (quizTypes.SelectedIndex == 0) // Multiple Choice
            //{
            //    MultipleChoiceCreation mCCreation = new MultipleChoiceCreation();
            //    mCCreation.Show();

            //}

            //else if (quizTypes.SelectedIndex == 1)
            //{
            //    /// Same as multiple Choice, Create a new form that will allow the instructor to create
            //    /// multiple Answer questions, (use tick boxes)
            //    return;
            //}
            //else if (quizTypes.SelectedIndex == 2)
            //{
            //    return;
            //}
            //else if (quizTypes.SelectedIndex == 3)
            //{
            //    return;
            //}
            //else if (quizTypes.SelectedIndex == 4)
            //{
            //    return;
            //}
            //else if (quizTypes.SelectedIndex == 5)
            //{
            //    return;
            //}
            //else if (quizTypes.SelectedIndex == 6)
            //{
            //    return;
            //}
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
            if (quizCodeTxtBox.Text == null && moduleComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Error, Please choose a Quiz Type and Enter a Quiz Code");
            }
            else
            {
                Question.Quiz qz = new Question.Quiz(module, quizCodeTxtBox.Text);
                quizCodeTxtBox.ReadOnly = true;
                moduleComboBox.Enabled = false;
                addQuestionsBtn.Enabled = false;
                quizTypeComboBox.Show();
                quizTypeLbl.Show();

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
        }
    }
}
