using System.Security.Cryptography.X509Certificates;

namespace TesterApp;

class Program
{
    //property(getter-setter)
    public string Name
    {
        get { return programName; }
        set { programName = value; }

    }

    private string programName;

    public Program() // default constructor
    {
    this.programName= "firstProgram";
    }

    public Program(string name)// parameterised constructor
    {
        this.programName = name;
    }
    static int Addition(int num1, int num2)
    {
        return num1 + num2;
    }
     static int Multiplication(int num1, int num2)
    {
        return num1 * num2;
    }
    public void Display()
    {

        int result = Addition(12, 12);
        int result1 = Multiplication(10, 100);
        Console.WriteLine("Addition result " + result);
        Console.WriteLine("Multiplication result " + result1);
    }
         public static void Main(String[] args)
    {
        for (int i = 0; i < args.Length; i++)
        Console.WriteLine("Welcome to c# programming");
        int count = 45;
        count++;
        count = count + 1;

        if (count < 300)
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();

        Console.WriteLine("Good morning" + name);
        //Console.WriteLine("Good morning{0}");
        Console.WriteLine("count after increment" + count);
        Program TheProgram = new Program();
        
        TheProgram.Display();
        Console.ReadLine();
    }
}

