using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using EmployeeEntity;
namespace IOManager {

    public class EmployeeFileIO
    {


        public EmployeeFileIO()
        {

        }        
        
        private string FilePath = "Employee.json";
        public void SaveData(List<Employee> employees)
        {
            string json = JsonSerializer.Serialize(employees,new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(FilePath, json);
            Console.WriteLine("Employee data saved to file");
        }


        public List<Employee> LoadData()
        {
          string jsonString = File.ReadAllText(FilePath);
            List<Employee> employees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
            return employees;
        }
}
}