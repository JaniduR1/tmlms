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

        public bool coreModuleCreditsLimitCheck(Module moduleToBeAdd, List<Module> CompulsoryModules)
        {
            int totCreditCount = 0;
            foreach (Module m in CompulsoryModules)
            {
                totCreditCount += Convert.ToInt32(m.Credits);
            }
            totCreditCount += Convert.ToInt32(moduleToBeAdd.Credits);
            MessageBox.Show("" + Convert.ToInt32(moduleToBeAdd.Credits));
            if (totCreditCount > 120)
            {
                MessageBox.Show("Core Modules Can not Exceed 120 credit Limit");
                return false;
            }
            else
            {
                CompulsoryModules.Add(moduleToBeAdd);
                return true;
            }
        }

        public bool optionalModuleCreditCheck(Module moduleToBeAdd, List<Module> NonCompulsoryModules)
        {
            int totCreditCountl4 = 0;
            int totCreditCountl5 = 0;
            int totCreditCountl6 = 0;
            foreach (Module m in NonCompulsoryModules)
            {
                if (m.Level == Module.LevelEnum.FOUR)
                {
                    totCreditCountl4 += Convert.ToInt32(m.Credits);
                }
                else if (m.Level == Module.LevelEnum.FIVE)
                {
                    totCreditCountl5 += Convert.ToInt32(m.Credits);
                }
                else if (m.Level == Module.LevelEnum.SIX)
                {
                    totCreditCountl6 += Convert.ToInt32(m.Credits);
                }

            }
            switch (moduleToBeAdd.Level)
            {
                case Module.LevelEnum.FOUR:
                    totCreditCountl4 += Convert.ToInt32(moduleToBeAdd.Credits);
                    if (totCreditCountl4 > 20)
                    {
                        MessageBox.Show("Optional Modules Can not Exceed 20 credit Limit For Level 4 Modules");
                        return false;
                    }
                    else
                    {
                        NonCompulsoryModules.Add(moduleToBeAdd);
                        return true;
                    }

                case Module.LevelEnum.FIVE:
                    totCreditCountl5 += Convert.ToInt32(moduleToBeAdd.Credits);
                    if (totCreditCountl5 > 40)
                    {
                        MessageBox.Show("Optional Modules Can not Exceed 40 credit Limit For Level 5 Modules");
                        return false;
                    }
                    else
                    {
                        NonCompulsoryModules.Add(moduleToBeAdd);
                        return true;
                    }

                case Module.LevelEnum.SIX:
                    totCreditCountl6 += Convert.ToInt32(moduleToBeAdd.Credits);
                    if (totCreditCountl6 > 100)
                    {
                        MessageBox.Show("Optional Modules Can not Exceed 100 credit Limit For Level 6 Modules");
                        return false;
                    }
                    else
                    {
                        NonCompulsoryModules.Add(moduleToBeAdd);
                        return true;
                    }
                default: return false;
            }
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
