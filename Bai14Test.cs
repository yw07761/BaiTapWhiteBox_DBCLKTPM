using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteBoxTests
{
    [TestClass]
    public class Bai14Test
    {
        [TestMethod]
        public void UT1()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float width = 100;
            float height = 100;
            float size, x, y;
            o.CreateIcon(width, height, out size, out x, out y);
            Assert.AreEqual(100, size);
            Assert.AreEqual(0, x);
            Assert.AreEqual(0, y);
        }

        [TestMethod]
        public void UT2()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float width = 100;
            float height = 150;
            float size, x, y;
            o.CreateIcon(width, height, out size, out x, out y);
            Assert.AreEqual(100, size);
            Assert.AreEqual(0, x);
            Assert.AreEqual(25, y);
        }

        [TestMethod]
        public void UT3()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float width = 200;
            float height = 100;
            float size, x, y;
            o.CreateIcon(width, height, out size, out x, out y);
            Assert.AreEqual(100, size);
            Assert.AreEqual(50, x);
            Assert.AreEqual(0, y);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UT4()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float width = -100;
            float height = 100;
            float size, x, y;
            o.CreateIcon(width, height, out size, out x, out y);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void UT5()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float width = 100;
            float height = -100;
            float size, x, y;
            o.CreateIcon(width, height, out size, out x, out y);
        }
    }
}
