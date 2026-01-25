
using System;
class Program
{
    public static async Task Main(String[] args)
    {
        Console.WriteLine("Program started");

// Call an asynchronous method

        String result = await FetchDataAsync();

        Console.WriteLine(result);

        Console.WriteLine("program ended");

}
// Async method simulating a long-running operation
static async Task <string>FetchDataAsync()
{
    Console.WriteLine("Fetching data");
    
    // Simulate delay (like calling an API or reading a file)
    await Task.Delay(3000);//3 seconds
    return "data fetch successfully";
}
}
 


