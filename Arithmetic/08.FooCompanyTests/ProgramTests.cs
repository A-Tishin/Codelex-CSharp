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
        public void CheckLegalityAndSalaryTest_inputTestEmployee_outputSalary500()
        {
            var mario = new Employee(25, 20);
            string output = "500";

            var result = Program.CheckLegalityAndSalary(mario);

            Assert.AreEqual(output, result);
        }
    }
}