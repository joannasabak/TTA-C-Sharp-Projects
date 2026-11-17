using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Employee<T>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<T> Things { get; set; }
    }
}
