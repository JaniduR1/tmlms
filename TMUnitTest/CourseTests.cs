using TmLms.TM;

namespace TMUnitTest
{
    public class CourseTests
    {
        //
        // My Courses are already being tested when a user is adding Data.
        // Therefor it does not allow the wrong credit limits to wrong levels through the validation.
        //

        /// <summary>
        /// A test to check that Level 4 cannot add more than the 120 module credits
        /// </summary>
        /// <param name="credits"></param>
        /// <param name="level"></param>
        [Fact]
        public void NonOptionallvl4CreditCheck()
        {
            //Arrange
            TmLms.TM.Course cource = new TmLms.TM.Course();
            TmLms.TM.Module module1 = new TmLms.TM.Module("U100", "A", "Maths", "Learn Maths", 20, 4);
            TmLms.TM.Module module2 = new TmLms.TM.Module("U101", "B", "English", "Learn English", 40, 4);
            TmLms.TM.Module module3 = new TmLms.TM.Module("U102", "C", "Science", "Learn Science", 60, 4);
            TmLms.TM.Module module4 = new TmLms.TM.Module("U103", "D", "Geog", "Learn Geog", 40, 4);
            List<Module> modules = new List<Module>();

            //Act
            bool isModuleAdded1 = cource.coreModuleCreditsLimitCheck(module1, modules);
            if (isModuleAdded1)
            {
                modules.Add(module1);
            }
            bool isModuleAdded2 = cource.coreModuleCreditsLimitCheck(module2, modules);
            if (isModuleAdded2)
            {
                modules.Add(module2);
            }
            bool isModuleAdded3 = cource.coreModuleCreditsLimitCheck(module3, modules);
            if (isModuleAdded3)
            {
                modules.Add(module3);
            }
            bool isModuleAdded4 = cource.coreModuleCreditsLimitCheck(module4, modules);

            //Assert
            Assert.True(isModuleAdded1);
            Assert.True(isModuleAdded2);
            Assert.True(isModuleAdded3);
            Assert.False(isModuleAdded4);
        }


        /// <summary>
        /// <summary>
        /// A test to check that Level 5 cannot add more than the 120 module credits
        /// </summary>
        /// <param name="credits"></param>
        /// <param name="level"></param>
        [Fact]
        public void NonOptionallvl5Allowed()
        {
            //Arrange
            TmLms.TM.Course cource = new TmLms.TM.Course();
            TmLms.TM.Module module1 = new TmLms.TM.Module("U100", "A", "Maths", "Learn Maths", 20, 5);
            TmLms.TM.Module module2 = new TmLms.TM.Module("U101", "B", "English", "Learn English", 40, 5);
            TmLms.TM.Module module3 = new TmLms.TM.Module("U102", "C", "Science", "Learn Science", 60, 5);
            TmLms.TM.Module module4 = new TmLms.TM.Module("U103", "D", "Geog", "Learn Geog", 40, 5);
            List<Module> modules = new List<Module>();

            //Act
            bool isModuleAdded1 = cource.coreModuleCreditsLimitCheck(module1, modules);
            if (isModuleAdded1)
            {
                modules.Add(module1);
            }
            bool isModuleAdded2 = cource.coreModuleCreditsLimitCheck(module2, modules);
            if (isModuleAdded2)
            {
                modules.Add(module2);
            }
            bool isModuleAdded3 = cource.coreModuleCreditsLimitCheck(module3, modules);
            if (isModuleAdded3)
            {
                modules.Add(module3);
            }
            bool isModuleAdded4 = cource.coreModuleCreditsLimitCheck(module4, modules);

            //Assert
            Assert.True(isModuleAdded1);
            Assert.True(isModuleAdded2);
            Assert.True(isModuleAdded3);
            Assert.False(isModuleAdded4);
        }


