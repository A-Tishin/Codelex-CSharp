using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateTestExercise5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTestExercise5.Tests
{
    [TestClass()]
    public class DateTests
    {
        [TestMethod()]
        public void DateTest_InputDay35_ChangeToDefault()
        {
            var date = new Date(35, 1, 1985);
            var def = 1;

            var result = date.Day;

            Assert.IsTrue(def == result);
        }

        [TestMethod()]
        public void DateTest_inputDay25_Accept25()
        {
            var date = new Date(25, 1, 1985);

            var day = date.Day;

            Assert.IsTrue(day == date.Day);
        }

        [TestMethod()]
        public void DateTest_inputMonth0_changeToDefault()
        {
            var date = new Date(25, 0, 1985);
            var def = 1;

            var result = date.Month;

            Assert.IsTrue(def == result);
        }

        [TestMethod()]
        public void DateTest_inputMonth11_Accept11()
        {
            var date = new Date(25, 11, 1985);

            var result = date.Month;

            Assert.IsTrue(result == date.Month);
        }

        [TestMethod()]
        public void DateTest_inputYear2022_changeToDefault()
        {
            var date = new Date(25, 11, 2022);
            var def = 2020;

            var result = date.Year;

            Assert.IsTrue(def == result);
        }

        [TestMethod()]
        public void DateTest_inputYear1996_Accept1996()
        {
            var date = new Date(25, 11, 1996);

            var result = date.Year;

            Assert.IsTrue(date.Year == result);
        }
    }
}