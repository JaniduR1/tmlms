using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmLms.TM;

namespace TmLms.Users
{
    internal class Administrator : Person
    {
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

        public void CreateModule(string code, object AdminPerson, string name, string description, int credits, int level)
        {
            if (TmLms.Program.tmEngine.ModuleDictionary.ContainsKey(code))
            {
                MessageBox.Show("There is already a module code that exist with that given input please change it.");
            }
            else
            {
                Module module = new Module(code, AdminPerson, name, description, credits, level);
                module.saveModule(module);
                MessageBox.Show("Done!");
            }

        }

        public string MCode
        {
            get; set;
        }

        public void DeleteCourse(string courseCode)
        {
            MessageBox.Show("Deleted the course with the code " + courseCode);
            TmLms.Program.tmEngine.CourseDictionary.Remove(courseCode);
        }

        public void DeleteModule(string moduleCode)
        {
            TmLms.Program.tmEngine.ModuleDictionary.Remove(moduleCode);
            MessageBox.Show("Deleted the module with the code " + moduleCode);
        }
    }
}
