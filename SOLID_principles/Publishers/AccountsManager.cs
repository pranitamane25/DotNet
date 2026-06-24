using SOLID_principles.Models;
using SOLID_principles.Repositories;
namespace SOLID_principles.Publishers;
using System.Linq;  
using System.Collections.Generic;
public class AccountsManager
{
    Account accounts= new Account();
    
    AccountsRepository  mgr=new AccountsRepository();
        public bool RecordDeposit(int accountId, double amount)
    {
        bool status=false;
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
                GetBalance(accountId);
                opRepo.SaveToFile(@"Data/operations.json",allExistingOperations);
                status = true;
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
                if (theAccount.Balance < amount)
                {
                    Console.WriteLine("Insufficient balance");
                    return false;
                }
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
                GetBalance(accountId);
                opRepo.SaveToFile(@"Data/operations.json",allExistingOperations);
                status=true;
        }
        }
        return status;
    }
    public bool FundTransfer(int fromAccountId, int toAccountId, double amount)
    {
        bool status=false;
        AccountsRepository mgr = new AccountsRepository();
        List<Account>AllExistingAccounts=mgr.LoadFromFile(@"Data/Operations.json");
        foreach(Account theAccount in AllExistingAccounts)
        {
            if(theAccount.AccountNo==fromAccountId);
        }
        bool  statusWithdraw=RecordWithdraw(fromAccountId,amount);
        bool statusDeposit=RecordDeposit(toAccountId,amount);
        if(statusWithdraw ==true && statusDeposit == true)
        {
               return true;
        }
        
        mgr.SaveToFile(@"Data/operations.json",AllExistingAccounts);
                OperationsRepository opRepo=new OperationsRepository();
                List<Operation>allExistingOperations=opRepo.LoadFromFile(@"Data/operations.json");
                Operation theOperation=new Operation
                {
                    AccountId=fromAccountId,
                    amount=amount,
                    Transactiontime=DateTime.Now,
                    OperationType="F"
                };
                allExistingOperations.Add(theOperation);
                opRepo.SaveToFile(@"Data/operations.json",allExistingOperations);
                status=true;
        return false; 
        } 

        public double GetBalance(int AccountNo)
    {List<Account> allExistingAccounts=mgr.LoadFromFile(@"Data/accounts.json");
        
        foreach (Account account in allExistingAccounts)
        {
            if (account.AccountNo == AccountNo)
            {
                account.LastTransaction = DateTime.Now;
                Console.WriteLine($"Balance in account with id {account.AccountHolderName}is {account.Balance}");
                mgr.SaveToFile(@"Data/operations.json",allExistingAccounts);

                return account.Balance;
            }

        }
        return 0;
    }

    public void BalanceCheck(int AccountId)
    {
        List<Account>AllExistingAccounts=mgr.LoadFromFile(@"Data/accounts.json");
        foreach(Account account in AllExistingAccounts)
        {
            if (account.AccountNo == AccountId)
            {
                Console.WriteLine("Your available balance"+account.Balance);
            }
        }
    }
            public   int CompareTransactions(Operation op1,Operation op2)
        {    
            int CompareTransaction =op2.Transactiontime.CompareTo(op1.Transactiontime);
            return CompareTransaction;
        }
        public List<Operation> GetMiniStatement(int AccountId)
        {
            OperationsRepository opRepo = new OperationsRepository();

            List<Operation> operations = opRepo.LoadFromFile(@"Data/operations.json");

            List<Operation> statements = new List<Operation>();

            foreach(Operation operation in operations)
            {
                if(operation.AccountId == AccountId)
                {
                    statements.Add(operation);
                }
            }

            statements.Sort(CompareTransactions);

            if(statements.Count > 5)
            {
                statements = statements.GetRange(0, 5);
            }

            return statements;
        }

            }

