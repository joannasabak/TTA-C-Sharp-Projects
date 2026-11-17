namespace Lambda;

class Program
{
    static void Main()
    {
        //list of 10 employees
        int employeesNr = 10;

        List<string> firstNames = new List<string>() { "Joe", "Joe", "Matt", "Daniel", "Kelly", "Brandon", "Penelope", "Edward", "Imogen", "Aiden" };
        List<string> lastNames = new List<string>() { "Geerts", "Gaines", "Bieler", "Wood", "Blanchet", "Gherkin", "Redsock", "Clark", "Nelson", "Gabinus" };

        //new list to hold employee objects
        List<Employee> employees = new List<Employee>();

        //for loop creates one employee at a time
        for (int i = 0; i < employeesNr; i++)
        {
            Employee employee = new Employee();
            employee.Id = i+1;
            employee.FirstName = firstNames[i];
            employee.LastName = lastNames[i];
            employees.Add(employee);
        }

        Console.WriteLine("List of employees: ");
        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee);
        }
        Console.ReadLine();


        //second list, find employees called Joe

        //empty list to store Joes
        List<Employee> joes1 = new List<Employee>();

        foreach (Employee employee in employees)
        {
            if (employee.FirstName == "Joe")
            {
                joes1.Add(employee);
            }
        }

        Console.WriteLine("List of Joes: ");
        foreach (Employee employee2 in joes1)
        {
            Console.WriteLine(employee2);
        }
        Console.ReadLine();

        //third list, select Joes with lambda
        List<Employee> joesLambda = employees.Where(x => x.FirstName == "Joe").ToList();

        Console.WriteLine("List of Joes created with a lambda: ");
        foreach (Employee employee3 in joesLambda)
        {
            Console.WriteLine(employee3);
        }
        Console.ReadLine();


        //ids over 5 using a lambda expression
        List<Employee> idOverFive = employees.Where(x => x.Id > 5).ToList();

        Console.WriteLine("Id greater than 5: ");
        foreach (Employee person in idOverFive)
        {
            Console.WriteLine(person);
        }

        Console.ReadLine();
    }
}