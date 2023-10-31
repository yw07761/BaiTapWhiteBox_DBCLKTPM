using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteBoxTests
{
    [TestClass]
    public class Bai15Test
    {
        [TestMethod]
        public void UT1()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.IsLeapYear(2024);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UT2()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.IsLeapYear(2000);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UT3()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.IsLeapYear(2022);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UT4()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.IsLeapYear(5000);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UT5()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.IsLeapYear(10001);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UT6()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.IsLeapYear(999);
            Assert.IsFalse(result);
        }
    }
}
