using System;
using System.Text.RegularExpressions;

namespace _03.BarInc
{
    class Program
    {
        static void Main()
        {
            var pattern =
                @"%(?<customer>[A-Z][a-z]+)%[^|$%\.]*<(?<product>\w+)>[^|$%\.]*\|(?<quantity>\d+)\|[^|$%\.]*?(?<price>[-+]?[0-9]*\.?[0-9]*)\$";

            var input = Console.ReadLine();

            var priceIncome = 0.0;
            while (input != "end of shift")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);

                    var customer = match.Groups["customer"].Value;
                    var product = match.Groups["product"].Value;
                    var quantity = int.Parse(match.Groups["quantity"].Value);
                    var price = double.Parse(match.Groups["price"].Value);

                    var totalPrice = quantity * price;
                    priceIncome += totalPrice;
                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {priceIncome:f2}");
        }
    }
}
