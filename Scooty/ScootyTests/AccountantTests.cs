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
    public class AccountantTests
    {
        public RentalCompany test = new RentalCompany("test");

        [TestMethod()]
        public void CalcSessionPriceTest_inputShortScooterSession_returnPriceOfSession()
        {
            test.AddScooter("test", .10m);
            var start = new DateTime(1, 1, 1, 20, 15, 00);
            var end = new DateTime(1, 1, 1, 20, 28, 00);
            var expect = 1.3m;

            var result = test.accountant.CalcSessionPrice(test.GetScooterById("test"), start, end);

            Assert.AreEqual(expect, result);
        }

        [TestMethod()]
        public void CalcSessionPriceTest_inputLongScooterSession_returnTotalPriceOfSession()
        {
            test.AddScooter("test", .18m);
            var start = new DateTime(1, 1, 1, 23, 15, 00);
            var end = new DateTime(1, 1, 3, 01, 12, 00);
            var expect = 40.88m;

            var result = test.accountant.CalcSessionPrice(test.GetScooterById("test"), start, end);

            Assert.AreEqual(expect, result);
        }
    }
}