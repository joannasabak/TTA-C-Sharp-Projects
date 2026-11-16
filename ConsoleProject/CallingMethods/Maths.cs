using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public class Maths
    {
        //method to return the square of a number
        public static int Power(int a)
        {
            return a * a;
        }
        //method to return the negative of a number
        public static int Negative(int a)
        {
            return (-a);
        }
        //method to return the factorial of a number
        public static int Factorial(int a)
        {
            int result = 1;
            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
