using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebook;

namespace PhoneBook.Tests
{
    [TestClass()]
    public class PhoneDirectoryTests
    {
        [TestMethod()]
        public void GetNumberTest_bookAddUser_returnUserNum()
        {
            var user = "Aleksandrs";
            var number = "28481642";
            var book = new PhoneDirectory(user, number);

            var result = book.GetNumber(user);

            Assert.AreEqual(number, result);
        }

        [TestMethod()]
        public void PutNumberTest_bookAddNewUser_bookWithUser()
        {
            var book = new PhoneDirectory("Aleksandrs", "28481642");
            var newUser = "test";
            var newUserNum = "58464654";

            book.PutNumber(newUser, newUserNum);

            Assert.AreEqual(newUserNum, book.GetNumber(newUser));
        }

        [TestMethod()]
        public void PutNumberTest_addSameNameNewNum_changedNum()
        {
            var name = "Aleksandrs";
            var num1 = "15645616";
            var num2 = "15156516";
            var book = new PhoneDirectory(name, num1);

            book.PutNumber(name, num2);

            Assert.AreEqual(num2, book.GetNumber(name));
        }
    }
}