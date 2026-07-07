using Microsoft.AspNetCore.Mvc;
using Emp_CRUD.Models;     
using Emp_CRUD.Services;
namespace Emp_CRUD.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _service;

    public EmployeeController(IEmployeeService service){
        _service = service;
    } 
     
    [HttpPost]
    public IActionResult Add([FromBody]Employee emp){
        _service.Add(emp);
        return Ok("value inserted");
    }

    [HttpGet]
    public IActionResult GetAll(){

     var employees = _service.GetAll();
      return Ok(employees);
        
    }
  }

