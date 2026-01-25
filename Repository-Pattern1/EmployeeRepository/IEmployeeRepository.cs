// File: DataAccess/IEmployeeRepository.cs
using System.Collections.Generic;
using Models;
namespace DataAccess
{
    public interface IEmployeeRepository
    {
        Employee GetById(int id);
        List<Employee> GetAll();
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
    }
}
