using System;

namespace _04.Cat_Numbers
{
    class Program
    {
        static void Main()
        {
            int numberCats = int.Parse(Console.ReadLine());

            string uniqueNumber = string.Empty;
            for (int i = 0; i < numberCats; i++)
            {
                string firstName = Console.ReadLine();
                string lastName = Console.ReadLine();
                int birthDayDigit = int.Parse(Console.ReadLine());

                uniqueNumber += birthDayDigit;
                uniqueNumber += firstName[0] + 0;
                uniqueNumber += lastName[0] + 0;
                uniqueNumber += i + 1;

                Console.WriteLine(uniqueNumber);
                uniqueNumber = string.Empty;
            }
        }
    }
}
