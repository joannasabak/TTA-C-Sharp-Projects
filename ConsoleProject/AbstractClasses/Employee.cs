namespace AbstractClasses
{
    //Employee inherits from Person and implements IQuittable
    public class Employee : Person, IQuittable
    {
        //Required by Person: SayName() is abstract there, so Employee must override it.
        public override void SayName()
        {
            Console.WriteLine("Employee: {0} {1}", FirstName, LastName);
        }

        //Required by IQuittable: this is Employee's version of Quit().
        public void Quit()
        {
            Console.WriteLine("{0} {1} has quit the job.", FirstName, LastName);
        }
    }
}
