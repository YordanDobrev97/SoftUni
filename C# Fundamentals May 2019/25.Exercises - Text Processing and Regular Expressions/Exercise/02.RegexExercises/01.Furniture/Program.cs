using System;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @">>(?<name>.*)<<(?<price>\d+\.?[0-9]*)!(?<quantity>\d+)";

            Console.WriteLine("Bought furniture:");
            double totalPrice = 0;
            while (input != "Purchase")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    var match = Regex.Match(input, pattern);
                    var nameTown = match.Groups["name"].Value;
                    var price = double.Parse(match.Groups["price"].Value);
                    var quantity = double.Parse(match.Groups["quantity"].Value);
                    totalPrice += price * quantity;

                    Console.WriteLine(nameTown);
                    
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
