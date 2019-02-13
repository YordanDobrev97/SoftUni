using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] arguments = line.Split(' ');
                string command = arguments[0];

                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(arguments[1]);
                        if (index < 0 || index > numbers.Length - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            int[] exhangeItems = new int[numbers.Length - 1 - index];

                            int indx = 0;
                            for (int i = numbers.Length - 1; i > index; i--)
                            {
                                exhangeItems[exhangeItems.Length - 1 - indx] = numbers[i];
                                indx++;
                            }

                            int currentIndex = index;
                            for (int i = 0; i < numbers.Length - exhangeItems.Length; i++)
                            {
                                numbers[numbers.Length - 1 - i] = numbers[currentIndex];
                                currentIndex--;
                            }

                            for (int i = 0; i < exhangeItems.Length; i++)
                            {
                                numbers[i] = exhangeItems[i];
                            }
                        }
                        break;
                    case "max":
                        if (arguments[1] == "odd")
                        {
                            int[] oddNums = numbers.Where(x => x % 2 == 1).ToArray();
                            int maxElement = oddNums.Max();
                            int indexMaxElement = Array.IndexOf(numbers, maxElement);
                            Console.WriteLine(indexMaxElement);
                        }
                        else
                        {
                            int[] evenNums = numbers.Where(x => x % 2 == 0).ToArray();
                            int maxElement = evenNums.Max();
                            int indexMaxElement = Array.IndexOf(numbers, maxElement);
                            Console.WriteLine(indexMaxElement);
                        }
                        break;
                    case "min":
                        //TODO...
                        break;
                }

                line = Console.ReadLine();
            }
        }
    }
}
