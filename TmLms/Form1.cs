using TmLms.Users;

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
            if (comboBoxUserType.SelectedIndex == 0)
            {
                Administrator administrator = new Administrator();
                MainScreen main = new MainScreen(administrator);
                main.ShowDialog(this);
            }
            else if (comboBoxUserType.SelectedIndex == 1)
            {
                Instructor instructor = new Instructor();
                MainScreen main = new MainScreen(instructor);
                main.ShowDialog(this);
            }
            else if (comboBoxUserType.SelectedIndex == 2)
            {
                Student student = new Student();
                MainScreen main = new MainScreen(student);
                main.ShowDialog(this);
            }

        }
    }
}