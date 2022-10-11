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
