delegate void MathOperations(int a, int b);

class Program
{
    static void Add(int a, int b)
    {
        Console.WriteLine($"Addition:{a + b}");
    }
    static void Subtraction(int x, int y)
    {
        Console.WriteLine($"Subtraction:{x - y}");
    }
    static void Main()
    {
        MathOperations? operation = null;

        operation = Add;
        operation += Subtraction;//chaining

        Console.WriteLine("calling delegate chain");
        operation(10, 5);

        // Remove one method
        operation -= Add;
        Console.WriteLine(" /nAfter removing Add");
        operation(10, 5);
    }

}