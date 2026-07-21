using System;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            IConfiguration configuration=new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json",optional:false,reloadOnChange:true)
            .Build();

            string ConnectionStrings=configuration.GetConnectionString("DefaultConnection");
            string query="select * from Employee";

            using (MySqlConnection conn=new MySqlConnection(ConnectionStrings))
            {
                MySqlDataAdapter adapter=new MySqlDataAdapter(query,conn);
                DataTable table=new DataTable();
                adapter.Fill(table);
                Console.WriteLine("Employee Details");

                foreach(DataRow row in table.Rows)
                {
                    Console.WriteLine($"id:{row["id"]},Name:{row["Name"]},Salary:{row["salary"]}");
                }
                Console.WriteLine("Data loaded successfully");
            }
        }
            catch(Exception ex)
        {
            Console.WriteLine("Error Message:" +ex.Message);
        }
        }
}
