using System;
using System.Globalization;

namespace _10.Days_Sum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string firstData = Console.ReadLine();
            string secondData = Console.ReadLine();

            DateTime firstDateTime = DateTime.
                ParseExact(firstData, "dd-MM-yyyy", 
                CultureInfo.InvariantCulture);

            DateTime secondDateTime = DateTime.
                ParseExact(secondData, "dd-MM-yyyy", 
                CultureInfo.InvariantCulture);

            for (int i = 1; i <=n; i++)
            {
                if (i % 2  == 0)
                {
                    firstDateTime = firstDateTime.AddDays(1);
                }
                else
                {
                    secondDateTime = secondDateTime.AddDays(1);
                }
            }
            int sum = firstDateTime.Day + secondDateTime.Day;

            Console.WriteLine(sum);
        }
    }
}
