namespace HelloDotnetApp;
public class Program{

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, .NET!");
       string  input = Console.ReadLine();
       //Console.WriteLine("You entered: " + input);
       Console.WriteLine($"You entered: {input}");
    }
}