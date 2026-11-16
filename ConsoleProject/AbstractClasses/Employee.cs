using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Employee: {0} {1}", FirstName, LastName);
        }
    }
}
