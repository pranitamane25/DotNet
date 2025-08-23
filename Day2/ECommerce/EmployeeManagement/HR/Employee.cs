namespace HR;


public abstract class Employee
{

    public int Id{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string Email{get;set;}
     public string ContactNumber{get;set;}
    public string Location{get;set;}
    public DateTime BirthDate{get;set;}

    public float DA{get;set;}
    public float HRA{get;set;}
    public float BasicSalary{get;set;}

    //Constructor Chaining
    public Employee():this(12,"Pranita", "Mane", "pranita25@gmail.com", "9881735801",
                           "Pune", new DateTime(2002,6,25),1000,10000,15000){
        
    }

    public Employee(int id, string firstName, string lastName, 
                    string email, string contactNumber, string location,
                    DateTime bDate, float da, float hra, float bsal
                    ){
        this.Id=id;
        this.FirstName=firstName;
        this.LastName=lastName;
        this.Email=email;
        this.Location=location;
        this.ContactNumber=contactNumber;
        this.BirthDate=bDate;
        this.BasicSalary=bsal;
        this.HRA=hra;
        this.DA=da;
    }
   
   public abstract void DoWork();

   public virtual float ComputePay(){ 
    float  pay=(DA * 25) + BasicSalary + HRA;
    return pay;
   }

    public override string ToString()
    {
        string str=string.Format("{0} , {1}, {2}, {3}, {4} {5}", Id, FirstName, LastName, Email,
                                                    ContactNumber, Location);
        return str;
        //return base.ToString();
    }

}