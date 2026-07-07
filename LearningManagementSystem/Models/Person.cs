
namespace LearningManagementSystem.models;
public abstract class Person
{
    public int id{get;set;}
    public string name{get;set;}


protected Person()
{
    
}

protected Person(int id,string name)
    {
     id= id;
     name=name;
    }


public abstract void DisplayInfo();
       
}