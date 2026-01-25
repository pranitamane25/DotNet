
using System;
using System.Data;
// using System.Security.Cryptography.X509Certificates;
// using System.Xml;
using MySql.Data.MySqlClient;
// using Mysqlx.Resultset;
// using Org.BouncyCastle.Crypto.Signers;

namespace DatabaseApp

{
    public class DisconectedDatabaseHelper
    {
        private readonly string _connectionString;
        private readonly string _tablename = "employee";
        public DisconectedDatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
        // CREATE TABLE (still connected, only run once)
        public void CreateTable()
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = @"CREATE TABLE IF NOT EXISTS employee(
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            name VARCHAR(255) NOT NULL,
                            email VARCHAR(255) NOT NULL)";

            using var cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            Console.WriteLine("table is created(if not exist)");
        }
        // GET employees into DataTable (disconnected)


        public DataTable GetEmployees()
        {
            using var connection = GetConnection();
            string sql = "select id,name,email from employee";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, _tablename); // fetch data into dataset

            Console.WriteLine("data fetch in disconnected mode");
            return ds.Tables[_tablename];
        }

        // INSERT (disconnected)

        public void InsertEmployee(string name, string email)
        {
            using var connection = GetConnection();

            string sql = "select id,name,email FROM employee ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

            DataSet ds = new DataSet();
            adapter.Fill(ds, _tablename);

            DataTable dt = ds.Tables[_tablename];
            DataRow newRow = dt.NewRow();
            newRow["name"] = name;
            newRow["email"] = email;
            dt.Rows.Add(newRow);
            adapter.Update(ds, _tablename);
            Console.WriteLine("inserted one row(Disconnected)");
        }
        // UPDATE (disconnected)
        public void UpdateEmployee(int id, string newName, string newEmail)
        {
            using var connection = GetConnection();
            string sql = "select id,name,email FROM employee";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

            DataSet ds = new DataSet();
            adapter.Fill(ds, _tablename);
            DataTable dt = ds.Tables[_tablename];

            foreach (DataRow row in dt.Rows)
            {
                if ((int)row["id"] == id)
                {
                    row["name"] = newName;
                    row["email"] = newEmail;
                }
            }
            adapter.Update(ds, _tablename);
            Console.WriteLine("Updated one row(Disconnected)");
        }
        // DELETE (disconnected)

        public void DeleteEmployee(int id)
        {
            using var connection = GetConnection();
            string sql = "select * from employee";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds, _tablename);
                DataTable dt = ds.Tables[_tablename];

                foreach (DataRow row in dt.Rows)
                {
                    if ((int)row["id"] == id)
                    {
                        row.Delete(); // mark for deletion
                        Console.WriteLine("Rocord is marked delete");
                        break;
                    }
                }
                adapter.Update(ds, _tablename);
                Console.WriteLine("deleted one row(Disconnected)");
            }
            catch (Exception)
            {
                Console.WriteLine("exception.message");
            }
            finally { }
        }

        
        public DataTable GetEmployeeById(int empId)
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();
            using var cmd = new MySqlCommand("GetEmployeeById", connection);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("empId", empId);
    
                // Use DataAdapter to fill DataSet (disconnected)
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                
                DataSet ds = new DataSet();
                adapter.Fill(ds, _tablename);
                return ds.Tables[_tablename];
            }
        }

    }
}



