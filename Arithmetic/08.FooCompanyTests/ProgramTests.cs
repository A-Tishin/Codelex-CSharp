using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _8.FooCompany;

namespace FooCompany.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CheckLegalityAndSalaryTest_inputEmployeeAllInputValid_outputSalary()
        {
            // Arrange
            var mario = new Employee(25, 20);
            string output = "500";

            // Act
            var result = Program.CheckLegalityAndSalary(mario);

            // Assert
            Assert.AreEqual(output, result);
        }

        [TestMethod()]
        public void CheckLegalityAndSalaryTest_inputEmployeeTooSmallHourSalary_returnError()
        {
            // Arrange
            var mario = new Employee(7, 45);
            string output = "Error!";

            // Act
            var result = Program.CheckLegalityAndSalary(mario);

            // Assert
            Assert.AreEqual(output, result);
        }

        [TestMethod()]
        public void CheckLegalityAndSalaryTest_inputEmployeeTooMuchHours_returnError()
        {
            // Arrange
            var mario = new Employee(10, 75);
            string output = "Error!";

            // Act
            var result = Program.CheckLegalityAndSalary(mario);

            // Assert
            Assert.AreEqual(output, result);
        }
    }
}