using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteBoxTests
{
    [TestClass]
    public class Bai16Test
    {
        [TestMethod]
        public void UT1()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.PasswordCheck("Xxxx0");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UT2()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.PasswordCheck("Xxxxxxxxxxxxx0");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UT3()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.PasswordCheck("xxxx0000");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UT4()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.PasswordCheck("xxxxxxxx");
            Assert.IsFalse(result);
        }
    }
}
