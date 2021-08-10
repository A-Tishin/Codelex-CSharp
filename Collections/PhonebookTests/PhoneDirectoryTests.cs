using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Tests
{
    [TestClass()]
    public class PhoneDirectoryTests
    {
        [TestMethod()]
        public void GetNumberTest_bookAddValidUser_returnUserNum()
        {
            // Arrange
            var user = "Aleksandrs";
            var number = "28481642";
            var book = new PhoneDirectory(user, number);

            // Act
            var result = book.GetNumber(user);

            // Assert
            Assert.AreEqual(number, result);
        }

        [TestMethod()]
        public void PutNumberTest_bookAddNewUser_bookWithUser()
        {
            // Arrange
            var book = new PhoneDirectory("Aleksandrs", "28481642");
            var newUser = "test";
            var newUserNum = "58464654";

            // Act
            book.PutNumber(newUser, newUserNum);

            // Assert
            Assert.AreEqual(newUserNum, book.GetNumber(newUser));
        }

        [TestMethod()]
        public void PutNumberTest_addSameNameNewNum_changedNum()
        {
            // Arrange
            var name = "Aleksandrs";
            var num1 = "15645616";
            var num2 = "15156516";
            var book = new PhoneDirectory(name, num1);

            // Act
            book.PutNumber(name, num2);

            // Assert
            Assert.AreEqual(num2, book.GetNumber(name));
        }
    }
}