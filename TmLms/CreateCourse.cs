using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TmLms.Users;

namespace TmLms
{
    public partial class CreateCourse : Form
    {
        public CreateCourse()
        {
            InitializeComponent();
        }

        public string CName 
        { 
            get { return courseNameTxtBox.Text; }
            set { courseNameTxtBox.Text = value; }
        }
        public string CCode
        {
            get { return courseCodeTxtBox.Text; }
            set { courseCodeTxtBox.Text = value; }
        }
        public string CInstructor
        {
            get { return courseInstructorTxtbox.Text; }
            set { courseInstructorTxtbox.Text = value; }
        }

        public string ChosenModuleToAdd
        {
            get { return availableModules.Text; }
            set { availableModules.Text = value; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addModuleBtn_Click(object sender, EventArgs e)
        {
            //foreach (TM.Module m in TMEngine.Instance.ModuleDictionary.Values)
            //{
            //    availableModules.Items.Add(m.Name);
            //}

            //chosenModules.Items.Add()
        }


        private void CreateCourse_Load(object sender, EventArgs e)
        {
            //availableModules.Items.Add(TMEngine.GetModuleCodes());
            foreach (TM.Module m in TMEngine.Instance.ModuleDictionary.Values)
            {
                availableModules.Items.Add(m.Code);
            }
        }

        private void createCourseBtn_Click(object sender, EventArgs e)
        {
            Administrator administrator = new Administrator();
            administrator.CreateCourse(CName, CCode, CInstructor);

            courseNameTxtBox.Clear();
            courseCodeTxtBox.Clear();
            courseInstructorTxtbox.Clear();
        }
    }
}
