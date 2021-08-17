using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scooty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scooty.Tests
{
    [TestClass()]
    public class ScooterServiceTests
    {
        public RentalCompany test = new RentalCompany("test");

        [TestMethod()]
        public void RemoveScooterTest()
        {
            test.AddScooter("test", .20m);
            test.RemoveScooter("test");
            var expect = 0;

            var result = test.GetScooters().Count;

            Assert.AreEqual(expect, result);
        }

        [TestMethod()]
        public void RemoveScooterTest_tryRemoveScooterInRent_GetFullListWORemoving()
        {
            test.AddScooter("test", .20m);
            test.StartRent("test");
            test.RemoveScooter("test");
            var expect = 1;

            var result = test.GetScooters().Count;

            Assert.AreEqual(expect, result);
        }
    }
}