using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InsertNumberTask;

namespace InsertNumberTask
{
    [TestClass]
    public class NumberTest
    {
        [TestMethod]
        public void TestingInsertNumber1()
        {
            int actual = InsertingNumbers.InsertNumber(15, 15, 0, 0);
            Assert.AreEqual(15, actual);
        }

        [TestMethod]
        public void TestingInsertNumber2()
        {
            int actual = InsertingNumbers.InsertNumber(8, 15, 0, 0);
            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void TestingInsertNumber3()
        {
            int actual = InsertingNumbers.InsertNumber(8, 15, 3, 8);
            Assert.AreEqual(120, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCase1_OutOfRange()
        => InsertingNumbers.InsertNumber(8, 15, -7, 0);

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCase2_OutOfRange()
        => InsertingNumbers.InsertNumber(8, 15, 7, 1);
    }
}
