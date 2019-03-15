using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] firstArray = Console.ReadLine()
            .Split(' ');

        string[] secondArray = Console.ReadLine()
            .Split(' ');

        List<string> commonElements = new List<string>();

        for (int i = 0; i < firstArray.Length; i++)
        {
            string firstElement = firstArray[i];

            int count = 0;
            string secondElement = string.Empty;
            for (int j = 0; j < secondArray.Length; j++)
            {
                secondElement = secondArray[j];

                if (firstElement == secondElement)
                {
                    count++;
                    break;
                }
            }

            if (count > 0)
            {
                commonElements.Add(secondElement);
            }
        }

        Console.WriteLine(string.Join(" ", commonElements));
    }
}

