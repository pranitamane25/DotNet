
using System;
using MyApp;
namespace Date{

public class Mydate
{
    
    public string Day { get; set; }
    public string Month { get; set; }
    public string Year { get; set; }

    public Mydate()//default constructor
    {
        Day = "21";
        Month = "8";
        Year = "2025";
    }
    public Mydate(string day, string month, string year)//parametrised constructor
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public override string ToString(){

        return $"{Day}/{Month}/{Year}";
    }
    // public void Display()
    // {
    //     Console.WriteLine($"{day}, {month}, {year}");
    // }

    public static void Main(string[] args)
    {
        // Mydate emp = new Mydate();
        // Console.WriteLine(emp.ToString());
        
        Mydate join=new Mydate("1","01","2024");
        Mydate leave=new Mydate("21","8","2025");

        employee emp=new employee("1","Pranita",join,leave);
        Console.WriteLine(emp);
    }

}
}