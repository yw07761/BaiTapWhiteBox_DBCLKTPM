using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteBoxTests
{
    [TestClass]
    public class Bai13Test
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UT1()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.IsPointInRectangle(5.0f, 10.0f, 3.0f, 7.0f, -1.0f, 2.0f);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UT2()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.IsPointInRectangle(5.0f, 10.0f, 10.0f, 7.0f, 11.0f, 8.0f);
            Assert.IsFalse(result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UT3()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.IsPointInRectangle(5.0f, 10.0f, 10.0f, 7.0f, 8.0f, 5.0f);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UT4()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.IsPointInRectangle(5.0f, 10.0f, 10.0f, 7.0f, 8.0f, 15.0f);
            Assert.IsFalse(result);
        }
    }
}
