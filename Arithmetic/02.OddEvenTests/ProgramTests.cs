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

        // Arrange
        [DataRow(0, true)]
        [DataRow(12, true)]
        [DataRow(36, true)]
        public void CheckOddEvenTest_inputEvenNum_returnTrue(int num, bool isOdd)
        {
            // Act
            var result = Program.CheckOddEven(num);

            // Assert
            Assert.AreEqual(isOdd, result);
        }

        [TestMethod()]

        // Arrange
        [DataRow(1, false)]
        [DataRow(11, false)]
        [DataRow(21, false)]
        public void CheckOddEvenTest_inputOddNum_returnFalse(int num, bool isOdd)
        {
            // Act
            var result = Program.CheckOddEven(num);

            // Assert
            Assert.AreEqual(isOdd, result);
        }
    }
}