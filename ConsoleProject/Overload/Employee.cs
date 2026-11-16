using System;
using System.Collections.Generic;
using System.Text;

namespace Overload
{
    public class Employee
    {
        //properties of the Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //operator overloading - overloading the == and != operators to compare two Employee objects based on their Id property
        public static bool operator== (Employee employee, Employee employeeToCompare)
        {
            return employee.Id == employeeToCompare.Id;
        }
        public static bool operator !=(Employee employee, Employee employeeToCompare)
        {
            return employee.Id != employeeToCompare.Id;
        }
    }
}
