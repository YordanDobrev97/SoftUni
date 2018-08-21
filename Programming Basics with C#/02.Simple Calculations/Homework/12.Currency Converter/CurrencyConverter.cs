using System;
using System.Collections.Generic;

class CurrencyConverter
{
    static void Main()
    {
        double currencyFrom = double.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string output = Console.ReadLine();

        var curencyConvert = new Dictionary<string, double>()
            {
                {"BGN", 1},
                {"USD", 1.79549},
                {"EUR", 1.95583},
                {"GBP", 2.53405},
            };

        double result = currencyFrom * curencyConvert[input] / curencyConvert[output];

        Console.WriteLine("{0:f2} {1}", result, output);
    }
}

