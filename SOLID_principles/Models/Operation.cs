namespace SOLID_principles.Models;

public class Operation
{
  public  double AccountId {get; set;}
  public  double amount{get; set;}

  public  DateTime Transactiontime{get; set;}
  public string  OperationType{get;set;}
  public int  Balance{get;set;}

  public int InterestRate{get;set;}
}
