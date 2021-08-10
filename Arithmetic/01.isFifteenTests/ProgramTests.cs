using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsFifteen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsFifteen.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        [DataRow(25, 10, true)]
        [DataRow(10, 5, true)]
        [DataRow(15, 15, true)]
        public void IsFifteenTest_inputNumEqualOrSumOrDiff15_returnTrue(int a, int b, bool c)
        {
            // Act
            var result = Program.IsFifteen(a, b);

            // Assert
            Assert.AreEqual(c, result);
        }

        [TestMethod()]
        [DataRow(1, 2, false)]
        [DataRow(14, 6, false)]
        [DataRow(0, 0, false)]
        public void IsFifteenTest_inputNumNotEqualOrSumOrDiff15_returnFalse(int a, int b, bool c)
        {
            // Act
            var result = Program.IsFifteen(a, b);

            // Assert
            Assert.AreEqual(c, result);
        }
    }
}