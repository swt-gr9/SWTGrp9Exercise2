using System;
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
        [TestCase(2,4,6)]
        [TestCase(0, 0, 0)]
        [TestCase(2, -4, -2)]
        [TestCase(1, 4, 5)]
        public void getAccumulatorAfterSubtractAndAdd(double a, double b, double result)
        {
            uut.Subtract(a, b);
            uut.Add(a, b);
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(1, 0.0)]
        public void divideZeroThrowException(double a, double b)
        {
            Assert.That(uut.Divide(a,b),Throws.TypeOf<System.DivideByZeroException>());
        }

        [TestCase(5, 2, 2.5)]
        [TestCase(10, -2, -5.0)]
        [TestCase(5, 10, 0.5)]
        public void DivideNumbers_ReturnCorrect(double a, double b, double result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }

        [TestCase(1, 0, 0.0)]
        [TestCase(5, 2, 0)]
        [TestCase(10, -2, 0)]
        [TestCase(5, 10, 0)]
        public void Clear_DoDifferentCommandsandClear_ReturnResult(double a, double b, double result)
        {
            uut.Subtract(a, b);
            uut.Add(a, b);
            uut.Clear();
            
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }



    }
}
