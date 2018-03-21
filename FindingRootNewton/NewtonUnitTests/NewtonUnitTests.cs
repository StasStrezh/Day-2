using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindingRootNewton;

namespace FindingRootNewton
{
    /// <summary>
    /// Unit Tests for Newtons method
    /// </summary>
    [TestClass]
    public class NewtonUnitTests
    {
        [TestMethod]
        public void TestCase1()
        {

            double test;
            test = FindNthRoot.Newton(1.0, 5.0, 0.0001);

            Assert.AreEqual(test, 1.0, 1);

        }

        [TestMethod]
        public void TestCase2()
        {
            double test;
            test = FindNthRoot.Newton(8.0, 3.0, 0.0001);
            Assert.AreEqual(test, 2.0, 1);

        }
        [TestMethod]
        public void TestCase3()
        {
            double test;
            test = FindNthRoot.Newton(0.001, 3.0, 0.0001);
            Assert.AreEqual(test, 0.1, 1);


        }
        [TestMethod]
        public void TestCase4()
        {
            double test;
            test = FindNthRoot.Newton(0.04100625, 4, 0.0001);
            Assert.AreEqual(test, 0.45, 1);
        }
        [TestMethod]
        public void TestCase5()
        {
            double test;

            test = FindNthRoot.Newton(8, 3, 0.0001);
            Assert.AreEqual(test, 2.0, 1);

        }
        [TestMethod]
        public void TestCase6()
        {
            double test;
            test = FindNthRoot.Newton(0.0279936, 7, 0.0001);
            Assert.AreEqual(test, 0.6, 1);

        }
        [TestMethod]
        public void TestCase7()
        {
            double test;
            test = FindNthRoot.Newton(0.0081, 4, 0.1);
            Assert.AreEqual(test, 0.3, 1);
        }
        [TestMethod]
        public void TestCase8()
        {
            double test;
            test = FindNthRoot.Newton(-0.008, 3, 0.1);
            Assert.AreEqual(test, -0.2, 1);
        }
        [TestMethod]
        public void TestCase9()
        {
            double test;
            test = FindNthRoot.Newton(0.004241979, 9, 0.00000001);
            Assert.AreEqual(test, 0.545, 0.1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCase10_OutOfRange()
        => FindNthRoot.Newton(8, 15, -7);

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCase11_OutOfRange()
            => FindNthRoot.Newton(8, 15, -0.6);

    }
}
