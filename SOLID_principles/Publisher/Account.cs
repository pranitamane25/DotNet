
using System.Collections.Generic;
using SOLID_principles.Listeners;
using SOLID_principles.Services;
using SOLID_principles.Publisher.Operations;

public class Account : IDepositOperation , IWithdrawOperation
{
    private double balance;

    private readonly List<IAccountListener> listeners =
        new List<IAccountListener>();

    private readonly INotificationService service;

    public double Balance
    {
        get { return balance; }
    }

    public Account(double amount,
                   INotificationService notificationService)
    {
        service = notificationService;
        balance = amount;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        CheckBalance();
    }

    public void Withdraw(double amount)
    {
        balance -= amount;
        CheckBalance();
    }

    private void CheckBalance()
    {
        if (balance < 1000)
        {
            foreach (IAccountListener listener in listeners)
            {
                listener.onUnderBalance(balance);

                service.send(
                    "Amount is less than minimum balance policy");
            }
        }

        if (balance > 250000)
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
}