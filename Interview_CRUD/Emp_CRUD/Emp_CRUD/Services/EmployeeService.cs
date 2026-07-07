using Emp_CRUD.Models;
//using Emp_CRUD.Services;
using Emp_CRUD.Repositories;
namespace Emp_CRUD.Services{

public class EmployeeService:IEmployeeService{

    private readonly IEmployeeRepository _repo;

    public EmployeeService(IEmployeeRepository repo){
        _repo = repo;
    }

    public void Add(Employee emp){

          _repo.Add(emp);
    }

    public List<Employee>GetAll()
    {
         return _repo.GetAll();
    }
}
}