        /// <summary>
        /// <summary>
        /// A test to check that Level 6 cannot add more than the 120 module credits
        /// </summary>
        /// <param name="credits"></param>
        /// <param name="level"></param>
        [Fact]
        public void NonOptionallvl6Allowed()
        {
            //Arrange
            TmLms.TM.Course cource = new TmLms.TM.Course();
            TmLms.TM.Module module1 = new TmLms.TM.Module("U100", "A", "Maths", "Learn Maths", 20, 6);
            TmLms.TM.Module module2 = new TmLms.TM.Module("U101", "B", "English", "Learn English", 40, 6);
            TmLms.TM.Module module3 = new TmLms.TM.Module("U102", "C", "Science", "Learn Science", 60, 6);
            TmLms.TM.Module module4 = new TmLms.TM.Module("U103", "D", "Geog", "Learn Geog", 40, 6);
            List<Module> modules = new List<Module>();

            //Act
            bool isModuleAdded1 = cource.coreModuleCreditsLimitCheck(module1, modules);
            if (isModuleAdded1)
            {
                modules.Add(module1);
            }
            bool isModuleAdded2 = cource.coreModuleCreditsLimitCheck(module2, modules);
            if (isModuleAdded2)
            {
                modules.Add(module2);
            }
            bool isModuleAdded3 = cource.coreModuleCreditsLimitCheck(module3, modules);
            if (isModuleAdded3)
            {
                modules.Add(module3);
            }
            bool isModuleAdded4 = cource.coreModuleCreditsLimitCheck(module4, modules);

            //Assert
            Assert.True(isModuleAdded1);
            Assert.True(isModuleAdded2);
            Assert.True(isModuleAdded3);
            Assert.False(isModuleAdded4);
        }


        /// <summary>
        /// A test to check that Level 4 cannot add more than the optional credit limit of 20
        /// </summary>
        /// <param name="credits"></param>
        /// <param name="level"></param>
        [Fact]
        public void Optionallvl4Allowed()
        {
            //Arrange
            TmLms.TM.Course cource = new TmLms.TM.Course();
            TmLms.TM.Module module1 = new TmLms.TM.Module("U100", "Sam", "Maths", "Learn Maths", 20, 4);
            TmLms.TM.Module module2 = new TmLms.TM.Module("U101", "Sam", "Maths", "Learn Maths", 40, 4);
            TmLms.TM.Module module3 = new TmLms.TM.Module("U102", "Sam", "Maths", "Learn Maths", 60, 4);
            TmLms.TM.Module module4 = new TmLms.TM.Module("U103", "Sam", "Maths", "Learn Maths", 40, 4);
            List<Module> modules = new List<Module>();

            //Act
            bool isModuleAdded1 = cource.optionalModuleCreditCheck(module1, modules);
            if (isModuleAdded1)
            {
                modules.Add(module1);
            }
            bool isModuleAdded2 = cource.optionalModuleCreditCheck(module2, modules);
            if (isModuleAdded2)
            {
                modules.Add(module2);
            }
            bool isModuleAdded3 = cource.optionalModuleCreditCheck(module3, modules);
            if (isModuleAdded3)
            {
                modules.Add(module3);
            }
            bool isModuleAdded4 = cource.optionalModuleCreditCheck(module4, modules);

            //Assert
            Assert.True(isModuleAdded1); // Combined 20 = 20
            Assert.False(isModuleAdded2);
            Assert.False(isModuleAdded3);
            Assert.False(isModuleAdded4);
        }



        /// <summary>
        /// A test to check that Level 5 cannot add more than the optional credit limit of 40
        /// </summary>
        /// <param name="credits"></param>
        /// <param name="level"></param>
        [Fact]
        public void Optionallvl5Allowed()
        {
            //Arrange
            TmLms.TM.Course cource = new TmLms.TM.Course();
            TmLms.TM.Module module1 = new TmLms.TM.Module("U100", "Sam", "Maths", "Learn Maths", 20, 5);
            TmLms.TM.Module module2 = new TmLms.TM.Module("U101", "Sam", "Maths", "Learn Maths", 20, 5);
            TmLms.TM.Module module3 = new TmLms.TM.Module("U102", "Sam", "Maths", "Learn Maths", 60, 5);
            TmLms.TM.Module module4 = new TmLms.TM.Module("U103", "Sam", "Maths", "Learn Maths", 40, 5);
            List<Module> modules = new List<Module>();

            //Act
            bool isModuleAdded1 = cource.optionalModuleCreditCheck(module1, modules);
            if (isModuleAdded1)
            {
                modules.Add(module1);
            }
            bool isModuleAdded2 = cource.optionalModuleCreditCheck(module2, modules);
            if (isModuleAdded2)
            {
                modules.Add(module2);
            }
            bool isModuleAdded3 = cource.optionalModuleCreditCheck(module3, modules);
            if (isModuleAdded3)
            {
                modules.Add(module3);
            }
            bool isModuleAdded4 = cource.optionalModuleCreditCheck(module4, modules);

            //Assert
            Assert.True(isModuleAdded1);
            Assert.True(isModuleAdded2); // Combined 20, 20 = 40
            Assert.False(isModuleAdded3);
            Assert.False(isModuleAdded4);
        }


