using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms
{
    //public static Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
    //public static MainScreen mainScreen = Application.OpenForms.OfType<MainScreen>().FirstOrDefault();
    public sealed class TMEngine
    {
        //Validation Complete
        #region
        public static void LoginValidation()
        {
            Form form1 = Application.OpenForms["Form1"];
            string user = ((Form1)form1).LoginBtnTxt;

            if(user == "Administrator")
            {
                form1.Hide();
                var mainScreen = new MainScreen();
                mainScreen.Closed += (s, args) => form1.Close();
                mainScreen.Show();
                mainScreen.createCourseBtn.Enabled = true;
                mainScreen.createModuleBtn.Enabled = true;
            }
            else if(user == "Instructor")
            {
                form1.Hide();
                var mainScreen = new MainScreen();
                mainScreen.Closed += (s, args) => form1.Close();
                mainScreen.Show();
                mainScreen.createCourseBtn.Enabled = false;
                mainScreen.createModuleBtn.Enabled = true;
            }
            else if (user == "Student")
            {
                form1.Hide();
                var mainScreen = new MainScreen();
                mainScreen.Closed += (s, args) => form1.Close();
                mainScreen.Show();
                mainScreen.createCourseBtn.Enabled = false;
                mainScreen.createModuleBtn.Enabled = false;
            }
        }
        #endregion

        // Adding Modules to ComboBox
        public static void AddMToCBox()
        {
            var createCourse = new CreateCourse();
            createCourse.availableModules.DataSource = ModuleDictionary.ToList();
            createCourse.availableModules.Items.Add(ModuleDictionary.Values);
        }

        public Dictionary<int,TM.Course> CourseDictionary { get; set; }

        public Dictionary<string, TM.Module> ModuleDictionary { get; set; }


        private static readonly TMEngine instance = new TMEngine();

        static TMEngine()
        {
        }

        private TMEngine()
        {
            CourseDictionary = new Dictionary<int, TM.Course>();
            ModuleDictionary = new Dictionary<string, TM.Module>();
        }

        public static TMEngine Instance
        {
            get
            {
                return instance;
            }
        }

    }
}
