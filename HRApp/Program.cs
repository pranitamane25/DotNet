using System;
using HR;
using HR.Interfaces;

class Program
{
    static void Main()
    {
        Employee emp1 = new SalesEmployee(
            1, "Amit", "Sharma", "amit@company.com",
            "9999999999", "Mumbai", "Mumbai",
            new DateTime(1995, 5, 12),
            1000, 5000, 20000, 100000, 120000, 30000
        );

        Employee emp2 = new SalesManager(
            2, "Neha", "Patil", "neha@company.com",
            "8888888888", "Pune", "Pune",
            new DateTime(1990, 3, 22),
            1500, 7000, 30000, 200000, 250000, 40000,
            10000   // bonus
        );

        // 🔹 Polymorphism
        emp1.DoWork();
        emp2.DoWork();

        Console.WriteLine(emp1);
        Console.WriteLine("Salary: " + emp1.ComputePay());

        Console.WriteLine(emp2);
        Console.WriteLine("Salary: " + emp2.ComputePay());
    }
}
