using CRUD_Operations.Models;
namespace CRUD_Operations.Services{
public interface ITaskService{

    List<TaskItem>GetAll();

    void Add(TaskItem item);
    void update(TaskItem task);
    void delete(int id);


}
}