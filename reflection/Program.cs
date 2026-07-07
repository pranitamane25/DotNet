using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        // Get type info of Employee class
        Type t = typeof(Employee);

        Console.WriteLine("Class Name: " + t.Name);

        // Get properties
        
        Console.WriteLine("\nProperties:");
        foreach (PropertyInfo prop in t.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }

        // Get methods
        Console.WriteLine("\nMethods:");
        foreach (MethodInfo method in t.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
