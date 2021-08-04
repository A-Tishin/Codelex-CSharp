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
        public void CalcFinalPositionTest_inputParams_outputFallDistance()
        {
            const double gravity = -9.81;
            double initialVelocity = 0.0;
            double initialPosition = 5.0;
            double fallingTime = 10;
            double fallDistance = -485.5;

            var result = Program.CalcFinalPosition(gravity, initialVelocity, initialPosition, fallingTime);

            Assert.AreEqual(fallDistance, result);
        }
    }
}