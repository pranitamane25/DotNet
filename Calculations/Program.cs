
using Maths;
class Program
{
    static void Main(string[] args)
    {
        MathEngine mathEngine1 = new MathEngine();
        MathEngine mathEngine2 = new MathEngine();
        MathEngine mathEngine3 = new MathEngine();
        MathEngine mathEngine4 = new MathEngine();
        MathEngine mathEngine5 = new MathEngine();
        
        double a = 10;
        double b = 5;


        Console.WriteLine($"MathEngine count: {MathEngine.count}");
        
        Console.WriteLine($"Addition: {mathEngine1.Add(a, b)}");
        Console.WriteLine($"Subtraction: {mathEngine2.Subtract(a, b)}");
        Console.WriteLine($"Multiplication: {mathEngine3.Multiply(a, b)}");
        Console.WriteLine($"Division: {mathEngine4.Divide(a, b)}");
    }
}