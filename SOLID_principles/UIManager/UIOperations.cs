
namespace SOLID_principles.UIOperations;
using SOLID_principles.Publisher;
using SOLID_principles.Models;
using SOLID_principles.Repositories;
using SOLID_principles.Publishers;
public class UIOperations
{
    public void UIManager()
    {
         AccountsManager accountManager=new AccountsManager();
         Account acct=new Account();
    while(true){
        Console.WriteLine("Enter Your Choice");
        Console.WriteLine("1.Deposit");
        Console.WriteLine("2.Withdraw");
        Console.WriteLine("3.FundTransfer");
        Console.WriteLine("4.CheckBalance");

        int choice=Convert.ToInt32(Console.ReadLine());

        switch (choice){
            
            case 1:
            Console.WriteLine("Enter account number");
            int RecordDeposit=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount");
            double amount=Convert.ToInt32(Console.ReadLine());
            accountManager.RecordDeposit(RecordDeposit,amount);
            break;

            case 2:
            Console.WriteLine("Enter account number: ");
            int accountId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount");
            double number=Convert.ToInt32(Console.ReadLine());
            accountManager.RecordWithdraw(accountId,number);
            break;

            case 3:
            Console.WriteLine("Enter from account number");
            int fromAccountId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter to account number");
            int toAccountId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter tranfered amount");
            double amount1=Convert.ToInt32(Console.ReadLine());
            accountManager.FundTransfer(fromAccountId,toAccountId,amount1);
            break;

            case 4:
            Console.WriteLine("Please Enter your account number");
            int acc=Convert.ToInt32(Console.ReadLine());
            accountManager.BalanceCheck(acc);

            break;
        }
        }
}


}