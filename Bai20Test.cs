using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteBoxTests
{
    [TestClass]
    public class Bai20Test
    {

        [TestMethod]
        public void UT1()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            int result = o.IsInString('a', "");
            Assert.AreEqual(32767, result);
        }

        [TestMethod]
        public void UT2()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            int result = o.IsInString('e', "xample");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void UT3()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            int result = o.IsInString('z', "example");
            Assert.AreEqual(32767, result);
        }

        [TestMethod]
        public void UT4()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            int result = o.IsInString('a', "example");
            Assert.AreEqual(0, result);
        }

        
    }
}
