using java.lang;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Trifort;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AC1()
        {
            decimal expected = 1342.05M;
            Program bm = new Program();
            decimal res = bm.Story1(250000,5,30);
            Assert.AreEqual(res, expected);
        }
        [TestMethod]
        public void AC2()
        {
            Program bm = new Program();
            var exception = Assert.ThrowsException<DivideByZeroException>(() => bm.Story1(250000, 0, 30));
            Assert.AreEqual("Attempted to divide by zero.", exception.Message);
        }
        [TestMethod]
        public void AC3()
        {
            Program bm = new Program();
            var exception = Assert.ThrowsException<IllegalArgumentException>(() => bm.Story1(250000, -5, 30));
            Assert.AreEqual("Interest rate cannot be negative.", exception.Message);
        }
        [TestMethod]
        public void AC4()
        {
            string Expected = @"payment number: 1 payment: 433.79 interest: 31.25 principal: 402.54 balance: 4597.46
    payment number: 2 payment: 433.79 interest: 28.73 principal: 405.05 balance: 4192.41
    payment number: 3 payment: 433.79 interest: 26.20 principal: 407.58 balance: 3784.83
    payment number: 4 payment: 433.79 interest: 23.66 principal: 410.13 balance: 3374.69
    payment number: 5 payment: 433.79 interest: 21.09 principal: 412.70 balance: 2962.00
    payment number: 6 payment: 433.79 interest: 18.51 principal: 415.27 balance: 2546.72
    payment number: 7 payment: 433.79 interest: 15.92 principal: 417.87 balance: 2128.85
    payment number: 8 payment: 433.79 interest: 13.31 principal: 420.48 balance: 1708.37
    payment number: 9 payment: 433.79 interest: 10.68 principal: 423.11 balance: 1285.26
    payment number: 10 payment: 433.79 interest: 8.03 principal: 425.75 balance: 859.51
    payment number: 11 payment: 433.79 interest: 5.37 principal: 428.42 balance: 431.09
    payment number: 12 payment: 433.79 interest: 2.69 principal: 431.09 balance: 0.00";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program bm = new Program();
                bm.Story2(5000,5,1);
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected,result);
            }
        }
        [TestMethod]
        public void AC5()
        {
            Program bm = new Program();
            var exception = Assert.ThrowsException<IllegalArgumentException>(() => bm.Story2(5000, 0, 1));
            Assert.AreEqual("APR cannot be zero.", exception.Message);
        }
        [TestMethod]
        public void AC6()
        {
            Program bm = new Program();
            var exception = Assert.ThrowsException<IllegalArgumentException>(() => bm.Story2(5000, -5, 1));
            Assert.AreEqual("Interest rate cannot be negative.", exception.Message);
        }

    }
}
