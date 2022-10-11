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
    public partial class CreateModule : Form
    {
        string messageboxTitle = "Problem Encountered";
        string moduleCodeExists = "There is already a module code that exist with that given input, please change it.";

        // Getting module Name to input into a dictionary //
        public string GetModuleName
        {
            get
            {
                return moduleNameTxtBox.Text;
            }
            set { moduleNameTxtBox.Text = value; }

        }

        // Getting module Name to input into a dictionary //
        public string GetModuleCode 
        {
            get
            {
                return moduleCodeTxtBox.Text;
            }
            set { moduleCodeTxtBox.Text = value; }
        
        }



        public CreateModule()
        {
            InitializeComponent();
        }
        private void creditsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (TmLms.Program.tmEngine.ModuleDictionary.ContainsKey(GetModuleCode))
            {
                MessageBox.Show(moduleCodeExists, messageboxTitle);
                return;
            }

            TmLms.TM.Module newModule = new TM.Module(GetModuleCode, GetModuleName);// ("Module Code", "Module Name");
            TmLms.Program.tmEngine.ModuleDictionary.Add(newModule.Code, newModule);

            GetModuleName = "";
            GetModuleCode = "";

        }
    }
}
