// File: DataAccess/EmployeeRepository.cs
using System.Collections.Generic;
using System.Linq;
using Models;


namespace DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        // Using an in-memory list as our "database"
        private readonly List<Employee> _employees = new List<Employee>();

        public Employee GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public List<Employee> GetAll()
        {
            return _employees;
        }

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Update(Employee employee)
        {
            var existing = GetById(employee.Id);
            if (existing != null)
            {
                existing.Name = employee.Name;
                existing.Salary = employee.Salary;
            }
        }

        public void Delete(int id)
        {
            var existing = GetById(id);
            if (existing != null)
                _employees.Remove(existing);
        }
    }
}
