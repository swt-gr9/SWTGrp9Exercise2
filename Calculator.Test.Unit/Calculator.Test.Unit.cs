﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [TestCase(0,0,0)]
        [TestCase(2, 2, 4)]
        [TestCase(2, -2, 0)]
        [TestCase(-2, -2, -4)]
        public void addNumbers_ReturnCorrect(double a, double b, double result)
        {
            Assert.That(uut.Add(a,b), Is.EqualTo(result));
        }

        [TestCase(0, 0, 0)]
        [TestCase(2, 3, -1)]
        [TestCase(200, -200, 400)]
        [TestCase(-2, -5, 3)]
        public void subtractNumbers_ReturnCorrect(double a, double b, double result)
        {
            Assert.That(uut.Subtract(a,b), Is.EqualTo(result));
        }
        [TestCase(0, 0, 0)]
        [TestCase(100, 0, 0)]
        [TestCase(-2, -2, 4)]
        [TestCase(10, 0.5, 5)]
        public void multiplyNumber_ReturnCorrect(double a, double b, double result)
        {
            Assert.That(uut.Multiply(a,b), Is.EqualTo(result));
        }
        [TestCase(2, 8, 256)]
        [TestCase(4, 0.5, 2)]
        [TestCase(10, 3, 1000)]
        [TestCase(1, 4, 1)]
        public void powerNumbers_ReturnCorrect(double a, double b, double result)
        {
            Assert.That(uut.Power(a,b), Is.EqualTo(result));
        }

    }
}