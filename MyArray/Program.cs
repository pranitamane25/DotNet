using System;
using System.Collections.Generic;

namespace ARRAY
{
    public class Person
    {
        public string name;
        public int age;


                public static void Main(string[] args)
        {
            // Create a list of Person objects
            // List<Person> persons = new List<Person>();
            List<Person> persons = new List<Person>();

            // Add new Person objects to the list
            persons.Add(new Person { name = "Pranita", age = 22 });
            persons.Add(new Person { name = "Amit", age = 25 });

            // Loop through list and print
            foreach (Person p in persons)
            {
                Console.WriteLine("Name: " + p.name + ", Age: " + p.age);
            }
        }
    }

    // class Program
    // {
        // public static void Main(string[] args)
        // {
        //     // Create a list of Person objects
        //     // List<Person> persons = new List<Person>();
        //     List<Person> persons = new List<Person>();

        //     // Add new Person objects to the list
        //     persons.Add(new Person { name = "Pranita", age = 22 });
        //     persons.Add(new Person { name = "Amit", age = 25 });

        //     // Loop through list and print
        //     foreach (Person p in persons)
        //     {
        //         Console.WriteLine("Name: " + p.name + ", Age: " + p.age);
        //     }
        // }
    // }
}
