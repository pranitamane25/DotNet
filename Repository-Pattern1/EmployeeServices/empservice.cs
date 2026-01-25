// File: Business/EmployeeService.cs
using System.Collections.Generic;
using Models;
using DataAccess;

namespace Business
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public Employee GetEmployee(int id)
        {
            return _repository.GetById(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return _repository.GetAll();
        }

        public void AddEmployee(Employee emp)
        {
            // You can add business rules here
            if (!string.IsNullOrEmpty(emp.Name) && emp.Salary > 0)
                _repository.Add(emp);
        }

        public void UpdateEmployee(Employee emp)
        {
            _repository.Update(emp);
        }

        public void DeleteEmployee(int id)
        {
            _repository.Delete(id);
        }
    }
}
