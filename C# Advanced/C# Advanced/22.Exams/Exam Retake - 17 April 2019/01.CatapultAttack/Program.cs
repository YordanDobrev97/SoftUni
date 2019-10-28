using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Queue<int> walls = new Queue<int>(Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList());

        for (int i = 1; i <=n; i++)
        {
            Stack<int> rocks = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList());

            if (i % 3 == 0)
            {

            }


            int currentWall = walls.Peek();
            while (rocks.Count > 0)
            {
                int currentWarrior = rocks.Pop();
                if (currentWall > currentWarrior)
                {
                    currentWall -= currentWarrior;
                }


                if (currentWall == 0)
                {
                    walls.Dequeue();
                    break;
                }
            }
        }
    }
}

