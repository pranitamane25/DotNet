public class Person
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public Person()//default constructor
    {
        FirstName = "Pranita";
        LastName = "Mane";
        Id = 25;
    }


    public Person(string firstname, string lastname, int id)// parameterised constructor
    {

        FirstName = firstname;
        LastName = lastname;
        Id = id;
    }
    public void Display()
    {

        Console.WriteLine($"{FirstName},{LastName},{Id}");
    }
    static void Main()
    {

        Person p1 = new Person();
        p1.Display();

        Person p2 = new Person("pratiksha", "Mane", 2);
        p2.Display();
    }
}
