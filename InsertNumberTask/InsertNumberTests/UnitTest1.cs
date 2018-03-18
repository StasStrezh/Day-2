using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static InsertNumberTask.InsertingNumbers;

namespace InsertNumberTests
{
    [TestClass]
    public class NumberTest
    {
        [TestMethod]
        public void TestingInsertNumber1()
        {
            int number1 = 15;
            int number2 = 15;
            int i = 0;
            int j = 0;
            int expected = 15;

            int actual = InsertNumber(number1, number2, i, j);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingInsertNumber2()
        {
            int number1 = 8;
            int number2 = 15;
            int i = 0;
            int j = 0;
            int expected = 9;

            int actual = InsertNumber(number1, number2, i, j);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestingInsertNumber3()
        {
            int number1 = 8;
            int number2 = 15;
            int i = 3;
            int j = 8;
            int expected = 120;

            int actual = InsertNumber(number1, number2, i, j);
            Assert.AreEqual(expected, actual);
        }


    }
}
