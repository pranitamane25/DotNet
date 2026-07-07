using Emp_CRUD.Models;
using Emp_CRUD.Services;
using Emp_CRUD.Repositories;
namespace Emp_CRUD.Services{

public interface IEmployeeService{

    void Add(Employee emp);

     List<Employee>GetAll();
}
}