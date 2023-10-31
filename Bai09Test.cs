using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteBoxTests
{
    [TestClass]
    public class Bai09Test
    {
        [TestMethod]
        [ExpectedException(typeof(Exception), "Error")]
        public void UT1()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float a = 4;
            float b = 3;
            float x = 2;
            o.bai9(a, b, x);
        }
        

        [TestMethod]
        public void UT2()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float a = 2;
            float b = 3;
            float x = 0;
            try
            {
                o.bai9(a, b, x);
                Assert.AreEqual("2", Console.Out.ToString().Trim());
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void UT3()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float a = 1;
            float b = 4;
            float x = 5;
            try
            {
                o.bai9(a, b, x);
                Assert.AreEqual("4", Console.Out.ToString().Trim());
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void UT4()
        {
            WhiteBox.Class1 o = new WhiteBox.Class1();
            float a = 1;
            float b = 4;
            float x = 2;
            try
            {
                o.bai9(a, b, x);
                Assert.AreEqual("2", Console.Out.ToString().Trim());
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

    }
}
