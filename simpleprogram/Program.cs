char initial = 'A';
int count = 10;
bool isActive = true;
string message = "Hello World";
double price = 10.00;

Console.WriteLine("Hello World");
Console.WriteLine("Welcome to c# programming");
Console.WriteLine("I love doing new things");
Console.WriteLine($"initial:{initial}","count:{count}","isActive:{isActive}","message:{message}","price:{price}");

if (isActive) {

    Console.WriteLine("The Application is active");

}
else {
    Console.WriteLine("The Application is not active");
}

Console.WriteLine("please select an option:");
Console.WriteLine("1.start application");
Console.WriteLine("2.Exit application");

int choice = Convert.ToInt32(Console.ReadLine());

switch (choice) {
    case 1:
        Console.WriteLine("Application started successfully");
        break;

    case 2:
        Console.WriteLine("Exiting Application");
        break;

    default:
        Console.WriteLine("Invalid choice. Please try again");
        break;
}
        










