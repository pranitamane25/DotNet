using System;

using SOLID_principles.Publisher;
using SOLID_principles.Departments;
using SOLID_principles.Services;

public class Program
{
    public static void Main(string[] args)
    {
        //NotificationService smsService = new SMSService();

        Account account = new Account(5000, smsService);


        account.Withdraw(4500);

        account.Deposit(300000);
    }
}