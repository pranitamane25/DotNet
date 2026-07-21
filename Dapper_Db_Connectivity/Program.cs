
using System.Configuration;
using Dapper;
using Dapper_Db_Connectivity.Employee;
using MySql.Data.MySqlClient;
public class DapperdbConn
{
    static void Main(String[] args)
    {
       string ConnectionString ="server=localhost;database=Employee_db;user=root;password=password;";

       using MySqlConnection connection=new MySqlConnection(ConnectionString);
       string query="select * from employee";
       List<Employee>employees=connection.Query<Employee>(query).ToList();
       Console.WriteLine("Employee Details");

       foreach(Employee emp in employees)
        {
            Console.WriteLine($"{emp.id},{emp.Name},{emp.Salary}");
        }
    }
}