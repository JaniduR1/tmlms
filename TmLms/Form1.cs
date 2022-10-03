namespace TmLms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxUserType.SelectedItem == "Administrator" || comboBoxUserType.SelectedItem == "Instructor")
            {
                this.Hide();
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                mainScreen.createCourseBtn.Visible = true;
                mainScreen.createModuleBtn.Visible = true;

            }

            //else if (comboBoxUserType.SelectedItem == "Advance User")
            //{
            //    this.Hide();
            //    MainScreen mainScreen = new MainScreen();
            //    mainScreen.Show();
            //    mainScreen.createCourseBtn.Visible = true;
            //    mainScreen.createModuleBtn.Visible = true;
            //}

            else if (comboBoxUserType.SelectedItem == "Student")
            {
                this.Hide();
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                mainScreen.createCourseBtn.Visible = false;
                mainScreen.createModuleBtn.Visible = false;

            }

        }
    }
}