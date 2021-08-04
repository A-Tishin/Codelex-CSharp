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
        public void calculateCircleAreaTest_input7_output4398()
        {
            double rad = 7;
            double op = 43.98;

            var result = Program.calculateCircleArea(rad);

            Assert.AreEqual(op, result);
        }

        [TestMethod()]
        public void calculateRectangleAreaTest_inputTwoNums_returnProd()
        {
            double length = 10;
            double width = 5.5;
            double output = 55;

            var result = Program.calculateRectangleArea(length, width);

            Assert.AreEqual(output, result);
        }

        [TestMethod()]
        public void calculateTriangleAreaTest_inputTwoNums_returnProdDividedBy2()
        {
            double floor = 10;
            double height = 5;
            double output = 25;

            var result = Program.calculateTriangleArea(floor, height);

            Assert.AreEqual(output, result);
        }
    }
}