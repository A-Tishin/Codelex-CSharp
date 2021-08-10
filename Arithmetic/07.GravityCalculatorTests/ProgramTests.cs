using Microsoft.VisualStudio.TestTools.UnitTesting;
using GravityCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravityCalculator.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CalcFinalPositionTest_inputValidParams_returnFallDistance()
        {
            // Arrange
            const double gravity = -9.81;
            double initialVelocity = 0.0;
            double initialPosition = 5.0;
            double fallingTime = 10;
            var fallDistance = "-485,5";

            // Act
            var result = Program.CalcFinalPosition(gravity, initialVelocity, initialPosition, fallingTime);

            // Assert
            Assert.AreEqual(fallDistance, result);
        }

        [TestMethod()]
        public void CalcFinalPositionTest_inputNegativeParams_returnError()
        {
            // Arrange
            const double gravity = -9.81;
            double initialVelocity = -5;
            double initialPosition = -10;
            double fallingTime = 0;
            var fallDistance = "All data must be positive";

            // Act
            var result = Program.CalcFinalPosition(gravity, initialVelocity, initialPosition, fallingTime);

            // Assert
            Assert.AreEqual(fallDistance, result);
        }
    }
}