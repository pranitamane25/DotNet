class Program
{
    static async Task Main(String[] args)
    {
        Console.WriteLine("main thread started");


        Task task1 = PrintNumbersAsync();
        Task task2 = PrintAlphabetsAsync();

        Console.WriteLine("Main thread is free to do other work");

        await Task.WhenAll(task1, task2);
        Console.WriteLine("All tasks completed");

    }

    static async Task PrintNumbersAsync()
    {
        await Task.Run(() =>
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"[Task 1] Number{i}");
                Task.Delay(500).Wait();
            }
        });
    }

    static async Task PrintAlphabetsAsync()
    {
        await Task.Run(() =>
        {
            for (char c = 'A'; c <= 'E'; c++)
            {
                Console.WriteLine($"[task2] Alphabets{c}");
                Task.Delay(500).Wait();
            }
        });

    }
}
    
