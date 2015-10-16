using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using assessment;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Computation comp = new Computation();
            float result = comp.GetTotalPrice(1, 1);
            Assert.AreEqual(2, result);
        }
    }
}
