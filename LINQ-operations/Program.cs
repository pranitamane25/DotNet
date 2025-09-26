class program
{
    public static void Main(String[] args)
    {

        List<int> numbers = new List<int> { 5, 5, 10, 10, 15, 20, 25, 30, 35, 40 };

        //where---filter data

        Console.WriteLine("Where (n > 20)");
        foreach (var n in numbers.Where(x => x > 20))
        {
            Console.WriteLine(n);
        }

        //select-----multiply each number by 2
        Console.WriteLine("\n select");
        foreach (var n in numbers.Select(x => x * 2))
        {
            Console.WriteLine(n);
        }

        //skip-----skip first 3 numbers from the list
        Console.WriteLine("\n skip(3)");
        foreach (var n in numbers.Skip(3))
        {
            Console.WriteLine(n);
        }

        //take------first 4 numbers from the list

        Console.WriteLine("\n take 4");
        foreach (var n in numbers.Take(4))
        {
            Console.WriteLine(n);
        }

        //OrderBy----ascending order from list 

        Console.WriteLine("\n orderBy");
        foreach (var n in numbers.OrderBy(x => x))
        {
            Console.WriteLine(n);
        }

        //OrderByDescending ----- Order descending from the list

        Console.WriteLine("\n descendingOrder");
        foreach (var n in numbers.OrderByDescending(x => x))
        {
            Console.WriteLine(n);
        }

        //Distinct-----remove duplicate elements from list

        Console.WriteLine("\n Distict");
        foreach (var n in numbers.Distinct())
        {
            Console.WriteLine(n);
        }

        //reverse ----reverse the given list

        Console.WriteLine("\n reverse");
        foreach (var n in numbers.AsEnumerable().Reverse())
        {
            Console.WriteLine(n);
        }

    }
}