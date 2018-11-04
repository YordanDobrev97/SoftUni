using System;

namespace _04.Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int totalSum = 0;
            int numberGuest = 0;
            while (input != "The restaurant is full")
            {
                int persons = int.Parse(input);
                numberGuest += persons;
                if (persons < 5)
                {
                    totalSum += persons * 100;
                }
                else
                {
                    totalSum += persons * 70;
                }

                input = Console.ReadLine();
            }

            if (totalSum >= sum)
            {
                Console.WriteLine($"You have {numberGuest} guests and {totalSum - sum} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {numberGuest} guests and {totalSum} leva income, but no singer.");
            }
        }
    }
}
