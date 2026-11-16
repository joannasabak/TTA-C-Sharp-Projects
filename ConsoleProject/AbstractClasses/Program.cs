namespace AbstractClasses;

class Program
{
    static void Main(string[] args)
    {
        //Create an Employee object and set the name properties inherited from Person.
        Employee employee = new Employee();
        employee.FirstName = "Sample";
        employee.LastName = "Student";

        //Call the SayName() method that Employee overrides from Person.
        employee.SayName();

        //Polymorphism: the variable's type is the interface IQuittable,
        //but the object it holds is an Employee. This works because
        //Employee implements IQuittable.
        IQuittable quittable = new Employee { FirstName = "Beyonce", LastName = "Knowles" };

        //call Quit() through the interface
        quittable.Quit();

        // Wait for the user to press Enter so the console window stays open.
        Console.ReadLine();
    }
}
