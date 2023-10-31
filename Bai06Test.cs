using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteBoxTests
{
    [TestClass]
    public class Bai06Test
    {
        [TestMethod]
        public void UT1()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            double result = o.Average(5.0, 1.0);
            Assert.AreEqual(5.0, result);
        }

        [TestMethod]
        public void UT2()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            double result = o.Average(10.0, 5.0);
            Assert.AreEqual(2.0, result);
        }

        [TestMethod]
        public void UT3()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            double result = o.Average(10.0, 0.0);
            Assert.AreEqual(0.0, result);
        }

        
    }
}
