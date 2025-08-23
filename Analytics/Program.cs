using System;
using System.Linq;
using System.Collections.Generic;

namespace Analytics
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            FindAllNumbersMultipleOf2();
            ShowAllNames();

        }

        static void FindAllNumbersMultipleOf2()
        {

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

            foreach (var num in evenNumbers)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }


        static void ShowAllNames()
        {

            List<Person> participants = new List<Person>() {
            new Person { FirstName = "Ajinkya",LastName = "Tambbade" ,Age = 19 },
            new Person { FirstName = "Neha",LastName = "Bhor", Age = 21 },
            new Person { FirstName = "Mayuresh",LastName = "Wanjare", Age = 3 } ,
            new Person { FirstName = "Umesh",LastName = "Kumar", Age = 30},
            new Person { FirstName = "Swarali",LastName = "Lakade", Age =23 },
            new Person { FirstName = "Ankur",LastName = "Prasad", Age = 28 }
        };

            var peopleResult = participants.Select(x => new
            {
                                                    Age = x.Age,
                                                    FirstLetter = x.FirstName,
                                                    LastNameLetter = x.LastName[0]
            }
                                            );

            foreach (var person in peopleResult)
            { Console.WriteLine(person); }
        }

    }
}



