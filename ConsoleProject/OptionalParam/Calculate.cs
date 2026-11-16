using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalParam
{
    public class Calculate
    {
        public int Power(int a, int b = 2)
        {
            return (int)Math.Pow(a, b);
        }
    }
}
