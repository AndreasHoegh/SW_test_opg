using System;
namespace SW_test_opg
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public double Add(double a, double b)
        {
            return Accumulator= a + b;
        }
        public double Subtract(double a, double b)
        {
            return Accumulator = a - b;
        }
        public double Multiply(double a, double b)
        {
            return Accumulator=a * b;
        }


        public double Power(double x, double exp)
        {
            return Accumulator=Math.Pow(x, exp);
        }

        public double Divide(double dividend, double divisor)
        {
            try
            {
                return Accumulator= dividend / divisor;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
                return Accumulator= 0;
            }
        }

        public void Clear()
        {
            Accumulator = 0;
        }

    }
}
