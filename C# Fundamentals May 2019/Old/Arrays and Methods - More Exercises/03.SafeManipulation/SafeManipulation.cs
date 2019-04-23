using System;
using System.Linq;

namespace _03.SafeManipulation
{
    public class SafeManipulation
    {
        public static void Main()
        {
            string[] array = Console.ReadLine()
                .Split();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "END")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Reverse":
                        Array.Reverse(array);
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        if (index < 0 || index > array.Length - 1)
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                        string replaceString = command[2];
                        array[index] = replaceString;
                        break;
                    case "Distinct":
                        array = Distinct(array);
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }

        public static string[] Distinct(string[] array)
        {
            int count = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool contains = false;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        contains = true;
                        break;
                    }
                }
                if (!contains)
                {
                    count++;
                }
            }

            string[] distinctElements = new string[count];

            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (!distinctElements.Contains(array[i]))
                {
                    distinctElements[index] = array[i];
                    index++;
                }
            }

            return distinctElements;
        }
    }
}
