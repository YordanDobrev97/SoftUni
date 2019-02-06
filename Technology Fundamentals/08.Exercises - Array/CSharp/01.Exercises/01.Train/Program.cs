using System;

class Program
{
    static void Main()
    {
        int wagonsCount = int.Parse(Console.ReadLine());

        int[] persons = new int[wagonsCount];
        int weidth = 0;
        for (int i = 0; i < wagonsCount; i++)
        {
            int personWagon = int.Parse(Console.ReadLine());
            weidth += personWagon;
            persons[i] = personWagon;
        }

        Console.WriteLine($"{string.Join(" ", persons)}");
        Console.WriteLine($"{weidth}");
    }
}

