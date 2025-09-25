namespace HR;
public class QuestionBank
{
    public string Name { get; set; }
    public string Subject { get; set; }
    public int TotalQuestion { get; set; }
   
    public QuestionBank()
    {
        this.Name = "pranita";
        this.Subject = "c# prog";
        this.TotalQuestion = 20;

    }
        
    //      public override string ToString()
    // {
    //     return $"Name: {Name}, Subject: {Subject}, Total Questions: {TotalQuestion}";
    // }
}