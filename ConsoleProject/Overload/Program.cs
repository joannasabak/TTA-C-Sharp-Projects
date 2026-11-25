namespace Overload;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee() { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee() { Id = 2, FirstName = "Jane", LastName = "Smith" };
        Employee employee3 = new Employee() { Id = 1, FirstName = "John", LastName = "Doe" };
       
        //using the overloaded == operator to compare two Employee objects
        if (employee1 == employee3)
        {
            Console.WriteLine("Employee 1 and Employee 3 are the same.");
        }
        else
        {
            Console.WriteLine("Employee 1 and Employee 3 are different.");
        }

        //using the overloaded != operator to compare two Employee objects
        if (employee1 != employee2)
        {
            Console.WriteLine("Employee 1 and Employee 2 are different.");
        }
        else
        {
            Console.WriteLine("Employee 1 and Employee 2 are the same.");
        }

        Console.ReadLine();
    }
}