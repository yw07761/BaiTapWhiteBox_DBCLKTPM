using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteBoxTests
{
    [TestClass]
    public class Bai12Test
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UT1()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float result = o.CalculatePrices(-10.0f, 5.0f, 3.0f, 2.0f);
        }
        [TestMethod]
        public void UT2()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float result = o.CalculatePrices(80.0f, 5.0f, 3.0f, 2.0f);
            Assert.AreEqual(80.0f * 5.0f, result);
        }

        [TestMethod]
        public void UT3()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float result = o.CalculatePrices(140.0f, 2.0f, 3.0f, 4.0f);
            Assert.AreEqual(100.0f * 4.0f, result);
        }

        [TestMethod]
        public void UT4()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float result = o.CalculatePrices(180.0f, 5.0f, 3.0f, 2.0f);
            Assert.AreEqual(100.0f * 5.0f + 50.0f * 3.0f + 30.0f * 2.0f, result);
        }

        

        
    }
}
