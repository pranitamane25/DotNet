// using System;
// using StudentEntity; 
// using StudentRepo;    
// using StudentService; 
// using System.Collections.Generic;

// namespace Repo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Use the repository and service implementations
//             IStudentRepo repo = new StudentRepoImpl();
//             IStudentService service = new StudentServiceImpl(repo);

//             Console.WriteLine("All Students:");
//             foreach (var s in service.GetStudents())
//                 Console.WriteLine($"{s.Id} - {s.Name} ({s.Age}) - {s.Email}");

//             Console.WriteLine("\nAdding a new student...");
//             service.CreateStudent(new Student { Id = 3, Name = "Neha", Age = 21, Email = "neha@example.com" });

//             Console.WriteLine("\nAfter adding:");
//             foreach (var s in service.GetStudents())
//                 Console.WriteLine($"{s.Id} - {s.Name} ({s.Age}) - {s.Email}");

//             Console.WriteLine("\nUpdating student with ID = 2...");
//             service.EditStudent(new Student { Id = 2, Name = "Amit Sharma", Age = 23, Email = "amit.sharma@example.com" });

//             Console.WriteLine("\nAfter update:");
//             foreach (var s in service.GetStudents())
//                 Console.WriteLine($"{s.Id} - {s.Name} ({s.Age}) - {s.Email}");

//             Console.WriteLine("\nDeleting student with ID = 1...");
//             service.RemoveStudent(1);

//             Console.WriteLine("\nAfter delete:");
//             foreach (var s in service.GetStudents())
//                 Console.WriteLine($"{s.Id} - {s.Name} ({s.Age}) - {s.Email}");
//         }
//     }
// }


using StudentEntity;
namespace TeacherConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {

            SerializationExample Serializer = new SerializationExample();

            Serializer.SaveData();

            List<Student> students = Serializer.LoadData();

            // Print student list here in Main
            Console.WriteLine("Printing student list");
           foreach (var s in students)
           {
               Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}, Email: {s.Email}");
             }            // I want print here student list not in my seri... lip
         }
    }
}
