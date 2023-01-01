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
    public partial class MainScreen : Form
    {
        Person currentUser;

        public MainScreen(Person user)
        {
            InitializeComponent();
            currentUser = user;
            ControlUI();
            logoPictureBox.Show();
        }

        private void ControlUI()
        {
            if (currentUser.GetType() == typeof(Administrator))
            {

            }
            else if (currentUser.GetType() == typeof(Instructor))
            {
                createCourseBtn.Enabled = false;
                createModuleBtn.Enabled = false;
            }
            else if (currentUser.GetType() == typeof(Student))
            {
                createCourseBtn.Enabled = false;
                createModuleBtn.Enabled = false;
                viewCoursesBtn.Enabled = false;
                viewModuleBtn.Enabled = false;
                createTestBtn.Enabled = false;
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        public bool CreateCourseBtn
        {
            get { return true; }
            set { CreateCourseBtn = value; }
        }

        public bool CreateModuleBtn
        {
            get { return true; }
            set { CreateModuleBtn = value; }
        }

        private void createCourseBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var createCourse = new CreateCourse(currentUser);
            //createCourse.Closed += (s, args) => this.Close();
            createCourse.Show();
        }

        private void createModuleBtn_Click(object sender, EventArgs e)
        {
            ///this.Hide();
            var createModule = new CreateModule();
            //createModule.Closed += (s, args) => this.Close();
            createModule.Show();
        }

        private void createTestBtn_Click(object sender, EventArgs e)
        {
            var createTest = new CreateTests();

            createTest.Show();
        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void takeTestBtn_Click(object sender, EventArgs e)
        {
            var takeTest = new TakeTest();
            takeTest.Show();
        }
    }
}
