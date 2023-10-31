using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBox.Tests
{
    [TestClass()]
    public class Bai01Tests
    {
        [TestMethod()]
        public void TestDistanceIsZeroAndRadiiAreEqual()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            int result = o.getPositionOf2Cir(5, 5, 0);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestDistanceIsZeroAndFirstRadiusIsSmaller()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            int result = o.getPositionOf2Cir(3, 5, 0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestDistanceIsZeroAndSecondRadiusIsSmaller()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            int result = o.getPositionOf2Cir(7, 5, 0);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestDistanceIsGreaterThanZero()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            int result = o.getPositionOf2Cir(5, 5, 10);
            Assert.AreEqual(3, result);
        }

       

    }
}