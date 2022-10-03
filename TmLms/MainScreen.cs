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
    public partial class MainScreen : Form
    {

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void createCourseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateCourse createCourse = new CreateCourse();
            createCourse.Show();
        }

    }
}
