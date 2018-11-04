using System;

namespace _06.Substitute
{
    class Program
    {
        static void Main()
        {
            int startFirstNumber = int.Parse(Console.ReadLine());
            int startSecondNumber = int.Parse(Console.ReadLine());
            int startFirstSecondNumber = int.Parse(Console.ReadLine());
            int startSecondSecondNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int first = startFirstNumber; first <=8; first++)
            {
                for (int second = 9; second >=startSecondNumber; second--)
                {
                    for (int thirth = startFirstSecondNumber; thirth <=8; thirth++)
                    {
                        for (int fouthy = 9; fouthy >=startSecondSecondNumber; fouthy--)
                        {
                            int firstCombination = int.Parse($"{first}{second}");
                            int secondCombination = int.Parse($"{thirth}{fouthy}");

                            if (first % 2 == 0 && second % 2 == 1 && thirth % 2 == 0 && fouthy % 2 == 1)
                            {
                                if (firstCombination != secondCombination)
                                {
                                    counter++;
                                    Console.WriteLine($"{firstCombination} - {secondCombination}");
                                }
                                else
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                if (counter == 6)
                                {
                                    return;
                                }
                            }
                            if (counter == 6)
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
