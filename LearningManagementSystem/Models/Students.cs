using LearningManagementSystem.models;

public class Students:Person
{
    
    public List<Course>Enrolledcourses{get;set;}
    public Students(){

    Enrolledcourses = new List<Course>();
    }

    public Students(int id, string name) : base(id, name)
    {
        Enrolledcourses = new List<Course>();
    }

    public void Entrolledcourses(Course course)
    {
        Enrolledcourses.Add(course);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Student Id: {id}");
        Console.WriteLine($"Student Name: {name}");
        Console.WriteLine($"Courses Count: {Enrolledcourses.Count}");
    }
}
