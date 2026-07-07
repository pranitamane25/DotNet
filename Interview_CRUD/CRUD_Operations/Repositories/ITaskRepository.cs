using CRUD_Operations.Models;
using System.Collections.Generic;
using CRUD_Operations.Repositories;

public interface ITaskRepository
{
    List<TaskItem>GetAll();

    void Add(TaskItem item);

    void update(TaskItem task);

    void delete(int id);
    
}
