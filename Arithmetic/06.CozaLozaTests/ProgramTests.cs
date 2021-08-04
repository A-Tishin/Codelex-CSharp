using Microsoft.VisualStudio.TestTools.UnitTesting;
using CozaLoza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaLoza.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        [DataRow(1,  "1")]
        [DataRow(3,  "Coza")]
        [DataRow(5,  "Loza")]
        [DataRow(15,  "CozaLoza")]

        public void CozaLozaTest_inputNum_outputCozaLoza(int a, string b)
        {
            var result = Program.CozaLoza(a);

            Assert.AreEqual(b, result);
        }
    }
}