using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Hand.Test
{
    class CalculatorHandTest
    {
        static void Main(string[] args)
        {

            var uut = new Calculator();

            Console.WriteLine("Addition hand test 1, enter two positive double values");
            double a1 = Convert.ToInt32(Console.ReadLine());
            double b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Equation: {0} + {1} = {2}", a1, b1, uut.Add(a1, b1));


            Console.WriteLine("Addition hand test 2, enter one positive and one negative double values");
            double c1 = Convert.ToInt32(Console.ReadLine());
            double d1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Equation: {0} + {1} = {2}", c1, d1, uut.Add(c1, d1));


            Console.WriteLine("Addition hand test 3, enter two negative double values");
            double e1 = Convert.ToInt32(Console.ReadLine());
            double f1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Equation: {0} + {1} = {2}", e1, f1, uut.Add(e1, f1));

            Console.WriteLine("Subtraction hand test 1, enter two positive double values");
            double a2 = Convert.ToInt32(Console.ReadLine());
            double b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Equation: {0} - {1} = {2}", a2, b2, uut.Subtract(a2, b2));


            Console.WriteLine("Subtraction hand test 2, enter one positive and one negative double values");
            double c2 = Convert.ToInt32(Console.ReadLine());
            double d2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Equation: {0} - {1} = {2}", c2, d2, uut.Subtract(c2, d2));


            Console.WriteLine("Subtraction hand test 3, enter two negative double values");
            double e2 = Convert.ToInt32(Console.ReadLine());
            double f2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Equation: {0} - {1} = {2}", e2, f2, uut.Subtract(e2, f2));


            Console.WriteLine("Multiplication hand test 1, enter two positive double values");
            double a3 = Convert.ToInt32(Console.ReadLine());
            double b3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Equation: {0} * {1} = {2}", a3, b3, uut.Multiply(a3, b3));


            Console.WriteLine("Multiplication hand test 2, enter one positive and one negative double values");
            double c3 = Convert.ToInt32(Console.ReadLine());
            double d3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Equation: {0} * {1} = {2}", c3, d3, uut.Multiply(c3, d3));


            Console.WriteLine("Multiplication hand test 3, enter two negative double values");
            double e3 = Convert.ToInt32(Console.ReadLine());
            double f3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Equation: {0} * {1} = {2}", e3, f3, uut.Multiply(e3, f3));

            Console.WriteLine("Multiplication hand test 4, enter two double values, one must be 0");
            double g3 = Convert.ToInt32(Console.ReadLine());
            double h3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Equation: {0} * {1} = {2}", g3, h3, uut.Multiply(g3, h3));

            Console.WriteLine("Power hand test 1, enter two positive double values");
            double a4 = Convert.ToInt32(Console.ReadLine());
            double b4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Equation: {0} ^ {1} = {2}", a4, b4, uut.Power(a4, b4));


            Console.WriteLine("Power hand test 2, enter one positive and then one negative double value");
            double c4 = Convert.ToInt32(Console.ReadLine());
            double d4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Equation: {0} ^ {1} = {2}", c4, d4, uut.Power(c4, d4));


            Console.WriteLine("Power hand test 3, enter a positive value first and zero as the second value");
            double e4 = Convert.ToInt32(Console.ReadLine());
            double f4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Equation: {0} ^ {1} = {2}", e4, f4, uut.Power(e4, f4));

            Console.ReadKey();
        }
    }
}
