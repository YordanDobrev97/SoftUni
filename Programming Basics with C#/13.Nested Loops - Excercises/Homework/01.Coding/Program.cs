using System;

class Program
{
    static void Main()
    {
        string number = Console.ReadLine();

        int lengthNumber = number.Length;

        int parseNumber = int.Parse(number);
        for (int i = 0; i < lengthNumber; i++)
        {
            int digit = parseNumber % 10;
            parseNumber /= 10;
            if (digit == 0)
            {
                Console.WriteLine("ZERO");
                continue;
            }
            
            char asciiValue =(char)(digit + 33);
            Console.WriteLine(new string(asciiValue, digit));
        }
    }
}

