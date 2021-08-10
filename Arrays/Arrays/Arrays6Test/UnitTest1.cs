using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arrays6Test
{
    [TestClass]
    class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num = -7;
            int[] arr1 = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            int[] arr = GetChangedArray(arr1);

        }
    }
}
