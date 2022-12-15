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
        public CreateTests()
        {
            InitializeComponent();
        }

        private void CreateTests_Load(object sender, EventArgs e)
        {
            quizTypes.Items.Add("Multiple Choice");
            quizTypes.Items.Add("Multiple Answer");
            quizTypes.Items.Add("Short Answer");
            quizTypes.Items.Add("Essay");
            quizTypes.Items.Add("Matching");
            quizTypes.Items.Add("True/False");

        }

        private void selectQuizType_Click(object sender, EventArgs e)
        {
            if (quizTypes.SelectedIndex == 0) // Multiple Choice
            {
                MultipleChoiceCreation mCCreation = new MultipleChoiceCreation();
                mCCreation.Show();

            }

            else if (quizTypes.SelectedIndex == 1)
            {
                /// Same as multiple Choice, Create a new form that will allow the instructor to create
                /// multiple Answer questions, (use tick boxes)
                return;
            }
            else if (quizTypes.SelectedIndex == 2)
            {
                return;
            }
            else if (quizTypes.SelectedIndex == 3)
            {
                return;
            }
            else if (quizTypes.SelectedIndex == 4)
            {
                return;
            }
            else if (quizTypes.SelectedIndex == 5)
            {
                return;
            }
            else if (quizTypes.SelectedIndex == 6)
            {
                return;
            }
        }
    }
}
