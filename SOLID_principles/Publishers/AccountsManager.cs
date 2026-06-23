using SOLID_principles.Models;
using SOLID_principles.Repositories;
namespace SOLID_principles.Publishers;
public class AccountsManager
{
       public bool RecordDeposit(int accountId, double amount)
    {
        bool status=false;
         AccountsRepository  mgr=new AccountsRepository();
        List<Account> allExistingAccounts=mgr.LoadFromFile(@"Data/accounts.json");
        foreach(Account theAccount in allExistingAccounts)
        {
            if(theAccount.AccountNo == accountId)
            {
                theAccount.Deposit(accountId,amount);
                mgr.SaveToFile(@"Data/accounts.json",allExistingAccounts);
                OperationsRepository opRepo=new OperationsRepository();
                List<Operation> allExistingOperations=opRepo.LoadFromFile(@"Data/operations.json");
                Operation theOperation=new Operation
                {
                  AccountId=accountId,
                   amount=amount,
                   OperationType="D",
                    Transactiontime=DateTime.Now
                };
                allExistingOperations.Add(theOperation);
                opRepo.SaveToFile(@"Data/operations.json",allExistingOperations);
           }
        }
        return status;
    }
 public bool RecordWithdraw(int accountId, double amount)
    {
        bool status=false;
        AccountsRepository mgr=new AccountsRepository();
        List<Account> allExistingAccounts=mgr.LoadFromFile(@"Data/accounts.json");
        foreach(Account theAccount in allExistingAccounts)
        {
            if(theAccount.AccountNo == accountId)
            {
                theAccount.Withdraw(accountId,amount);
                mgr.SaveToFile(@"Data/accounts.json",allExistingAccounts);
                OperationsRepository opRepo=new OperationsRepository();
                List<Operation>allExistingOperations=opRepo.LoadFromFile(@"Data/operations.json");
                Operation theOperation=new Operation
                {
                    AccountId=accountId,
                    amount=amount,
                    Transactiontime=DateTime.Now,
                    OperationType="W"
                };
                allExistingOperations.Add(theOperation);
                opRepo.SaveToFile(@"Data/operations.json",allExistingOperations);
                status=true;
           

            //load all list of operations from operations.json file

            //write logic to store accountId, Amount, type=D, Time: now in operations collection
            //store collection into operations.json file
        }
        }
        return status;
    }

    // public bool RecordOperation(int accountid, double amount, string mode)
    // {
    //     FileIOOperations operations=new FileIOOperations();
    //         List<Operations>allExistingOperations=operations.LoadFromOperations(@"Data/Operations.json");

    //         Operations Transaction=new Operations
    //         {
    //             DebitAccNo= fromAccountId,
    //             creditAccNo=toAccountId,
    //             amount=amount,
    //             Transactiontime=DateTime.Now
    //         };
    //         allExistingOperations.Add(Transaction);
    //         operations.SaveOperationsToFile(@"Data/Operations.json",allExistingOperations);
    //         return true;         
    // }
    // public bool FundTransfer(int fromAccountId, int toAccountId, double amount)
    // {
    //     bool  statusWithdraw=RecordWithdraw(fromAccountId,amount);
    //     bool statusDeposit=RecordDeposit(toAccountId,amount);
    //     if(statusWithdraw ==true && statusDeposit == true)
    //     {
    //            return true;

    //     }
    //     return false;
    // }
}