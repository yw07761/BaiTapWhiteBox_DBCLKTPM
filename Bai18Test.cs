using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteBoxTests
{
    [TestClass]
    public class Bai18Test
    {
        [TestMethod]
        public void UT1()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.EmailCheck("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UT2()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.EmailCheck("user@example.com");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UT3()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.EmailCheck("userexample.com");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UT4()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.EmailCheck("user@example..com");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UT5()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.EmailCheck("user@exa@mple..com");
            Assert.IsFalse(result);
        }
    }
}
