namespace SOLID_principles.Listeners;

public class AccountsDepartment : IAccountListener
{
    public void onUnderBalance(double balance)
    {
        Console.WriteLine("Department current balance "+ balance);
    }

    public void onOverBalance(double balance)
    {
        Console.WriteLine("Department current balance" + balance);
    }
}