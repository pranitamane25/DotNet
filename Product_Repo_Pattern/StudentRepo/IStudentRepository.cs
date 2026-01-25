using StudentEntity; // important!
using System.Collections.Generic;


namespace StudentRepo

{
    public interface IStudentRepo
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}

