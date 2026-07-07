
using System.Collections.Generic;
using CRUD_Operations.Models;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace CRUD_Operations.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly IConfiguration _config;

        public TaskRepository(IConfiguration config)
        {
            _config = config;
        }

        //🔹 Connection method
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(
                _config.GetConnectionString("DefaultConnection")
            );
        }

        // 🔹 Get All Tasks
        public List<TaskItem> GetAll()
        {
            List<TaskItem> list = new List<TaskItem>();

            using (var conn = GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM task";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new TaskItem
                            {

                                TaskId = Convert.ToInt32(reader["task_id"]),   
                                Title = reader["title"].ToString(),            
                                Description = reader["description"].ToString(),
                                Status = reader["status"].ToString() 
                            });
                        }
                    }
                }
            }

            return list;
        }
    public void Add(TaskItem task)
    {
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("insert into task (title,description,status)values(@t,@d,@s)",conn);

                cmd.Parameters.AddWithValue("@t",task.Title);
                cmd.Parameters.AddWithValue("@d",task.Description);
                cmd.Parameters.AddWithValue("@s",task.Status ??"pending");

                cmd.ExecuteNonQuery();

            }

    }

 public void update(TaskItem task)
{
    using (var conn = GetConnection())
    {
        conn.Open();

        string query = @"UPDATE task 
                         SET title=@t,
                             description=@d,
                             status=@s 
                         WHERE task_id=@id";

        using (var cmd = new MySqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@id", task.TaskId);
            cmd.Parameters.AddWithValue("@t", task.Title);
            cmd.Parameters.AddWithValue("@d", task.Description);
            cmd.Parameters.AddWithValue("@s", task.Status);

            cmd.ExecuteNonQuery();

            
        }
    }
}
public void delete(int id){
    using (var conn = GetConnection()){
        conn.Open();
        string query = @"delete from task where task_id=@id";

        using (var cmd = new MySqlCommand(query,conn))
        {
            cmd.Parameters.AddWithValue("@id",id);

            int rows = cmd.ExecuteNonQuery();
        }
    } 
}
}
}
