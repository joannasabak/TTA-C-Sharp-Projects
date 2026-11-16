namespace SayMyName;

public class Program
{
    public static void Main()
    {
        //instantiate an object of the Employee class
        Employee employee = new Employee();
        employee.FirstName = "Sample";
        employee.LastName = "Student";

        //call the SayName method (inherited from the Person class)
        Console.WriteLine("Employee Information:");
        employee.SayName();

        //change the FirstName and LastName properties of the employee object
        employee.FirstName = "Beyonce";
        employee.LastName = "Knowles";

        Console.WriteLine("\nSay my ");
        employee.SayName();

        Console.ReadLine();


    }
}