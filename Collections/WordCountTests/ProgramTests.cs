using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CalcWordsTest_inputArray_returnInt()
        {
            string[] arr = { "Test array for test purposes", "Lorem ipsum dolor sit amet, ", "consectetur adipiscing elit" };
            int wordCount = 13;

            var result = Program.CalcWords(arr);

            Assert.AreEqual(wordCount, result);
        }

        [TestMethod()]
        public void CalcCharsTest_inputArray_returnInt()
        {
            string[] arr = { "Test array for test purposes"};
            int charCount = 28;

            var result = Program.CalcChars(arr);

            Assert.AreEqual(charCount, result);
        }
    }
}