using System;
using System.Collections.Generic;
using System.Text;

namespace SayMyName
{
    public class Person
    {
        //create two properties for the Person class called FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //create a method for the Person class called SayName
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
