using System;

namespace _12.Int__Double__String
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "integer":
                    int number = int.Parse(Console.ReadLine());
                    if (number >= -1000 && number <= 1000)
                    {
                        number++;
                        Console.WriteLine(number);
                    }
                    break;
                case "real":
                    double doublenNumber = double.Parse(Console.ReadLine());
                    if (doublenNumber >= -1000 && doublenNumber <= 1000)
                    {
                        doublenNumber++;
                        Console.WriteLine("{0:f2}", doublenNumber);
                    }
                    break;
                case "text":
                    string text = Console.ReadLine();
                    Console.WriteLine("{0}*", text);
                    break;
            }
        }
    }
}
