namespace SOLID_principles.Services;
public class EmailService : INotificationService
{
    public void send(string message)
    {
        Console.WriteLine("Email" + message);
    }
}