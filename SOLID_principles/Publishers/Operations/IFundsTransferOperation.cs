using System.ComponentModel.DataAnnotations;

namespace SOLID_principles.interfaces;

public interface IFundsTransferOperation
{
    void FundTransfer(int fromAccountId, int toAccountId, double amount);
}
