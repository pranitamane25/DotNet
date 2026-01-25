// File: ConsoleApp/Program.cs
using System;
using Business;
using DataAccess;
using Models;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Set up repository and service
            IEmployeeRepository repo = new EmployeeRepository();
            EmployeeService service = new EmployeeService(repo);

            // Add employees
            service.AddEmployee(new Employee { Id = 1, Name = "Alice", Salary = 50000 });
            service.AddEmployee(new Employee { Id = 2, Name = "Bob", Salary = 60000 });

            // List employees
            foreach (var emp in service.GetAllEmployees())
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
            }

            // Update employee
            service.UpdateEmployee(new Employee { Id = 1, Name = "Alice Smith", Salary = 55000 });

            // Delete employee
            service.DeleteEmployee(1);

            Console.WriteLine("\nAfter Update & Delete:");
            foreach (var emp in service.GetAllEmployees())
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }
    }
}
