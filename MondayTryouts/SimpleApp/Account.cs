namespace Banking;

public class Account
{

    //data members - fields
    //encapsulation - data hiding
    private double balance;  //public, protected, private, internal (Access Specifiers)


    //Member functions - methods

    //getters and setters
    public double GetBalance()
    {
        return balance;
    }

    public void SetBalance(double amount)
    {
        if (amount >= 0)
        {
            balance = amount;
        }
        else
        {
            Console.WriteLine("Balance cannot be negative.");
        }
    }
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew: {amount:C}. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

}