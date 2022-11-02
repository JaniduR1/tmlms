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
            TMEngine.LoginValidation();
        }
    }
}