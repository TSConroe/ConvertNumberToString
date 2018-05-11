﻿using System;
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

    }
}
