using EmployeeRepo;
using System.Collections.Generic;
using EmployeeEntity;
using IOManager;


public class EmployeeRepositoryImpl : IEmployeeRepository
{
    private List<Employee> employees = new List<Employee>();
    public List<Employee> GetAllEmployees()
    {

        EmployeeFileIO mgr = new EmployeeFileIO();
        List<Employee> allEmployees = mgr.LoadData();
        return allEmployees;
    }

    public void AddEmployee(Employee employee)
    {

        EmployeeFileIO mgr = new EmployeeFileIO();
        List<Employee> allEmployees = mgr.LoadData();

        //check duplicate id or not
        bool idExists = false;
        foreach (Employee e in allEmployees)
        {
            if (e.Id == employee.Id)
            {
                if (idExists = true) ;
                break;
            }
        }
        if (idExists)
        {
            Console.WriteLine($"employeeId already exist{employee.Id}");
        }

        allEmployees.Add(employee);
        mgr.SaveData(allEmployees);

        Console.WriteLine($"Employee id{employee.Id}already exists");
    }
    
    public void DeleteEmployee(int id)
    {
        EmployeeFileIO mgr = new EmployeeFileIO();
        List<Employee> allEmployee = mgr.LoadData();

        bool found = false;
        for (int i = 0; i < allEmployee.Count; i++)
        {
            if (allEmployee[i].Id == id)
            {
                allEmployee.RemoveAt(i);
                found = true;
                break ;
            }
        }
        if (found)
        {
            mgr.SaveData(allEmployee);
            Console.WriteLine($"Employee with ID {id} deleted successfully");
        }
        else
        {
            Console.WriteLine($"employee ID{id} not found");
        }
    }

}
    
