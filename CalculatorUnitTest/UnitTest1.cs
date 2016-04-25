using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition1()
        {
            double a = 10.9;
            double b = 12.89;
            Assert.AreEqual(23.79, Mathlib.addition(a, b));
        }
        [TestMethod]
        public void TestAddition2()
        {
            double a = 1.99999999;
            Assert.AreEqual(0, Mathlib.addition(a, -a));
        }
        [TestMethod]
        public void TestAdditionOverflow1()
        {
            double a = double.MaxValue;
            Assert.AreEqual(0, Mathlib.addition(a, a));
        }
        [TestMethod]
        public void TestAdditionOverflow2()
        {
            double a = double.MinValue;
            Assert.AreEqual(0, Mathlib.addition(a, a));
        }
        [TestMethod]
        public void TestSubstraction1()
        {
            double a = 1.999999;
            Assert.AreEqual(0, Mathlib.subtraction(a, a));
        }
        [TestMethod]
        public void TestSubstractionOverflow1()
        {
            double a = double.MinValue;
            Assert.AreEqual(0, Mathlib.subtraction(a, a));
        }
        [TestMethod]
        public void TestMultiplication1()
        {
            double a = 1000000000000D;
            Assert.AreEqual(1000000000000000000000000D, Mathlib.multiplication(a, a));
        }
        [TestMethod]
        public void TestMultiplication2()
        {
            double a = 1000000000000000D;
            Assert.AreEqual(1000000000000000000000000000000D, Mathlib.multiplication(a, a));
        }
        [TestMethod]
        public void TestMultiplication3()
        {
            double a = 10E+300D;
            Assert.AreEqual(0, Mathlib.multiplication(a, a));
        }
        [TestMethod]
        public void TestDivide1()
        {
            double a = 999999999999999.999D;
            Assert.AreEqual(1D, Mathlib.divide(a, a));
        }
        [TestMethod]
        public void TestDivide2()
        {
            double a = 1.5D;
            double b = 0.000000000000001D;
            Assert.AreEqual(1500000000000000D, Mathlib.divide(a, b));
        }
        [TestMethod]
        public void TestDivide3()
        {
            Assert.AreEqual(0, Mathlib.divide(1, 0));
        }
        [TestMethod]
        public void TestModulo1()
        {
            Assert.AreEqual(42, Mathlib.modulo(92, 50));
        }
        [TestMethod]
        public void TestModulo2()
        {
            Assert.AreEqual(0, Mathlib.modulo(9.2, 5));
        }
        [TestMethod]
        public void TestModulo3()
        {
            Assert.AreEqual(0, Mathlib.modulo(9, 5.1));
        }
        [TestMethod]
        public void TestModulo4()
        {
            Assert.AreEqual(0, Mathlib.modulo(9, 0));
        }
        [TestMethod]
        public void TestModulo5()
        {
            Assert.AreEqual(0, Mathlib.modulo(-9, 0));
        }
        [TestMethod]
        public void TestModulo6()
        {
            Assert.AreEqual(0, Mathlib.modulo(9, -5));
        }
        [TestMethod]
        public void TestFactorial1()
        {
            Assert.AreEqual(6402373705728000D, Mathlib.factorial(18));
        }
        [TestMethod]
        public void TestFactorial2()
        {
            Assert.AreEqual(0, Mathlib.factorial(18.5));
        }
        [TestMethod]
        public void TestFactorial3()
        {
            Assert.AreEqual(1, Mathlib.factorial(0));
        }
        [TestMethod]
        public void TestFactorial4()
        {
            Assert.AreEqual(0, Mathlib.factorial(-2));
        }
        [TestMethod]
        public void TestExponent1()
        {
            Assert.AreEqual(1, Mathlib.exponent(3,0));
        }
        [TestMethod]
        public void TestExponent2()
        {
            Assert.AreEqual(0, Mathlib.exponent(3, 0.6));
        }
        [TestMethod]
        public void TestExponent3()
        {
            Assert.AreEqual(0, Mathlib.exponent(3D, -3.5D));
        }
        [TestMethod]
        public void TestExponent4()
        {
            Assert.AreEqual(10000000000000000D, Mathlib.exponent(10, 16));
        }
        [TestMethod]
        public void TestExponent5()
        {
            double a = 15D;
            double b = 8D;
            Assert.AreEqual(2562890625D, Mathlib.exponent(a, b));
        }
    }
}
