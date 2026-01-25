using System;
using System.Text.Json;
using System.Collections.Generic;
using StudentEntity;
using System.IO;
using TeacherConsole;

    namespace TeacherConsole
    {
        public class SerializationExample
        {
        private string FilePath = "student.json";

            private string? jsonString;
        public void SaveData()
        {
            List<Student> students = new List<Student>{

        new Student{ Id = 1, Name = "Pranita", Age = 21, Email = "pranita25@gmail.com"},
        new Student { Id = 2, Name = "Sneha", Age = 22, Email = "sneha@gmail.com" },
        new Student { Id = 3, Name = "Tejal", Age = 23, Email = "tejal@gmail.com" }
            };


            string jsonString = JsonSerializer.Serialize(students);
            //Console.WriteLine("Serialized Data: " + jsonString);
            // File.WriteAllText("student.json", jsonString);
            File.WriteAllText(FilePath, jsonString);
// 
            Console.WriteLine("Student saved successfully in student.json");

        }

        public List<Student> LoadData()
        {
            // if (!File.Exists("student.json"))
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("File not found");
                return new List<Student>();
            }


            string jsonString = File.ReadAllText(FilePath);

            List<Student> students = JsonSerializer.Deserialize<List<Student>>(jsonString);

            if (students != null)
            {

                //Console.WriteLine("Deserialized student list");
                foreach (var s in students)
                {
                    Console.WriteLine($"Deserialized Data: {s.Id} {s.Name} {s.Age} {s.Email}");

                }

            }
            else
            {
                Console.WriteLine("Deserialization Failed");
            }
              return students;
        }

    }
}





// using System;
// using System.Text.Json;
// using System.Collections.Generic;
// using StudentEntity;
// using System.IO;

// namespace TeacherConsole
// {
//     public class SerializationExample
//     {
//         private string FilePath = "student.json";

//         public void SaveData()
//         {
//             List<Student> students = new List<Student>
//             {
//                 new Student{ Id = 1, Name = "Pranita", Age = 21, Email = "pranita25@gmail.com"},
//                 new Student { Id = 2, Name = "Sneha", Age = 22, Email = "sneha@gmail.com" },
//                 new Student { Id = 3, Name = "Tejal", Age = 23, Email = "tejal@gmail.com" }
//             };

//             string jsonString = JsonSerializer.Serialize(students);
//             File.WriteAllText(FilePath, jsonString);

//             Console.WriteLine("Student saved successfully in student.json");
//         }

//         // Change return type to List<Student>
//         public List<Student> LoadData()
//         {
//             if (!File.Exists(FilePath))
//             {
//                 Console.WriteLine("File not found");
//                 return new List<Student>(); // return empty list if file doesn't exist
//             }

//             string jsonString = File.ReadAllText(FilePath);
//             List<Student> students = JsonSerializer.Deserialize<List<Student>>(jsonString) ?? new List<Student>();
//             return students; // return list instead of printing
//         }
//     }
// }
