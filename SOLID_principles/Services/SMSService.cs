namespace SOLID_principles.Services;

public class SMSService : INotificationService
{
    public void send(String message) {
      Console.WriteLine("SMS: "+ message);
    }
}