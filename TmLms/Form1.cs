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
            if (comboBoxUserType.SelectedItem == "Admin")
            {
                this.Hide();
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                mainScreen.createCourseBtn.Visible = false;

            }
        }
    }
}