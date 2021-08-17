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
        public void EndRentTest_inputRentForThreeHours_returnFlooredBill()
        {
            test.AddScooter("test", .20m);
            test.GetScooterById("test").SessionStart = new DateTime(1, 1, 1, 00, 00, 00);
            var end = new DateTime(1, 1, 1, 03, 00, 00);
            var expect = 20m;

            var result = test.EndRent("test", end);

            Assert.AreEqual(expect, result);
        }

        [TestMethod()]
        public void EndRentTest_inputTwoDayRental_returnFlooredAndSummedBill()
        {
            test.AddScooter("test", .20m);
            test.GetScooterById("test").SessionStart = new DateTime(1, 1, 1, 01, 00, 00);
            var end = new DateTime(1, 1, 3, 01, 00, 00);
            var expect = 52m;

            var result = test.EndRent("test", end);

            Assert.AreEqual(expect, result);
        }

        [TestMethod()]
        public void CalculateIncomeTest_inputEmptyList_returnNoIncome()
        {
            var expect = 0;

            var result = test.CalculateIncome(null, true);

            Assert.AreEqual(expect, result);
        }

        [TestMethod()]
        public void CalculateIncomeTest_inputReports_returnSumOfBills()
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