using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteBoxTests
{
    [TestClass]
    public class Bai17Test
    {
        
        [TestMethod]
        public void UT1()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.IsValidDate(2023, 0, 20);
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void UT2()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.IsValidDate(2023, 7, 0);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UT3()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.IsValidDate(2023, 10, 32);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UT4()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            bool result = o.IsValidDate(2023, 7, 7);
            Assert.IsTrue(result);
        }

    }
}
