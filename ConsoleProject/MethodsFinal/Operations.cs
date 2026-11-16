using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsFinal
{
    public class Operations
    {
        //void class, that takes in a number and divides it by 2, returning the result as an out parameter (steps 1 & 4)
        public void Divide(double a, out double result)
        {
            result = a / 2;
        }

        //overloaded method that takes int instead (step 5
        public void Divide(int a, out int result)
        {
            result = a / 2;
        }
    }

    //static class (step 6)
    public static class MathHelper
    {
        public static int Triple(int number)
        {
            return number * 3;
        }
    }
}
