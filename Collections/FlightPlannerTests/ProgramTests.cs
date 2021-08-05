using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlightPlanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace FlightPlanner.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetRoutesTest_inputArr_returnDictionary()
        {
            string[] arr = { "San Jose -> San Francisco", "San Jose -> Anchorage" };
            var key = "San Jose";
            var list = new List<string>() { "San Francisco", "Anchorage" };

            var result = Program.GetRoutes(arr);

            Assert.AreEqual(true, result.ContainsKey(key));
            Assert.AreEqual(list[0], result[key][0]);
            Assert.AreEqual(list[1], result[key][1]);
        }

        [TestMethod()]
        public void GetCitiesTest_inputArrCount4_returnHashSetCount3()
        {
            string[] arr = { "San Jose", "San Francisco", "San Jose", "Anchorage" };
            int hashSetCount = 3;

            var result = Program.GetCities(arr);

            Assert.AreEqual(hashSetCount, result.Count);
        }

    }
}