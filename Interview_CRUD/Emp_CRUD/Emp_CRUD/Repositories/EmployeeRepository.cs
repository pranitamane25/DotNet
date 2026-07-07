using Emp_CRUD.Models;
using Microsoft.Extensions.Configuration; 

using MySql.Data.MySqlClient;

namespace Emp_CRUD.Repositories{

public class EmployeeRepository:IEmployeeRepository{

    private readonly IConfiguration _config;

    public EmployeeRepository(IConfiguration config){
        _config = config;
    }

    private MySqlConnection GetConnection(){
        return new MySqlConnection(
            _config.GetConnectionString("DefaultConnection")
        );
        }

    public void Add(Employee emp){
    
using (var conn = GetConnection()){

conn.Open();

string query = @"insert into employee (name,email,dept_id) values (@n,@e,@d)";

using (var cmd = new MySqlCommand(query,conn))
{
    cmd.Parameters.AddWithValue("@n",emp.Name);
    cmd.Parameters.AddWithValue("@e",emp.Email);
    cmd.Parameters.AddWithValue("@d",emp.DeptId);

    cmd.ExecuteNonQuery();
}}
}

public List<Employee> GetAll(){

  var list = new List<Employee>();

    using (var conn = GetConnection()){
        conn.Open();

        string query = "select e.emp_id , e.name, e.email,e.dept_id,d.dept_name from employee e join department d on e.dept_id = d.dept_id";

         using (var cmd = new MySqlCommand(query , conn))
            using (var reader = cmd.ExecuteReader()){
                while(reader.Read()){
                    list.Add(new Employee{

                        EmpId = Convert.ToInt32(reader["emp_id"]),
                        Name = reader["name"].ToString(),
                        Email = reader["email"].ToString(),
                        DeptId = Convert.ToInt32(reader["dept_id"]),
                        DeptName = reader["dept_name"].ToString()
                });
                }
            }

            
         }
         return list;
    }
}
}


