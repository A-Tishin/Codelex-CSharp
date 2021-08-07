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
            var car = new Car("lexus");
            var endSpeed = 1;

            car.SpeedUp();

            Assert.IsTrue(car.GetCurrentSpeed() == endSpeed);
        }

        [TestMethod()]
        public void SlowDownTest_slowDownMethod_CarSlowsDown()
        {
            var car = new Car("lexus");
            car.currentSpeed = 2;
            var endSpeed = 1;

            car.SlowDown();

            Assert.IsTrue(car.currentSpeed == endSpeed);
        }

        [TestMethod()]
        public void GetCurrentSpeedTest_Method_returnCurrentSpeed()
        {
            var car = new Car("lexus");
            car.currentSpeed = 5;

            var result = car.GetCurrentSpeed();

            Assert.AreEqual(car.currentSpeed, result);
        }

        [TestMethod()]
        public void UseNitrousOxideEngine_()
        {
            var car = new Lexus("test");
            var endSpeedAfterBoost = 3;

            car.UseNitrousOxideEngine();

            Assert.AreEqual(endSpeedAfterBoost, car.GetCurrentSpeed());
        }
    }
}