        /// <summary>
        /// A test to check that Level 6 cannot add more than the optional credit limit of 100
        /// </summary>
        /// <param name="credits"></param>
        /// <param name="level"></param>
        [Fact]
        public void Optionallvl6Allowed()
        {
            //Arrange
            TmLms.TM.Course cource = new TmLms.TM.Course();
            TmLms.TM.Module module1 = new TmLms.TM.Module("U100", "Sam", "Maths", "Learn Maths", 20, 6);
            TmLms.TM.Module module2 = new TmLms.TM.Module("U101", "Sam", "Maths", "Learn Maths", 20, 6);
            TmLms.TM.Module module3 = new TmLms.TM.Module("U102", "Sam", "Maths", "Learn Maths", 60, 6);
            TmLms.TM.Module module4 = new TmLms.TM.Module("U103", "Sam", "Maths", "Learn Maths", 40, 6);
            List<Module> modules = new List<Module>();

            //Act
            bool isModuleAdded1 = cource.optionalModuleCreditCheck(module1, modules);
            if (isModuleAdded1)
            {
                modules.Add(module1);
            }
            bool isModuleAdded2 = cource.optionalModuleCreditCheck(module2, modules);
            if (isModuleAdded2)
            {
                modules.Add(module2);
            }
            bool isModuleAdded3 = cource.optionalModuleCreditCheck(module3, modules);
            if (isModuleAdded3)
            {
                modules.Add(module3);
            }
            bool isModuleAdded4 = cource.optionalModuleCreditCheck(module4, modules);

            //Assert
            Assert.True(isModuleAdded1);
            Assert.True(isModuleAdded2);
            Assert.True(isModuleAdded3); // Combined 20,20,60 = 100
            Assert.False(isModuleAdded4);
        }


        /// <summary>
        /// A test to make sure that a course does not exceed 360 Credits.
        /// The course class should only add modules as core or option
        /// Everytime a module is added the course should add all core module credits
        /// and make sure they do not exceedd 360. If an optional module exists it should
        /// only be added in the credit count for the appropriate level. If an optional 
        /// </summary>
        //[Theory]
        //[InlineData(20, true, 4)]
        //[InlineData(20, false, 4)]
        //[InlineData(20, true, 5)]
        //[InlineData(20, false, 5)]
        //[InlineData(20, true, 6)]
        //[InlineData(20, false, 6)]
        //public void NotExceedingCredits(int Credits, bool IsCore, int Level)
        //{
        //    // Arrange
        //    TmLms.TM.Course cource = new TmLms.TM.Course();
        //    for (int i = 4; i < 7; i++)
        //    {
        //        TmLms.TM.Module module1 = new TmLms.TM.Module("U100", "");
        //        module1.Credits = TmLms.TM.Module.CreditEnum.SIXTY;
        //        module1.Level = (TmLms.TM.Module.LevelEnum)i;

        //        TmLms.TM.Module module2 = new TmLms.TM.Module("U101", "");
        //        module2.Credits = TmLms.TM.Module.CreditEnum.SIXTY;
        //        module2.Level = (TmLms.TM.Module.LevelEnum)i;
        //        cource.AddModule(module1, true);
        //        cource.AddModule(module2, true);
        //    }
        //    // Act
        //    TmLms.TM.Module moduleToAdd = new TmLms.TM.Module("U100", "");
        //    moduleToAdd.Credits = (TmLms.TM.Module.CreditEnum)  Credits;
        //    moduleToAdd.Level = (TmLms.TM.Module.LevelEnum) Level;
        //    bool isModuleAdded = cource.AddModule(moduleToAdd, IsCore);

        //    // Assert
        //    Assert.False(isModuleAdded);
        //}
    }
}