using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertNumberToString
{
    [TestClass]
    public class UnitTest1 : GetWord
    {
      

        [TestMethod]
        public void TestGetOneDigitNumber()
        {
            // Arrange
            string expected = "три";
            int transmitted = 3;
            GetWord testObj = new GetWord();


            // Act
            string actual = testObj.GetOneDigitNumber(transmitted);

            // Assert

            Assert.AreEqual(expected, actual);
        }

    }
}
