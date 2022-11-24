using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmLms.TM;

namespace TmLms.Users
{
    internal class Administrator
    {

        public string MCode
        {
            get; set;
        }

        public void CreateCourse(string CourseName, string CourseCode, object CourseInstructor)
        {
            if (TmLms.Program.tmEngine.CourseDictionary.ContainsKey(CourseCode))
            {
                MessageBox.Show("There is already a course code that exist with that given input please change it.");
            }
            else
            {
                Course ccourse = new Course(CourseName, CourseCode, CourseInstructor);
                TmLms.Program.tmEngine.CourseDictionary.Add(CourseCode, ccourse);
            }

        }

        public void CreateModule()
        {

        }

        public void DeleteCourse(string ModuleCode)
        {
            MCode = ModuleCode;

            if (ModuleCode != null)
            {
                TMEngine.Instance.ModuleDictionary.Remove(ModuleCode);
                TmLms.Program.tmEngine.ModuleDictionary.Remove(ModuleCode);
            }
            else
            {
                MessageBox.Show("No Module Selected to Delete");
            }
        }
    }
}
