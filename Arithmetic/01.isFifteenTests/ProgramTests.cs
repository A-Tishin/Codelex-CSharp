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
        public void IsFifteenTest_input15and20_returnTrue()
        {
            int a = 15;
            int b = 20;

            var result = Program.IsFifteen(a, b);

            Assert.AreEqual(true, result);
        }
    }
}