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
    public partial class CreateCourse : Form
    {
        public CreateCourse()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addModuleBtn_Click(object sender, EventArgs e)
        {

        }

        private void CreateCourse_Load(object sender, EventArgs e)
        {
            foreach (TM.Module m in TMEngine.Instance.ModuleDictionary.Values)
            {
                availableModules.Items.Add(m.Name);
            }
        }
    }
}
