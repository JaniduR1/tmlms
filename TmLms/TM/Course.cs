using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.TM
{
    public class Course
    {
        /// <summary>
        /// Adds a module to the course. It checks if the moudle can be added or not.
        /// </summary>
        /// <param name="moduleToAdd">The module to add</param>
        /// <param name="isCore">True if the moudle is core, else false if optional</param>
        /// <returns>True if succesfully added, False if not</returns>
        /// 

        List<Module> NonCompulsoryModules = new List<Module>();
        List<Module> CompulsoryModules = new List<Module>();

        public Course() 
        { 

        }

        public void addCompulsoryModules(Module m)
        {
            CompulsoryModules.Add(m);
        }

        public void addNonCompulsoryModules(Module m)
        {
            NonCompulsoryModules.Add(m);
        }

        public void removeCompulsoryModules(Module m)
        {
            CompulsoryModules.Remove(m);
        }

        public void removeNonCompulsoryModules(Module m)
        {
            NonCompulsoryModules.Remove(m);
        }

        public List<Module> getNonCompulsoryModules()
        {
            return NonCompulsoryModules;
        }
        public List<Module> getCompulsoryModules()
        {
            return NonCompulsoryModules;
        }


        public string CourseName
        {
            get; set; 
        }

        public string CourseCode
        {
            get; set;
        }

        public string CourseInstructor
        {
            get; set;
        }

        public Course (string name, string code, object instructor)
        {
            name = CourseName;
            code = CourseCode;
            instructor = CourseInstructor;
        }

        public static void ModuleAddition()
        {

        }
        public bool AddModule(Module moduleToAdd, bool isCore)
        {
            return false;
        }

        public void DeleteModule(Module m)
        {
            if (NonCompulsoryModules.Contains(m))
            {
                NonCompulsoryModules.Remove(m);
            }
            else if (CompulsoryModules.Contains(m))
            {
                CompulsoryModules.Remove(m);
            }
        }


    }
}
