using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Multiply(double a)
        {
            Accumulator = Accumulator*a ;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

        public double Power(double exp)
        {
            Accumulator = Math.Pow(Accumulator, exp);
            return Accumulator;
        }


        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0.0)
                throw new System.DivideByZeroException();

            Accumulator = dividend / divisor;
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double a)
        {
            Accumulator = Accumulator + a;
            return Accumulator;
        }

        public double Subtract(double a)
        {
            Accumulator = Accumulator-a;
            return Accumulator;
        }
        

        public double Divide(double divisor)
        {
            if ((divisor == 0))
                return 0;

            Accumulator = (Accumulator / divisor);
            return Accumulator;
        }

        public double Accumulator { get; private set; }
    }
}
