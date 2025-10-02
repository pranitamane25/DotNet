using System;
using System.Data;
using System.Linq.Expressions;
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;
using Org.BouncyCastle.Cms;
namespace DatabaseApp;// Namespace of your DatabaseHelper

class Program
{
    static void Main(string[] args)
    {

        //connected call

        string connectionString = "Server=localhost;Port=3306;Database=employee;User=root;Password=password;";
        DatabaseHelper db = new DatabaseHelper(connectionString);
        //db.GetEmployees();
        db.DeleteEmployee(24);

        //for disconnected data fetch==========

        //DisconectedDatabaseHelper obj = new DisconectedDatabaseHelper(connectionString);
        //obj.GetEmployeeById(22);

        // Console.WriteLine(obj.GetEmployeeById(22));
        // // DataTable dt = obj.GetEmployeeById(22);
        // // foreach (DataRow row in dt.Rows)
        // {
        //     foreach (DataColumn col in dt.Columns)
        //     {
        //         Console.Write($"{col.ColumnName}: {row[col]}  ");
        //     }
        //     Console.WriteLine();
        // }


    }
}






//=========for user through input=====

            // db.CreateTable();
            // db.InsertEmployee("Pranita Mane", "pranita25@tfl.com");

            //         Console.Write("Enter employee name: ");
            //         string name = Console.ReadLine();

            //         Console.Write("Enter employee email");
            //         string email = Console.ReadLine();

            //         db.InsertEmployee(name, email);//call  the method
            //         Console.WriteLine("employee inserted successfully");


                

//db.UpdateEmployee(1, "Tejal", "tejal123@gmail.com");
// db.GetEmployees();
// db.DeleteEmployee("Pranita Mane");


// disconnected call

//string connectionString = "Server=localhost;Port=3306;Database=employee;User=root;Password=password;";
//DisconectedDatabaseHelper dbHelper = new DisconectedDatabaseHelper(connectionString);
//dbHelper.CreateTable();
// dbHelper.InsertEmployee("Pranita","pranii@gmail.com");
//dbHelper.UpdateEmployee(1, "Pranita Mane", "pranita25@gmail.com");
//dbHelper.DeleteEmployee(20);

//Console.WriteLine("Done");
// }
// }






