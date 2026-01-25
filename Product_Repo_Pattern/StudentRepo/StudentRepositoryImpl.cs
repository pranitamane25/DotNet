
using System.Collections.Generic;
using StudentEntity;   
using StudentRepo;     
using System.Collections.Generic;  



namespace StudentRepo
{
    public class StudentRepoImpl : IStudentRepo
    {
        List<Student> _students = new List<Student>();

        public List<Student> GetAllStudents()
        {
            return _students;
        }

        public Student GetStudentById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        // public Student GetStudentById(int id)
        // {
        //     foreach (var student in _students)
        //     {
        //         if (student.Id == id)
        //             return student;
        //     }
        //     return null;
        // }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void UpdateStudent(Student student)
        {
            var existing = GetStudentById(student.Id);
            if (existing != null)
            {
                existing.Name = student.Name;
                existing.Age = student.Age;
                existing.Email = student.Email;
            }
        }

        public void DeleteStudent(int id)
        {
            var student = GetStudentById(id);
            if (student != null)
                _students.Remove(student);
        }
    }
}
