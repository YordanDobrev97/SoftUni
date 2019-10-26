using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        int[] malesInput = Console.ReadLine()
            .Split().Select(int.Parse).ToArray();

        int[] femaleInput = Console.ReadLine()
           .Split().Select(int.Parse).ToArray();

        Stack<int> males = new Stack<int>(malesInput);
        Queue<int> females = new Queue<int>(femaleInput);

        int matchesCount = 0;

        while (females.Count > 0 && males.Count > 0)
        {
            int currentMale = males.Peek();
            int currentFemale = females.Peek();

            if (currentFemale <= 0)
            {
                females.Dequeue();
                //currentFemale = females.Peek();
                continue;
            }

            if (currentMale <= 0)
            {
                males.Pop();
                //currentMale = males.Peek();
                continue;
            }

            if (currentMale % 25 == 0)
            {
                males.Pop();
                //currentMale = males.Peek();
                continue;
            }

            if (currentFemale % 25 == 0)
            {
                females.Dequeue();
                //currentFemale = females.Peek();
                continue;
            }

            bool isMatch = currentMale == currentFemale;
            if (isMatch)
            {
                matchesCount++;
                males.Pop();
                females.Dequeue();
            }
            else
            {
                females.Dequeue();
                males.Pop();
                males.Push(currentMale - 2);
            }
        }

        Console.WriteLine($"Matches: {matchesCount}");

        if (males.Count > 0)
        {
            Console.WriteLine($"Males left: {string.Join(", ", males)}");
        }
        else
        {
            Console.WriteLine($"Males left: none");
        }

        if (females.Count > 0)
        {
            Console.WriteLine($"Females left: {string.Join(", ", females)}");
        }
        else
        {
            Console.WriteLine("Females left: none");
        }
    }
}

