using System;
using System.Linq;

namespace _08.LettersChange
{
    class Program
    {
        static void Main()
        {
            string[] upperAlhabets =
            {
                "A", "B", "C", "D", "E", "F", "G", "H","I", "J", "K", "L", "M",
                "N", "O", "P", "Q", "R", "S","T","U","V","W","X", "Y", "Z"
            };

            string[] lowerAlhabets = new string[26];

            for (int i = 0; i < upperAlhabets.Length; i++)
            {
                var currentAlhabet = upperAlhabets[i];
                lowerAlhabets[i] = currentAlhabet.ToLower();
            }

            string line = Console.ReadLine();

            string[] items = line.Split(new[] { ' '}, 
                StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var item in items)
            {
                var firstLetter = item[0];
                var lastLetter = item[item.Length - 1];
                var numberToParts = item.Skip(1).Take(item.Length - 2).ToArray();
                var number = int.Parse(string.Join("", numberToParts));

                double currentSum = 0;
                if (char.IsUpper(firstLetter))
                {
                    int positionOfFirstLetter = FindPositionLetter(upperAlhabets, firstLetter);
                    currentSum += (double)number / positionOfFirstLetter;
                }
                else
                {
                    int positionOfFirstLetter = FindPositionLetter(lowerAlhabets, firstLetter);
                    currentSum += (double)number * positionOfFirstLetter;
                }

                if (char.IsUpper(lastLetter))
                {
                    int positionOfSecondLetter = FindPositionLetter(upperAlhabets, lastLetter);
                    currentSum -= (double)positionOfSecondLetter;
                }
                else
                {
                    int positionOfSecondLetter = FindPositionLetter(lowerAlhabets, lastLetter);
                    currentSum += (double)positionOfSecondLetter;
                }

                sum += currentSum;
            }

            Console.WriteLine($"{sum:f2}");
        }

        private static int FindPositionLetter(string[] upperAlhabets, char firstLetter)
        {
            int position = -1;
            for (int i = 0; i < upperAlhabets.Length; i++)
            {
                if (upperAlhabets[i] == firstLetter.ToString())
                {
                    position = i + 1;
                    break;
                }
            }

            return position;
        }
    }
}
