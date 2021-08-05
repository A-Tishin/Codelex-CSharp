using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        [DataRow(10, "62,83")]
        [DataRow(7, "43,98")]
        [DataRow(-5, "Radius must be positive.")]
        public void calculateCircleAreaTest_input7_output4398(double rad, string area)
        {
            var result = Program.calculateCircleArea(rad);

            Assert.AreEqual(area, result);
        }

        [TestMethod()]
        [DataRow(5, 10, "50")]
        [DataRow(5, -10, "Values must be positive")]
        [DataRow(10, 0, "0")]
        public void calculateRectangleAreaTest_inputTwoNums_returnProd(double width, double height, string area)
        {
            var result = Program.calculateRectangleArea(width, height);

            Assert.AreEqual(area, result);
        }

        [TestMethod()]
        [DataRow(5, 2, "5")]
        [DataRow(10, 50, "250")]
        [DataRow(-5, 10, "Values must be positive")]
        public void calculateTriangleAreaTest_inputTwoNums_returnProdDividedBy2(double ground, double height, string area)
        {
            var result = Program.calculateTriangleArea(ground, height);

            Assert.AreEqual(area, result);
        }
    }
}