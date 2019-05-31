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

        int length = Math.Min(firstArray.Length, secondArray.Length);

        string[] outputArray = new string[length];

        int index = 0;
        for (int i = 0; i < secondArray.Length; i++)
        {
            string elementFromSecondArray = secondArray[i];

            bool isEqual = false;
            for (int j = 0; j < firstArray.Length; j++)
            {
                string elementFromFirstArray = firstArray[j];

                if (elementFromSecondArray == elementFromFirstArray)
                {
                    isEqual = true;
                    break;
                }
            }

            if (isEqual)
            {
                outputArray[index] = elementFromSecondArray;
                index++;
                isEqual = false;
            }
        }

        Console.WriteLine(string.Join(" ", outputArray));
    }
}

