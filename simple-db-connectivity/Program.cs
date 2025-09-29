
using System;
using MySql.Data.MySqlClient;
class directconnectivity
{
    static void Main()
    {

        string connectionString = "Server=localhost;Port=3306;Database=employee;User=root;Password=password;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        try
        {
            connection.Open();
            Console.WriteLine("connected to Mysql");
            string createTableSql = "CREATE TABLE IF NOT EXISTS employee(" +
                                    "id INT AUTO_INCREMENT PRIMARY KEY," +
                                     "name VARCHAR(255) NOT NULL," +
                                     "email VARCHAR(255) NOT NULL)";

            using (MySqlCommand createTableCmd = new MySqlCommand(createTableSql, connection))
            {
                createTableCmd.ExecuteNonQuery();
            }

            string insertSql = "insert INTO employee(name,email)VALUES(@name, @email)";
            using MySqlCommand insertCommand = new MySqlCommand(insertSql, connection);
            {
                insertCommand.Parameters.AddWithValue("@name", "Pranita Mane");
                insertCommand.Parameters.AddWithValue("email", "pranita25@tfl.com");

                int rowsAffected = insertCommand.ExecuteNonQuery();
                Console.WriteLine($" Inserted {rowsAffected}row(s)into the employee table");
            }

            //string updateSql = "update employee SET email=@newemail WHERE name=@name";
            string updateSql = "update employee SET name=@name WHERE id=@id";
            //string updateSql = "update employee SET name=@newname WHERE id=@id";

            using (MySqlCommand updateCommand = new MySqlCommand(updateSql, connection))
            {
                updateCommand.Parameters.AddWithValue("@newemail", "praniiii@gmail.com");
                updateCommand.Parameters.AddWithValue("@name","Tejal");
                updateCommand.Parameters.AddWithValue("@id", 1);
                updateCommand.ExecuteNonQuery();
            }

            string deleteSql = "delete from employee where name=@name";
            using (MySqlCommand deleteCommand = new MySqlCommand(deleteSql, connection))
            {
                deleteCommand.Parameters.AddWithValue("@name", "Pranita Mane");
                int rowsDeleted = deleteCommand.ExecuteNonQuery(); 
                Console.WriteLine($"Deleted {rowsDeleted} row(s)");
                deleteCommand.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error:{ex.Message}");
        }
        finally
        {
            connection.Close();
        }
    }
}
            
            






        


