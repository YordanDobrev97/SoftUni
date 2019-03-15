using System;

class Program
{
    static void Main()
    {
        string[] elements = Console.ReadLine()
            .Split(' ');


        for (int i = 0; i < elements.Length / 2; i++)
        {
            string temp = elements[i];
            elements[i] = elements[elements.Length - 1 - i];
            elements[elements.Length - 1 - i] = temp;
        }

        Console.WriteLine(string.Join(" ", elements));
    }
}

