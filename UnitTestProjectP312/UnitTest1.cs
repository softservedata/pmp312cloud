//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace UnitTestProjectP312
{
    //[TestClass]
    [TestFixture]
    public class UnitTest1
    {
        //[TestMethod]
        [Test]
        public void TestMethodAdd()
        {
            Calc calc = new Calc();
            double expected = 123;
            double actual;
            //
            actual = calc.Add(120, 3);
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [Test]
        public void TestMethodHello()
        {
            Calc calc = new Calc();
            string expected = "Hello Abu";
            string actual;
            //
            actual = calc.Hello("Abu");
            Assert.AreEqual(expected, actual);
        }
    }
}
