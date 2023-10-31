using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteBoxTests
{
    [TestClass]
    public class Bai05Test
    {
         [TestMethod]
         public void UT1()
         {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            string result = o.Triangle(5, 5, 5);
            Assert.AreEqual("Triangle is Equilateral", result);
         }

        [TestMethod]
        public void UT2()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            string result = o.Triangle(2, 2, 0);
            Assert.AreEqual("Not a Triangle", result);
        }

        [TestMethod]
        public void UT3()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            string result = o.Triangle(5, 5, 2);
            Assert.AreEqual("Triangle is Isosceles", result);
        }

        [TestMethod]
        public void UT4()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            string result = o.Triangle(4, 13, 4);
            Assert.AreEqual("Not a Triangle", result);
        }

        [TestMethod]
        public void UT5()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            string result = o.Triangle(4, 2, 4);
            Assert.AreEqual("Triangle is Isosceles", result);
        }

        [TestMethod]
        public void UT6()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            string result = o.Triangle(-3, 4, 4);
            Assert.AreEqual("Not a Triangle", result);
        }
        [TestMethod]
        public void UT7()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            string result = o.Triangle(3, 5, 5);
            Assert.AreEqual("Triangle is Isosceles", result);
        }
        [TestMethod]
        public void UT8()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            string result = o.Triangle(2, 5, 6);
            Assert.AreEqual("Triangle is Scalene", result);
        }
        [TestMethod]
        public void UT9()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            string result = o.Triangle(4, 5, 12);
            Assert.AreEqual("Not a Triangle", result);
        }
        [TestMethod]
        public void UT10()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            string result = o.Triangle(12, 4, 5);
            Assert.AreEqual("Not a Triangle", result);
        }
        [TestMethod]
        public void UT11()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            string result = o.Triangle(5, 12, 4);
            Assert.AreEqual("Not a Triangle", result);
        }
    }
}
