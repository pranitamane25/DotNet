namespace Day1C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Pranita";
            int age = 25;
            string city = "pune";
            string degree = "MCA";
            float percentage = 75.5f;

            Console.WriteLine("Name: " + name); 
            Console.WriteLine("Age: " + age);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Degree: " + degree);
            Console.WriteLine("Percentage: " + percentage);

            int EmployeeId = 12345;
            string EmployeeName = "Pranita";
            double EmployeeSalary = 50000.50;
            string Department = "IT";
            bool IsActive = true;

            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Employee Name: " + EmployeeName);
            Console.WriteLine("Employee Salary: " + EmployeeSalary);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Is Active: " + IsActive);

            int a = 40;
            int b = 60;

            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            int division = a / b;
            int remainder = a % b;

            Console.WriteLine("Addition: " + addition);
            Console.WriteLine("Subtraction: " + subtraction);
            Console.WriteLine("Multiplication: " + multiplication);
            Console.WriteLine("Division: " + division);
            Console.WriteLine("Remainder: " + remainder);

            //swapping two numbers

            int a1 = 10;
            int b1 = 20;
            int temp;

            temp = a1;
            a1 = b1;
            b1 = temp;

            Console.WriteLine($"After swapping the numbers a1; {a1}and b1:{b1}");






        }
    }
}
