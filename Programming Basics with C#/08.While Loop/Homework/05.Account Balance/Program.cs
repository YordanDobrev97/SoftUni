using System;

namespace _05.Account_Balance
{
    class Program
    {
        static void Main()
        {
            int contributions = int.Parse(Console.ReadLine());

            int counter = 1;

            double totalSum = 0;
            while (counter <= contributions)
            {
                double sum = double.Parse(Console.ReadLine());
                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                totalSum += sum;

                Console.WriteLine($"Your account balance was increased by: {sum:f2}");
                counter++;
            }

            Console.WriteLine($"Total balance: {totalSum}");
        }
    }
}
