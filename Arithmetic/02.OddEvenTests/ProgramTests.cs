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
        [DataRow(0, false)]
        [DataRow(11, true)]
        [DataRow(36, false)]
        public void CheckOddEvenTest_inputOdd_returnTrue(int num, bool isOdd)
        {
            var result = Program.CheckOddEven(num);

            Assert.AreEqual(isOdd, result);
        }
    }
}