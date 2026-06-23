namespace SOLID_principles.Publisher.Operations;
public interface IDepositOperation
{
    void Deposit(int accountId, double amount);
}