using System;
using System.Linq;
using System.Collections.Generic;

namespace Analytics
{
    class Person  
    {  
        public string FirstName { get; set; }  
        public string LastName { get; set; }  
        public int Age { get; set; }   
    }   
    static void FindAllNumbersMultipleOf2(){
      
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };  
        List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);  

        foreach (var num in evenNumbers)  
        {     Console.Write("{0} ", num);   }  
        Console.WriteLine();  
    }

}

