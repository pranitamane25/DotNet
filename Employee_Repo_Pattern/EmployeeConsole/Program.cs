using EmployeeEntity;
using EmployeeInputLib;

namespace EmployeeRepo
{
    class Program
    {
        public static void Main(String[] args)
        {
            IEmployeeRepository repo = new EmployeeRepositoryImpl();
            string choice;
            EmployeeInputManager mgr = new EmployeeInputManager();

            do
            {
                // Add employees (by entering details in console)
                Employee emp = mgr.GetEmployeeFromConsole();
                repo.AddEmployee(emp);
                Console.WriteLine("Do you want to add another employee:");
                choice = Console.ReadLine();
            } while (choice.ToLower() == "yes");
            
            //Add employees (by entering details in console)

            List<Employee> employees = repo.GetAllEmployees();
            mgr.ShowAll(employees);
           
           //Delete an employee by ID
            Console.WriteLine("Enter Employee id to Delete");
            int id = Convert.ToInt32(Console.ReadLine());
            repo.DeleteEmployee(id);
        }
    }
}





