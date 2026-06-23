using System.Collections.Generic;
using SOLID_principles.Listeners;
using SOLID_principles.Services;
using SOLID_principles.Publisher.Operations;
using SOLID_principles.interfaces;
namespace SOLID_principles.Publishers;
public class Account : IDepositOperation , IWithdrawOperation,IFundsTransferOperation
{
    private double balance;
    public DateTime LastTransaction{get;set;}
    public int AccountNo{get;set;}
    public string AccountHolderName{get;set;}="";
    private readonly List<IAccountListener> listeners = new List<IAccountListener>();
    private readonly INotificationService? service;
    public double Balance{get;set;}
    
    public Account()
    {
        
    }
    public Account(double amount,
                   INotificationService notificationService)
    {
        service = notificationService;
        Balance = amount;
    }

    public void Deposit(int accountId,double amount)
    {
        Balance += amount;
        CheckBalance();
    }

    public void Withdraw(int accountId,double amount)
    {
        Balance -= amount;
        CheckBalance();
    }
    private void CheckBalance()
    {
        if (Balance < 1000)
        {
            foreach (IAccountListener listener in listeners)
            {
                listener.onUnderBalance(balance);

                service.send(
                    "Amount is less than minimum balance policy");
            }
        }

        if (Balance > 250000)
        {
            foreach (IAccountListener listener in listeners)
            {
                listener.onOverBalance(balance);

                service.send(
                    "Amount is greater than taxable income policy");
            }
        }
    }
    public void AddListener(IAccountListener listener)
    {
        listeners.Add(listener);
    }

    public void FundTransfer(int fromAccountId, int toAccountId, double amount)
    {

    }
}