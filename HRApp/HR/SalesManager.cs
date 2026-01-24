using System;

namespace HR.Interfaces;

public class SalesManager : SalesEmployee
{
    private double Bonus;

    //parameterised constructor
    public SalesManager(int id, string firstName, string lastName,string email,string contactNumber,string location, string city,
     DateTime dateOfBirth, double salary,double incentive,double target,double achievedTarget,double basicSalary,double hra,double bonus) : base (id,firstName,lastName,email,contactNumber,location,city,dateOfBirth,salary,incentive,target,achievedTarget,basicSalary,hra)

    {
        Bonus=bonus;
    }
    //override abstract method

    public override void DoWork()
    {
        Console.WriteLine($"{FirstName} is managing the sales team and strategy.");
    }

    //override virtual method

    public override double ComputePay()
    {
        return base.ComputePay() + Bonus;
    }
}
