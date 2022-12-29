using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.TM
{
    public class Module
    {
        public enum CreditEnum
        {
            TWENTY = 20,
            FORTY = 40,
            SIXTY = 60
        }

        public enum LevelEnum
        {
            FOUR = 4,
            FIVE = 5,
            SIX = 6
        }

        /// <summary>
        /// Module Code should be unique
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Module Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Module Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Level of study of the module
        /// </summary>
        public LevelEnum Level { get; set; }

        /// <summary>
        /// Credits of the module
        /// </summary>
        public CreditEnum Credits { get; set; }

        /// <summary>
        /// A sorted list to store the members associated with the module
        /// </summary>
        private SortedSet<object> Members = new SortedSet<object>();

        public void addMembers(object member)
        {
            Members.Add(member);
        }

        public SortedSet<object> getMembersList()
        {
            return Members;
        }

        public Module(string code, object AdminPerson, string name, string description, int credits, int level)
        {
            Code = code;
            Name = name;
            Description = description;
            Members.Add(AdminPerson);
            Credits = (CreditEnum)credits;
            Level = (LevelEnum)level;
        }

        /// <summary>
        /// Make sure when comparing two module objecta are different when their Code is different
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.Code.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Object", "The object trying to compare is null");
            }

            return ((Module)obj).Code == this.Code;
        }

        public bool saveModule(Module module)
        {
            TmLms.Program.tmEngine.ModuleDictionary.Add(module.Code, module);
            return true;
        }

        public bool deleteModule(Module module)
        {
            TmLms.Program.tmEngine.ModuleDictionary.Remove(module.Code);
            return true;
        }

        public void updateModule(Module module)
        {
            foreach (Module m in TMEngine.Instance.ModuleDictionary.Values)
            {
                if (m.Code.Equals(module.Code))
                {
                    Program.tmEngine.ModuleDictionary.Remove(m.Code);
                    break;
                }
                saveModule(module);
            }

        }

    }

}
