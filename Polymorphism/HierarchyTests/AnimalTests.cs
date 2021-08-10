using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy.Tests
{
    [TestClass()]
    public class AnimalTests
    {
        // Arrange
        public Cat testCat = new("Cat", "Boris", 2.5, "Darzciems", "British");
        public Tiger testTiger = new("Tiger", "Nala", 135, "Pride Lands");

        [TestMethod()]
        public void MakeSoundTest_usingMethodMakeSound_returnSoundOfAnimal()
        {
            // Arrange
            var catSound = "Meowwww";
            var tigerSound = "ROAAR!!!";

            // Act
            var result = testCat.MakeSound();
            var result2 = testTiger.MakeSound();

            // Assert
            Assert.AreEqual(catSound, result);
            Assert.AreEqual(tigerSound, result2);
        }

        [TestMethod()]
        public void EatTest_inputMeat5_returnStringWithEatenQuantity()
        {
            // Arrange
            var meat = new Meat(5);
            var expected = "Cat, [Boris, British, 2,5, Darzciems, 5]";

            // Act
            var result = testCat.Eat(meat);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void EatTest_inputVegetablesForTiger_returnErr()
        {
            // Arrange
            var veg = new Vegetable(5);
            var expected = "Tiger are not eating that type of food!";

            // Act
            var result = testTiger.Eat(veg);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}