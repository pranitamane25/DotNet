using Emp_CRUD.Models;
namespace Emp_CRUD.Repositories{

public interface IEmployeeRepository{

     void Add(Employee emp);

     List<Employee> GetAll();

    
}
}