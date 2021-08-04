using Microsoft.VisualStudio.TestTools.UnitTesting;
using OddEven;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CheckOddEvenTest_inputOdd_returnTrue()
        {
            bool exp = true;

            var result = Program.CheckOddEven(15);

            Assert.AreEqual(exp, result);
        }
    }
}