using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SantaGifts
{
    class Program
    {
        static void Main()
        {
            int numberLines = int.Parse(Console.ReadLine());
            List<int> hourseNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int currentPosition = 0;
            for (int i = 0; i < numberLines; i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "Forward":
                        int position = int.Parse(command[1]);
                        if ((currentPosition + position) < hourseNumbers.Count)
                        {
                            currentPosition = currentPosition + position;
                            hourseNumbers.RemoveAt(currentPosition);
                        }
                        
                        break;
                    case "Back":
                        int steps = int.Parse(command[1]);
                        if (currentPosition - steps >= 0)
                        {
                            currentPosition = currentPosition - steps;
                            hourseNumbers.RemoveAt(currentPosition);
                        }
                        break;
                    case "Swap":
                        int firstValue = int.Parse(command[1]);
                        int lastValue = int.Parse(command[2]);

                        if (hourseNumbers.Contains(firstValue) && hourseNumbers.Contains(lastValue))
                        {
                            int indexOfFirstValue = hourseNumbers.IndexOf(firstValue);
                            int indexOfLastValue = hourseNumbers.IndexOf(lastValue);

                            int temp = firstValue;
                            hourseNumbers[indexOfFirstValue] = hourseNumbers[indexOfLastValue];
                            hourseNumbers[indexOfLastValue] = temp;
                        }
                        break;
                    case "Gift":
                        int index = int.Parse(command[1]);
                        int value = int.Parse(command[2]);
                        if (index >= 0 && index < hourseNumbers.Count)
                        {
                            hourseNumbers.Insert(index, value);
                        }
                        break;
                }
            }

            Console.WriteLine($"Position: {currentPosition}");
            Console.WriteLine(string.Join(", ", hourseNumbers));
        }
    }
}
