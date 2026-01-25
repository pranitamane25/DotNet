using System.Collections.Generic;  // for List<>
using StudentEntity;              // for Student class
using StudentRepo;                // for IStudentRepo interface


namespace StudentService
{
    public class StudentServiceImpl : IStudentService
    {
        private readonly IStudentRepo _studentRepo;

        public StudentServiceImpl(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public List<Student> GetStudents() => _studentRepo.GetAllStudents();

        public Student GetStudent(int id) => _studentRepo.GetStudentById(id);

        public void CreateStudent(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.Name))
                throw new System.ArgumentException("Student name cannot be empty");

            _studentRepo.AddStudent(student);
        }

        public void EditStudent(Student student)
        {
            _studentRepo.UpdateStudent(student);
        }

        public void RemoveStudent(int id)
        {
            _studentRepo.DeleteStudent(id);
        }
    }
}

