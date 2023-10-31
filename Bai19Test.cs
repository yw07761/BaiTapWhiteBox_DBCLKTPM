using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteBoxTests
{
    [TestClass]
    public class Bai19Test
    {
        [TestMethod]
        public void UT1()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            short result = o.BodyCheck(0, 80);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void UT2()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            short result = o.BodyCheck(160, -80);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void UT3()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            short result = o.BodyCheck(180, 55);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void UT4()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            short result = o.BodyCheck(160, 80);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void UT5()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            short result = o.BodyCheck(170, 70);
            Assert.AreEqual(0, result);
        }

        
    }
}
