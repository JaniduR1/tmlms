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
        public void CreateCourse(string CourseName, string CourseCode, object CourseInstructor)
        {
            Course course = new Course(CourseName, CourseCode, CourseInstructor);
            TmLms.Program.tmEngine.CourseDictionary.Add(CourseCode, course);

        }

        public void CreateModule()
        {

        }

        public void DeleteCourse()
        { 
        
        }
    }
}
