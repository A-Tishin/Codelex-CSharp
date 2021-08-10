using Microsoft.VisualStudio.TestTools.UnitTesting;
using DragRace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client.Interfaces;

namespace DragRace.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void SpeedUpTest()
        {
            // Arrange
            var car = new Car("lexus");
            var endSpeed = 1;

            // Act
            car.SpeedUp();

            // Assert
            Assert.IsTrue(car.GetCurrentSpeed() == endSpeed);
        }

        [TestMethod()]
        public void SlowDownTest_slowDownMethod_CarSlowsDown()
        {
            // Arrange
            var car = new Car("lexus");
            car.currentSpeed = 2;
            var endSpeed = 1;

            // Act
            car.SlowDown();

            // Assert
            Assert.IsTrue(car.currentSpeed == endSpeed);
        }

        [TestMethod()]
        public void GetCurrentSpeedTest_Method_returnCurrentSpeed()
        {
            // Arrange
            var car = new Car("lexus");
            car.currentSpeed = 5;

            // Act
            var result = car.GetCurrentSpeed();

            // Assert
            Assert.AreEqual(car.currentSpeed, result);
        }

        [TestMethod()]
        public void UseNitrousOxideEngine_()
        {
            // Arrange
            var car = new Lexus("test");
            var endSpeedAfterBoost = 3;

            // Act
            car.UseNitrousOxideEngine();

            // Assert
            Assert.AreEqual(endSpeedAfterBoost, car.GetCurrentSpeed());
        }
    }
}