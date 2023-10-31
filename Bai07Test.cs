using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteBoxTests
{
    [TestClass]
    public class Bai07Test
    {
        [TestMethod]
        public void UT1()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            byte result = o.DaysInMonth(2023, 7);
            Assert.AreEqual(31, result);
        }

        [TestMethod]
        public void UT2()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            byte result = o.DaysInMonth(2024, 14);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void UT3()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            byte result = o.DaysInMonth(2023, 6);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void UT4()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            byte result = o.DaysInMonth(2022, 2);
            Assert.AreEqual(29, result);
        }

        [TestMethod]
        public void UT5()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            byte result = o.DaysInMonth(1600, 2);
            Assert.AreEqual(28, result);
        }

        [TestMethod]
        public void UT6()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            byte result = o.DaysInMonth(1940, 2);
            Assert.AreEqual(29, result);
        }

        [TestMethod]
        public void UT7()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            byte result = o.DaysInMonth(2023, 2);
            Assert.AreEqual(28, result);
        }

    }
}
