namespace SOLID_principles.Publishers;
public class Program
{
    public static void Main(string[] args)
    { 
        AccountsManager accountManager=new AccountsManager();

        Console.WriteLine("Enter Your Choice");
        Console.WriteLine("1.Deposit");
        Console.WriteLine("2.Withdraw");
        Console.WriteLine("3.FundTransfer");

        int choice=Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
            
            bool status=accountManager.RecordDeposit(1001,20000);
                if (status)
                {
                    Console.WriteLine("Deposit Successful");
                }
                else
                {
                    Console.WriteLine("Deposit Fail");
                }
            break;

            case 2:

            bool status1=accountManager.RecordWithdraw(1001,50000);
                if (status1)
                {
                    Console.WriteLine("Withdraw Successful");
                }
                else
                {
                    Console.WriteLine("Withdraw Failed");
                }
                break;

                // case 3:

                // bool status2=accountManager.FundTransfer(1001,1002,10000);
                // if (status2)
                // {
                //     Console.WriteLine("Fund Transfered successfully");
                // }
                // else
                // {
                //     Console.WriteLine("Fund transfer Fail");
                // }
                // break;
        
        default:
        Console.WriteLine("Invalid choice");
        break;
    }
}
}