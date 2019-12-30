using System;
using System.Linq;

public class ReverseString
{
    public static void Main()
    {
        string input = Console.ReadLine();

        while (input != "end")
        {
            var reverseInput = input.Reverse().ToList();

            Console.WriteLine($"{input} = {string.Join("", reverseInput)}");

            input = Console.ReadLine();
        }
    }
}
