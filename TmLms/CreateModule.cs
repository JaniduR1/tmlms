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
            TestDB();
        }
        private void CreateModule_Load(object sender, EventArgs e)
        {
            creditsDropDown.SelectedIndex = 0;
            allAvailableModules.Hide();
            deleteBtn.Hide();
            deleteModulesLbl.Hide();

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
            get { return moduleAdminNameTxtBox.Text; }
            set { moduleAdminNameTxtBox.Text = value; }
        }
        // Getting Credits to input into TM.Credits //

        public string ModuleCreditsTxt
        {
            get { return creditsDropDown.Text; }
            set { creditsDropDown.Text = value; }
        }
        // Getting Members to input into TM.Credits //

        public string GetModuleMember
        {
            get { return moduleMemberTxtBox.Text; }
            set { moduleMemberTxtBox.Text = value; }
        }
        // Getting Level to input into TM.Credits //

        public string ModuleLevelTxt
        {
            get { return levelDropDown.Text; }
            set { levelDropDown.Text = value; }
        }

        SortedSet<object> moduleMembers = new SortedSet<object>();

        private void creditsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            moduleMembers.Add(GetModuleMember);
            moduleMemberTxtBox.Clear();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (TmLms.Program.tmEngine.ModuleDictionary.ContainsKey(GetModuleCode))
            {
                MessageBox.Show(moduleCodeExists, messageboxTitle);
                moduleCodeTxtBox.Clear();
                return;
            }

            if (creditsDropDown.Text == "" || levelDropDown.Text == "")
            {
                MessageBox.Show("Choose Module Level");
                return;
            }

            var moduleCInt = Int32.Parse(ModuleCreditsTxt);
            var moduleLInt = Int32.Parse(ModuleLevelTxt);

            TmLms.TM.Module newModule = new TM.Module(GetModuleCode, GetAdminName, GetModuleName, GetModuleDescription,
                moduleCInt, moduleLInt);

            foreach (object i in moduleMembers)
            {
                newModule.addMembers(i);
            }


            TmLms.Program.tmEngine.ModuleDictionary.Add(newModule.Code, newModule);
            moduleNameTxtBox.Clear();
            moduleCodeTxtBox.Clear();
            moduleAdminNameTxtBox.Clear();
            moduleDescriptionTxtBox.Clear();
            //creditsDropDown.Items.Clear()
        }

        private void backHomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteModulesBtn_Click(object sender, EventArgs e)
        {
            deleteModulesBtn.Hide();
            allAvailableModules.Show();
            deleteBtn.Show();
            deleteModulesLbl.Show();

            foreach (TM.Module m in TMEngine.Instance.ModuleDictionary.Values)
            {
                allAvailableModules.Items.Add(m.Code);
            }
        }

        public string GetModuleToDelete
        {
            get { return allAvailableModules.Text; }
            set { allAvailableModules.Text = value; }
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Users.Administrator administrator = new Users.Administrator();
            administrator.DeleteCourse(GetModuleToDelete);

            allAvailableModules.Items.Remove(GetModuleToDelete);

        }


        //DB
        public void TestDB()
        {
            TM.Module module = new TM.Module("MA001", "Andy", "Maths", "Learn Maths", 20, 4);
            AddModule(module);
            module = new TM.Module("SC001", "Bob", "Science", "Learn Science", 20, 4);
            AddModule(module);
            module = new TM.Module("EN001", "Charles", "English", "Learn English", 20, 4);
            AddModule(module);
            module = new TM.Module("GE001", "Dan", "Grog", "Learn Grog", 20, 4);
            AddModule(module);
            module = new TM.Module("HI001", "E", "History", "Learn History", 20, 4);
            AddModule(module);
            module = new TM.Module("CS001", "F", "Computer Sci", "Learn Computer Sci", 20, 4);
            AddModule(module);
            module = new TM.Module("CH001", "G", "Chem", "Learn Chem", 20, 4);
            AddModule(module);
            module = new TM.Module("PH001", "H", "Physics", "Learn Physics", 20, 4);
            AddModule(module);
            module = new TM.Module("BI001", "I", "Biology", "Learn Biology", 20, 4);
            AddModule(module);
            module = new TM.Module("MU001", "J", "Music", "Learn Music", 20, 4);
            AddModule(module);
            module = new TM.Module("DR001", "K", "Drama", "Learn Drama", 20, 4);
            AddModule(module);
            module = new TM.Module("LA001", "L", "Latin", "Learn Latin", 20, 4);
            AddModule(module);
        }
        //DB
        public void AddModule(TM.Module module)
        {
            if (TmLms.TMEngine.Instance.ModuleDictionary.Values.Contains(module))
            {

            }
            else
            {
                TmLms.TMEngine.Instance.ModuleDictionary.Add(module.Code, module);

            }
        }
    }
}
