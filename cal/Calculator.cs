using System;

namespace cal
{
    //class for basic operations
    public class Calculator
    {
        public double Add(double x, double y)
        {

            return x + y;

        }

        public double Subtract(double x, double y)
        {

            return x - y;

        }

        public double Multiply(double x, double y)
        {

            return x * y;

        }
        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }
            return x / y;
        }
    }
}
