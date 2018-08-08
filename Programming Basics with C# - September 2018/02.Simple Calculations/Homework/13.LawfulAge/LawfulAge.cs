using System;
using System.Collections.Generic;
using System.Globalization;

class LawfulAge
{
    static void Main()
    {
        string data = Console.ReadLine();

        var parseData = DateTime.
            ParseExact(data, "d-M-yyyy", 
            CultureInfo.InvariantCulture);

        parseData = parseData.AddYears(18);

        Console.WriteLine(parseData.ToString("dd-MM-yyyy"));
    }
}

