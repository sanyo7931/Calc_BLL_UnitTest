using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calc.BLL.UnitTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestAdd()
        {
            ICalc c = new Cal();

            int expected = 5;

            int actual = c.Add(2, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSub()
        {
            ICalc c = new Cal();

            int expected = 0;

            int actual = c.Sub(-5, -5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMul()
        {
            ICalc c = new Cal();

            int expected = 50;

            int actual = c.Mul(10, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDiv()
        {
            ICalc c = new Cal();

            int expected = 2;

            int actual = c.Div(10, 5);

            Assert.AreEqual(expected, actual);
        }
    }
}
