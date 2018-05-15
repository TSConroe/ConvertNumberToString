using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertNumberToString
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetFive()
        {
            // Arrange
            int expected = 5;


            // Act
            int actual = GetWord.GetFive();

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetOneDigitNumber()
        {
            // Arrange
            string expected = "Три";


            // Act
            string actual = GetWord.GetOneDigitNumber();

            // Assert

            Assert.AreEqual(expected, actual);
        }

    }
}
