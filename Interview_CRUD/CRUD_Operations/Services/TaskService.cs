using CRUD_Operations.Models;
using CRUD_Operations.Repositories;

namespace CRUD_Operations.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repo;

        public TaskService(ITaskRepository repo)
        {
            _repo = repo;
        }

        public List<TaskItem> GetAll()
        {
            return _repo.GetAll();
        }

        public void Add(TaskItem task)
        {
            task.Status = "Pending";
            _repo.Add(task);
        }
    
    public void update(TaskItem task)
    {
        _repo.update(task);
    }
    public void delete(int id)
    {
        _repo.delete(id);
    }
}
}