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
        public void CalculateCircleAreaTest_inputRadius_returnAreaOrErrorIfNegative(double rad, string area)
        {
            // Act
            var result = Program.calculateCircleArea(rad);

            // Assert
            Assert.AreEqual(area, result);
        }

        [TestMethod()]
        [DataRow(5, 10, "50")]
        [DataRow(5, -10, "Values must be positive")]
        [DataRow(10, 0, "0")]
        public void CalculateRectangleAreaTest_inputWidthAndHeight_returnAreaOrErrorIfNegative(double width, double height, string area)
        {
            // Act
            var result = Program.calculateRectangleArea(width, height);

            // Assert
            Assert.AreEqual(area, result);
        }

        [TestMethod()]
        [DataRow(5, 2, "5")]
        [DataRow(10, 50, "250")]
        [DataRow(-5, 10, "Values must be positive")]
        public void CalculateTriangleAreaTest_inputGroundAndHeight_returnAreaOrErrorIfNegative(double ground, double height, string area)
        {
            // Act
            var result = Program.calculateTriangleArea(ground, height);

            // Assert
            Assert.AreEqual(area, result);
        }
    }
}