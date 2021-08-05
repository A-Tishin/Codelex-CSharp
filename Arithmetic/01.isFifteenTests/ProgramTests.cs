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
        [DataRow(1, 2, false)]
        [DataRow(0, 15, true)]
        [DataRow(15, 15, true)]
        public void IsFifteenTest_inputNums_returnBool(int a, int b, bool c)
        {
            var result = Program.IsFifteen(a, b);

            Assert.AreEqual(c, result);
        }
    }
}