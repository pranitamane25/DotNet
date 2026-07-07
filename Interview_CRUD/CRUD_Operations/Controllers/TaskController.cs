using Microsoft.AspNetCore.Mvc;
using CRUD_Operations.Models;
using CRUD_Operations.Services;

namespace CRUD_Operations.Controllers{

[ApiController]
[Route("[controller]")]

public class TaskController : ControllerBase
{
    private readonly ITaskService _service;

    public TaskController(ITaskService service){
        _service=service;
    }
    
    [HttpGet("GetAll")]
    public IActionResult GetAll(){
        return Ok(_service.GetAll());
    }

    [HttpPost("Add")]
    public IActionResult Add ([FromBody]TaskItem task){
        _service.Add (task);
        return Ok("Task created");
    }

  [HttpPut("update/{id}")]
    public IActionResult update(int id,[FromBody] TaskItem task){
        task.TaskId = id;
        _service.update(task);
        return Ok("task updated");
    }  

    [HttpDelete("delete/{id}")]
    public IActionResult delete(int id){
       // task.TaskId=id;
        _service.delete(id);
        return Ok("Task deleted successfully");
    }
      
}
}
