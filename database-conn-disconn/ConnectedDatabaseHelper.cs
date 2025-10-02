using System;
using MySql.Data.MySqlClient;

namespace DatabaseApp
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;

        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        // CREATE TABLE
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
            Console.WriteLine("Table created (if not exists).");
        }

        // INSERT
        public void InsertEmployee(string name, string email)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = "INSERT INTO employee(name, email) VALUES(@name, @email)";
            using var cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);

            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine($"Inserted {rows} row(s).");
        }

        // UPDATE
        public void UpdateEmployee(int id, string newName, string newEmail)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = "UPDATE employee SET name=@name, email=@newemail WHERE id=@id";
            using var cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@name", newName);
            cmd.Parameters.AddWithValue("@newemail", newEmail);
            cmd.Parameters.AddWithValue("@id", id);

            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine($"Updated {rows} row(s).");
        }

        // DELETE
        public void DeleteEmployee(int id)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = "DELETE FROM employee WHERE id=@id";
            using var cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@id", id);

            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine($"Deleted {rows} row(s).");
        }

        // READ (SELECT)
        public void GetEmployees()
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = "SELECT id, name, email FROM employee";
            using var cmd = new MySqlCommand(sql, connection);
            using var reader = cmd.ExecuteReader();

            Console.WriteLine("Employee Records:");
            while (reader.Read())
            {
                Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Email: {reader["email"]}");
            }
        }
            //=======stored procedure call===========
             public void GetEmployeeById()
        {

            try
            {
                using MySqlConnection conn = new MySqlConnection(_connectionString);
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("GetEmployeeById", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    Console.Write("Enter employee id: ");
                    int empId = Convert.ToInt32(Console.ReadLine());

                    cmd.Parameters.AddWithValue("@empId", empId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Email: {reader["email"]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No employee found with this ID.");
                        }
                    }
                }
            }

            catch (Exception Ex)
            {
                Console.WriteLine("Exception occured");
            }
        }
    }
}

