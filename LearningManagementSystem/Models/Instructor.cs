using LearningManagementSystem.models;
public class Instructor : Person
{
    
    public List<Course>AssignedCourses{get;set;}

    public Instructor()
    {
        AssignedCourses = new List<Course>();
    }

    public Instructor(int id, string name) : base(id, name)
    {
        AssignedCourses= new List<Course>();

    }

    public void AssignedCourse(Course course)
    {
        AssignedCourses.Add(course);
    }

      public override void DisplayInfo()
    {
        Console.WriteLine($"Instructor Id: {id}");
        Console.WriteLine($"Instructor Name: {name}");
        Console.WriteLine($"Assigned Courses: {AssignedCourses.Count}");
        
    }
}
