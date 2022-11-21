using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TmLms
{
    public partial class CreateModule : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        // Storage ///
        //TM.Module.CreditEnum

        //////////////

        public CreateModule()
        {
            InitializeComponent();
        }
        private void CreateModule_Load(object sender, EventArgs e)
        {
            creditsDropDown.SelectedIndex = 0;
        }

        string messageboxTitle = "Problem Encountered";
        string moduleCodeExists = "There is already a module code that exist with that given input," +
            " please change it.";

        // Getting module Name to input into a dictionary //
        public string GetModuleName
        {
            get { return moduleNameTxtBox.Text; }
            set { moduleNameTxtBox.Text = value; }

        }



        // Getting module Code to input into a dictionary //
        public string GetModuleCode
        {
            get { return moduleCodeTxtBox.Text; }
            set { moduleCodeTxtBox.Text = value; }
        }

        // Getting module Description to input into a TM.Description //
        public string GetModuleDescription
        {
            get { return moduleDescriptionTxtBox.Text; }
            set { moduleDescriptionTxtBox.Text = value; }
        }
        // Getting Admin Name to input into TM.Module //

        public string GetAdminName
        {
            get { return moduleAdminName.Text; }
            set { moduleAdminName.Text = value; }
        }
        // Getting Credits to input into TM.Credits //

        public string ModuleCreditsNum
        {
            get { return creditsDropDown.Text; }
            set { creditsDropDown.Text = value; }
        }

        public string GetModuleMember
        {
            get { return moduleMemberTxtBox.Text; }
            set { moduleMemberTxtBox.Text= value; }
        }

        SortedSet<object> moduleMembers = new SortedSet<object>();

        private void creditsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            moduleMembers.Add(GetModuleMember);
            moduleMemberTxtBox.Clear();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //AllocConsole();
            if (TmLms.Program.tmEngine.ModuleDictionary.ContainsKey(GetModuleCode))
            {
                MessageBox.Show(moduleCodeExists, messageboxTitle);
                moduleCodeTxtBox.Clear(); 
                return;
            }
            TmLms.TM.Module newModule = new TM.Module(GetModuleCode, GetAdminName);
            //newModule.Members.Add(moduleMembers);
            newModule.Name = GetModuleName;
            newModule.Description = GetModuleDescription;
            //newModule.Members.Add(moduleMembers);
            TmLms.Program.tmEngine.ModuleDictionary.Add(newModule.Code, newModule);

            //TmLms.Program.tmEngine.ModuleDictionary.ToList().ForEach(m => Console.WriteLine(m.Key));
        }

        private void backHomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
