using System;
using System.Linq;
using System.Text;

namespace _02.ManipulateArray
{
    public class ManipulateArray
    {
        public static void Main()
        {
            string[] array = Console.ReadLine()
                .Split();

            int countCommand = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCommand; i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "Reverse":
                        Array.Reverse(array);
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        string replaceString = command[2];
                        array[index] = replaceString;
                        break;
                    case "Distinct":
                        array = Distinct(array);
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
