using Banking;
namespace HelloDotnetApp;
public class Program{

    public static void Main(string[] args)
    {
       Account myAccount = new Account(); //object creation - instantiation
       myAccount.SetBalance(1000);  //set initial balance
       myAccount.Deposit(500);      //deposit money
       myAccount.Withdraw(200);     //withdraw money
       double currentBalance = myAccount.GetBalance(); //get current balance
       Console.WriteLine($"Current balance: {currentBalance:C}");
       }
}