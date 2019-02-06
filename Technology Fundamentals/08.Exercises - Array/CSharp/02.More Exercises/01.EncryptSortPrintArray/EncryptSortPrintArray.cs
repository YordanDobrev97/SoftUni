using System;
using System.Linq;

namespace _01.EncryptSortPrintArray
{
    public class EncryptSortPrintArray
    {
        public static void Main()
        {
            int numbersLines = int.Parse(Console.ReadLine());

            string[] names = new string[numbersLines];
            for (int i = 0; i < numbersLines; i++)
            {
                names[i] = Console.ReadLine();
            }

            int[] encryptValues = new int[numbersLines];
            char[] vowelsAlhabets =
            {
                'a', 'e', 'i', 'o', 'u',
                'A', 'E', 'I', 'O','U',
            };

            int index = 0;
            foreach (var name in names)
            {
                int sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    char symbol = name[i];
                    int asciiValue = symbol;
                    if (vowelsAlhabets.Contains(symbol))
                    {
                        sum += asciiValue * name.Length;
                    }
                    else
                    {
                        sum += asciiValue / name.Length;
                    }
                }
                encryptValues[index] = sum;
                index++;
            }

            Array.Sort(encryptValues);

            foreach (var encryptValue in encryptValues)
            {
                Console.WriteLine(encryptValue);
            }
        }
    }
}
