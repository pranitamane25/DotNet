namespace InsuranceApp.Models;

public class Policy
{
    public int PolicyId { get; set; }
    public string CustomerName { get; set; }
    public double PremiumAmount { get; set; }

    public Policy()
    {
    }

    public Policy(int policyId,
                  string customerName,
                  double premiumAmount)
    {
        PolicyId = policyId;
        CustomerName = customerName;
        PremiumAmount = premiumAmount;
    }

    public override string ToString()
    {
        return $"Policy Id: {PolicyId}, " +
               $"Customer: {CustomerName}, " +
               $"Premium: {PremiumAmount}";
    }
}