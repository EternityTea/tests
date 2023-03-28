using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_0_0()
        {
            //arange
            double x = 0;
            double expected = 0;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method1(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_05_0878()
        {
            //arange
            double x = 0.5;
            double expected = 0.878;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method2(x);
            actual = Math.Round(actual, 3);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_1_m2()
        {
            //arange
            double x = 1;
            double expected = -2;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method3(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1_double_0_0()
        {
            //arange
            double x = 0;
            double expected = 0;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method1(x);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_double_05_153()
        {
            //arange
            double x = 0.7;
            double expected = 1.53;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method2(x);
            actual = Math.Round(actual, 3);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_double_1_m4()
        {
            //arange
            double x = 1;
            double expected = -4;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method3(x);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1_3_914()
        {
            //arange
            double x = 3;
            double expected = 9.14;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method1(x);
            actual = Math.Round(actual, 2);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_3_m099()
        {
            //arange
            double x = 3;
            double expected = -0.99;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method2(x);
            actual = Math.Round(actual, 3);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_5_10()
        {
            //arange
            double x = 5;
            double expected = 10;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method3(x);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_double_5_20()
        {
            //arange
            double x = 5;
            double expected = 20;
            //act
            WindowsFormsApp2_1.Form1 c = new WindowsFormsApp2_1.Form1();
            double actual = c.Method3(x);
            actual = c.DoubleRes(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
