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

        // Arrange
        [DataRow(1, "1")]
        [DataRow(8, "8")]
        [DataRow(26, "26")]
        public void CozaLozaTest_inputNum_returnNum(int a, string b)
        {
            // Act
            var result = Program.CozaLoza(a);

            // Assert
            Assert.AreEqual(b, result);
        }

        [TestMethod()]

        // Arrange
        [DataRow(3, "Coza")]
        [DataRow(9, "Coza")]
        [DataRow(27, "Coza")]
        public void CozaLozaTest_inputDivBy3_returnCoza(int a, string b)
        {
            // Act
            var result = Program.CozaLoza(a);

            // Assert
            Assert.AreEqual(b, result);
        }

        [TestMethod()]

        // Arrange
        [DataRow(5, "Loza")]
        [DataRow(25, "Loza")]
        [DataRow(55, "Loza")]
        public void CozaLozaTest_inputDivBy5_returnLoza(int a, string b)
        {
            // Act
            var result = Program.CozaLoza(a);

            // Assert
            Assert.AreEqual(b, result);
        }

        [TestMethod()]

        // Arrange
        [DataRow(7, "Woza")]
        [DataRow(28, "Woza")]
        [DataRow(49, "Woza")]
        public void CozaLozaTest_inputDivBy7_returnWoza(int a, string b)
        {
            // Act
            var result = Program.CozaLoza(a);

            // Assert
            Assert.AreEqual(b, result);
        }

        [TestMethod()]
        public void CozaLozaTest_inputDivBy15_returnCozaLoza()
        {
            // Arrange
            var a = 15;
            var expect = "CozaLoza";

            // Act
            var result = Program.CozaLoza(a);

            // Assert
            Assert.AreEqual(expect, result);
        }
    }
}