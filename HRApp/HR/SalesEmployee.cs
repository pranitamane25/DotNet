using HR.Interfaces;
namespace HR;
public class  SalesEmployee : Employee
{
    public double Incentive;
    public double Target;
    public double AchievedTarget;
    public double BasicSalary;
    public double HRA;

    //parameterised constructor
    public SalesEmployee(int id, string firstName, string lastName,string email,string contactNumber,string location, string city,
     DateTime dateOfBirth, double salary,double incentive,double target,double achievedTarget,double basicSalary,double hra) : base (id,firstName,lastName,email,contactNumber,location,city,dateOfBirth,salary)

    {
        Incentive=incentive;
        Target=target;
        AchievedTarget=achievedTarget;
        BasicSalary=basicSalary;
        HRA=hra;
    }

//override abstract methos
    public override void DoWork()
    {
        Console.WriteLine($"{FirstName} is selling product");
    }

    //override virtual method

    public override double ComputePay()
    {
       double totalSalary=BasicSalary+HRA;

        if (AchievedTarget >= Target)
        {
            totalSalary+=Incentive;
        }
        return totalSalary;
    }
























    public void ConductAppraisal()
    {
         Console.WriteLine("Sales Employee appraisal completed.");
    }
}