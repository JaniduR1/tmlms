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
        Administrator admin;

        public CreateCourse(Person person)
        {
            InitializeComponent();
            admin = person as Administrator;
            addCmbModuleItems();

        }

        //private void setCourses()
        //{
        //    foreach(TM.Course c in TMEngine.Instance.CourseDictionary.Values)
        //    {
        //        if (c != null)
        //        {
        //            cToDeleteComboBox.Items.Add (c.CourseCode);
        //        }
        //    }
        //}

        private void addCmbModuleItems()
        {
            foreach (TM.Module module in TMEngine.Instance.ModuleDictionary.Values)
            {
                availableModules.Items.Add(module.Code);
            }
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

        List<TM.Module> NonCompulsoryModules = new List<TM.Module>();
        List<TM.Module> coreModules = new List<TM.Module>();

        private void addModuleBtn_Click(object sender, EventArgs e)
        {
            TM.Course c = new TM.Course();
            string type;

            foreach (TM.Module module in TMEngine.Instance.ModuleDictionary.Values)
            {
                if (module.Code == availableModules.SelectedItem)
                {
                    if (isCoreCheckBox.Checked)
                    {
                        type = "Core";
                        if (!coreModules.Contains(module))
                        {
                            if (c.coreModuleCreditsLimitCheck(module, coreModules))
                            {
                                coreModules.Add(module);
                                string[] row = { module.Code, module.Name, module.Credits.ToString(), type };
                                var listViewItem = new ListViewItem(row);
                                chosenModules.Items.Add(listViewItem);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The module is already added");
                        }
                    }
                    else
                    {
                        type = "Optional";
                        if (!NonCompulsoryModules.Contains(module))
                        {
                            if (c.optionalModuleCreditCheck(module, NonCompulsoryModules))
                            {
                                NonCompulsoryModules.Add(module);
                                string[] row = { module.Code, module.Name, module.Credits.ToString(), type };
                                var listViewItem = new ListViewItem(row);
                                chosenModules.Items.Add(listViewItem);
                            }
                        }
                        else 
                        {
                            MessageBox.Show("The module is already added");
                        }
                    }
                }

            }
        }


        private void CreateCourse_Load(object sender, EventArgs e)
        {
        }

        private void createCourseBtn_Click(object sender, EventArgs e)
        {
            if (courseNameTxtBox.Text != "" && courseCodeTxtBox.Text != "" && courseInstructorTxtbox.Text != "")
            {
                admin.CreateCourse(CName, CCode, CInstructor);

                courseNameTxtBox.Clear();
                courseCodeTxtBox.Clear();
                courseInstructorTxtbox.Clear();
            }
            else
            {
                MessageBox.Show("Please Complete ALL Fields!");
            }
        }

        //private void deleteCoursesBtn_Click(object sender, EventArgs e)
        //{
        //    Program.tmEngine.CourseDictionary.Remove(cToDeleteComboBox.SelectedItem.ToString());
        //}
    }
}
