using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MySchool.Controllers;
[ApiController]
[Route("[controller]")]

public class HelloController:ControllerBase
{
    private static List<string> students = new List<string>

{
    "Pranita","Tejal","Rutuja"
};
[HttpGet]
public IEnumerable<string> GetStudents()
{
    return students;
}
[HttpGet("{Id}")]
public string GetStudent(int id)
{
    if (id < 0 || id >= students.Count) 
    return "students not found";

    return students[id];
}
[HttpPost]
public IActionResult AddStudent([FromBody] string name)
{
    students.Add(name);
    return Ok($"student{name} added successfully!");
}
}










