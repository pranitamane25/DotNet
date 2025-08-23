using System;
using Date;
namespace MyApp{


    public class employee{

        public String Id{get;set;}
        public String Name{get;set;}

        public Mydate DateOfJoin{get;set;}
        public Mydate DateOfLeave{get;set;}

        public employee(string id,string name,Mydate dateofjoin, Mydate dateofleave )
        {
             Id=id;
             Name=name;
             DateOfJoin=dateofjoin;
             DateOfLeave=dateofleave;
        }
        
        public override string ToString(){

            return $"employee Id:{Id},Name:{Name},DateOfJoin:{DateOfJoin},DateOfLeave:{DateOfLeave}";
        }
    }
}

