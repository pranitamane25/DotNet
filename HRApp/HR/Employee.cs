using HR.Interfaces;
namespace HR;

public abstract class Employee{
public int Id{get;set;}
public string FirstName{get;set;}
public string Lastname{get;set;}
public string Email{get;set;}
public string City{get;set;}
public string ContactNumber{get;set;}
 public DateTime DateOfBirth { get;set;}
 public double Salary{get;set;}
 public string Location{get;set;}

 public Employee( int id, string firstName, string lastName,string email,string contactNumber,string location, string city, DateTime dateOfBirth, double salary)
    {
        Id=id;
        FirstName=firstName;
        Lastname=lastName;
        Email=email;
        ContactNumber=contactNumber;
        Location=location;
        DateOfBirth=dateOfBirth;
        Salary=salary;
        City=city;
    }

public  abstract void DoWork();
public virtual double ComputePay()
{
    return Salary;
}

public override string ToString()
{

    return "Employee  "+ this.FirstName + " "+ this.Lastname + " "+ this. City + this.Location;

}

};