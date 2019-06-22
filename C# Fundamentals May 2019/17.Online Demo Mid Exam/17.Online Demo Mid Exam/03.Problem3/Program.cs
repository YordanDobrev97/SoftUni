using System;
using System.Linq;

namespace _03.Problem3
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string line = Console.ReadLine();

            int number = 0;
            while (line != "END")
            {
                string[] elements = line.Split();
                string command = elements[0];
                
                switch (command)
                {
                    case "Change":
                        number = int.Parse(elements[1]);
                        int changeNumber = int.Parse(elements[2]);
                        if (numbers.Contains(number))
                        {
                            int indexOfNumber = numbers.IndexOf(number);
                            numbers[indexOfNumber] = changeNumber;
                        }
                        break;
                    case "Hide":
                        number = int.Parse(elements[1]);
                        if (numbers.Contains(number))
                        {
                            numbers.Remove(number);
                        }
                        break;
                    case "Switch":
                        number = int.Parse(elements[1]);
                        int number2 = int.Parse(elements[2]);

                        if (numbers.Contains(number) && numbers.Contains(number2))
                        {
                            int indexOfNumber = numbers.IndexOf(number);
                            int indexOfNumber2 = numbers.IndexOf(number2);

                            int temp = numbers[indexOfNumber];
                            numbers[indexOfNumber] = numbers[indexOfNumber2];
                            numbers[indexOfNumber2] = temp;
                        }
                        break;
                    case "Insert":
                        number = int.Parse(elements[1]);
                        int index = number;
                        int insertNumber = int.Parse(elements[2]);

                        if (index >= 0 && index <= numbers.Count - 1)
                        {
                            numbers.Insert(index + 1, insertNumber);
                        }
                        break;
                    case "Reverse":
                        numbers.Reverse();
                        break;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
