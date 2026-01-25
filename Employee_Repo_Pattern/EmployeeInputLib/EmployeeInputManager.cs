namespace EmployeeInputLib;

using EmployeeEntity;
public class EmployeeInputManager
{

    public Employee GetEmployeeFromConsole()
    {
        Employee emp = new Employee();
        
        //take input from user

        Console.WriteLine("Enter Employee Id:");
        emp.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Employee name:");
        emp.Name = Console.ReadLine();

        Console.WriteLine("Enter Employee Salary:");
        emp.Salary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Employee Department:");
        emp.Department = Console.ReadLine();
        //save this employee
        return emp;
    }
   //takes a list of Employee objects and prints each one.
    public void ShowAll(List<Employee> employees)
    {
        if (employees != null)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Id},{employee.Name}.{employee.Salary},{employee.Department}");
            }
        }
        else
        {
            Console.WriteLine("Employee not found");
        }
    }
}
