using System;
using System.Linq;

namespace _02.Problem2
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string line = Console.ReadLine();

            while (line != "End")
            {
                string[] arguments = line.Split();
                string command = arguments[0];

                switch (command)
                {
                    case "Switch":
                        int index = int.Parse(arguments[1]);

                        if (index >= 0 && index <= numbers.Count - 1)
                        {
                            int number = numbers[index];

                            if (number > 0)
                            {
                                numbers[index] = int.Parse($"-{numbers[index]}");
                            }
                            else
                            {
                                numbers[index] = Math.Abs(numbers[index]);
                            }
                        }
                        break;
                    case "Change":
                        index = int.Parse(arguments[1]);
                        int value = int.Parse(arguments[2]);

                        if (index >= 0 && index <= numbers.Count - 1)
                        {
                            numbers[index] = value;
                        }
                        break;
                    case "Sum":
                        if (arguments[1] == "Negative")
                        {
                            var negativeNumbers = numbers.Where(x => x < 0).ToList();
                            Console.WriteLine(string.Join(" ", negativeNumbers.Sum()));
                        }
                        else if (arguments[1] == "Positive")
                        {
                            var positiveNumbers = numbers.Where(x => x > 0).ToList();
                            Console.WriteLine(string.Join(" ", positiveNumbers.Sum()));
                        }
                        else
                        {
                            Console.WriteLine(string.Join(" ", numbers.Sum()));
                        }
                        
                        break;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers.Where(x => x >= 0).ToList()));
        }
    }
}
