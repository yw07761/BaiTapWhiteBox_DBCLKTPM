using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteBoxTests
{
    [TestClass]
    public class Bai11Test
    {
        [TestMethod]
        public void TestValidAlignment()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float x, y;
            o.AlignPic(10, 20, 30, 40, out x, out y);
            Assert.AreEqual(10.0f, x);
            Assert.AreEqual(10.0f, y);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestInvalidAlignment()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float x, y;
            o.AlignPic(-10, 20, 30, 40, out x, out y);
            Assert.AreEqual(10.0f, x);
            Assert.AreEqual(10.0f, y);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestAlignLeftAndTop()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float x, y;
            o.AlignPic(10, 20, 30, 40, out x, out y);
            Assert.AreEqual(0.0f, x);
            Assert.AreEqual(0.0f, y);
        }

        [TestMethod]
        public void TestAlignCenterAndTop()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float x, y;
            o.AlignPic(30, 20, 30, 40, out x, out y);
            Assert.AreEqual(0.0f, x);
            Assert.AreEqual(10.0f, y);
        }

        [TestMethod]
        public void TestAlignLeftAndMiddle()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float x, y;
            o.AlignPic(10, 40, 30, 40, out x, out y);
            Assert.AreEqual(0.0f, x);
            Assert.AreEqual(0.0f, y);
        }

        [TestMethod]
        public void TestAlignCenterAndMiddle()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float x, y;
            o.AlignPic(30, 40, 30, 40, out x, out y);
            Assert.AreEqual(0.0f, x);
            Assert.AreEqual(0.0f, y);
        }

        [TestMethod]
        public void TestZeroWidthAndHeight()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float x, y;
            o.AlignPic(0, 0, 30, 40, out x, out y);
            Assert.AreEqual(0.0f, x);
            Assert.AreEqual(0.0f, y);
        }
    }
}
