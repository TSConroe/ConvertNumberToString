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
            string expected = "три";
            int transmitted = 3;


            // Act
            string actual = GetWord.GetOneDigitNumber(transmitted);

            // Assert

            Assert.AreEqual(expected, actual);
        }

    }
}
