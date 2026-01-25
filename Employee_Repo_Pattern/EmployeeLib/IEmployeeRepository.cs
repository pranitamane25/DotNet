using System.Collections.Generic;
using EmployeeEntity;


namespace EmployeeRepo
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        // Employee GetEmployeeById(int id);
        void AddEmployee(Employee employee);
        public void DeleteEmployee(int id);

       

    }
}