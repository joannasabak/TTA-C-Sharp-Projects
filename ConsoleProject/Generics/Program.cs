namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        //intance of the generic class type string
        Employee<string> employee = new Employee<string>();
        employee.FirstName = "Sample";
        employee.LastName = "Student";
        employee.Things = new List<string>() { "Computer", "Notebook", "Pen" };
        Console.WriteLine(employee.FirstName);
        Console.WriteLine(employee.LastName);
        foreach (string thing in employee.Things)
        {
            Console.WriteLine(thing);
        }
        Console.ReadLine();

        //intance of the generic class type int
        Employee<int> employee2 = new Employee<int>();
        employee2.FirstName = "Sample";
        employee2.LastName = "Student";
        employee2.Things = new List<int>() { 1, 2, 3 };
        Console.WriteLine(employee2.FirstName);
        Console.WriteLine(employee2.LastName);
        foreach (int thing in employee2.Things)
        {
            Console.WriteLine(thing);
        }
        Console.ReadLine();
    }
}
