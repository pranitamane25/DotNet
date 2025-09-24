namespace HR;
public class QuestionBank
{
    public string Name { get; set; }
    public string Subject { get; set; }
    public int TotalQuestion { get; set; }
    // public string Student { get; set; }
    public QuestionBank()
    {
        this.Name = "pranita";
        this.Subject = "english";
        this.TotalQuestion = 7;

    }
        
    //      public override string ToString()
    // {
    //     return $"Name: {Name}, Subject: {Subject}, Total Questions: {TotalQuestion}";
    // }
}
