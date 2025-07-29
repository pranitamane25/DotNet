using System;
using System.Data;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        // Connection string to your MySQL database
        string connectionString = "Server=localhost; Port=3306; Database=emp; User=root; Password=password";

        using (MySqlConnection con = new MySqlConnection(connectionString))
        {
            try
            {
                con.Open();
                Console.WriteLine("Connected to MySQL!");

                string query = "SELECT * FROM customers";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
            Console.WriteLine($"customer_id: {reader["customer_id"]}, name: {reader["name"]}, email: {reader["email"]}, signup_date: {reader["signup_date"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
