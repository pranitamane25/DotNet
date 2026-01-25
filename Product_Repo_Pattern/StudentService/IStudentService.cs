using System.Collections.Generic;
using StudentEntity;

namespace StudentService
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudent(int id);
        void CreateStudent(Student student);
        void EditStudent(Student student);
        void RemoveStudent(int id);
    }
}
