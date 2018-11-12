using System;

class Program
{
    static void Main()
    {
        int sizeArray = int.Parse(Console.ReadLine());
        int[] array = new int[sizeArray];

        for (int i = 0; i < sizeArray; i++)
        {
            int number = int.Parse(Console.ReadLine());
            array[i] = number;
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
}

