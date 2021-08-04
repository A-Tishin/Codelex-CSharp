using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetChangedArrayTest_inputArray_returnModArray()
        {
            int num = -7;
            int[] testArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] testArr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, -7 };

            int[] arr = Program.GetChangedArray(testArr);

            Assert.AreEqual(arr[9], num);
            for (var i = 0; i < 10; i++)
            {
                Assert.AreEqual(testArr2[i], arr[i]);
            }
        }
    }
}