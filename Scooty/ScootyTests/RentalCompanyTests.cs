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
    public class RentalCompanyTests
    {
        public RentalCompany test = new("test");

        [TestMethod()]
        public void EndRentTest()
        {
            test.AddScooter("test", .20m);
            test.StartRent("test");
            var expect = 2m;

            var result = test.EndRent("test", DateTime.Now.AddMinutes(10));

            Assert.AreEqual(expect, result);
        }

        [TestMethod()]
        public void EndRentTest2()
        {
            test.AddScooter("test", .20m);
            test.StartRent("test");
            var expect = 20m;

            var result = test.EndRent("test", DateTime.Now.AddHours(2));

            Assert.AreEqual(expect, result);
        }

        [TestMethod()]
        public void EndRentTest3()
        {
            test.AddScooter("test", .20m);
            test.StartRent("test");
            var expect = 40m;

            var result = test.EndRent("test", DateTime.Now.AddDays(1));

            Assert.AreEqual(expect, result);
        }

        [TestMethod()]
        public void CalculateIncomeTest1()
        {
            var expect = 0;

            var result = test.CalculateIncome(null, true);

            Assert.AreEqual(expect, result);
        }

        [TestMethod()]
        public void CalculateIncomeTest2()
        {
            test.AddScooter("test", .20m);
            test.accountant.AddReport(test.GetScooterById("test"), 15m);
            test.accountant.AddReport(test.GetScooterById("test"), 2.2m);
            var expect = 17.2m;

            var result = test.CalculateIncome(2021, true);

            Assert.AreEqual(expect, result);
        }
    }
}