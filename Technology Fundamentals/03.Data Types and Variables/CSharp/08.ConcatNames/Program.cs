using System;

class Program
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string secondName = Console.ReadLine();
        string delimiter = Console.ReadLine();

        Console.WriteLine($"{firstName}{delimiter}{secondName}");
    }
}

