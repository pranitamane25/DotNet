using System;
using Models;
using Repository;
using Services;

namespace RepositoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonRepository repo = new PersonRepository();
            PersonService service = new PersonService(repo);

            // Add Persons
            service.AddPerson(new Person { Id = 1, Name = "Pranita", Age = 22 });
            service.AddPerson(new Person { Id = 2, Name = "Aarav", Age = 25 });

            // Display all persons
            Console.WriteLine("All Persons:");
            foreach (var p in service.GetAllPersons())
            {
                Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Age: {p.Age}");
            }

            // Update a person
            service.UpdatePerson(new Person { Id = 1, Name = "Pranita Mane", Age = 23 });

            // Display after update
            Console.WriteLine("\nAfter Update:");
            foreach (var p in service.GetAllPersons())
            {
                Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Age: {p.Age}");
            }

            // Delete a person
            service.DeletePerson(2);

            // Display after delete
            Console.WriteLine("\nAfter Delete:");
            foreach (var p in service.GetAllPersons())
            {
                Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Age: {p.Age}");
            }
        }
    }
}
