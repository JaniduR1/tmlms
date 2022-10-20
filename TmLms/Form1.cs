namespace TmLms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string LoginBtnTxt
        {
            get { return comboBoxUserType.Text; }
            set { LoginBtnTxt = value; }
        }
        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (LoginBtnTxt == "Administrator" || LoginBtnTxt == "Instructor")
            {
                this.Hide();
                var mainScreen = new MainScreen();
                mainScreen.Closed += (s, args) => this.Close();
                mainScreen.Show();
                mainScreen.createCourseBtn.Enabled = true;
                mainScreen.createModuleBtn.Enabled = true;

            }

            else if (LoginBtnTxt == "Student")
            {
                this.Hide();
                var mainScreen = new MainScreen();
                mainScreen.Closed += (s, args) => this.Close();
                mainScreen.Show();
                mainScreen.createCourseBtn.Enabled = false;
                mainScreen.createModuleBtn.Enabled = false;

            }
        }
    }
}