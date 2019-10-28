using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int wavesCount = int.Parse(Console.ReadLine());
        List<int> spartanDefenseInput = Console.ReadLine()
            .Split().Select(int.Parse).ToList();

        Queue<int> defenseOfSpartans = new Queue<int>(spartanDefenseInput);
        Stack<int> trojansAlive = new Stack<int>();

        bool isWinSpartans = true;
        for (int i = 1; i <= wavesCount; i++)
        {
            if (defenseOfSpartans.Count == 0)
            {
                isWinSpartans = false;
                break;
            }

            List<int> currentWaveInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            if (i % 3 == 0)
            {
                int newPlate = int.Parse(Console.ReadLine());
                defenseOfSpartans.Enqueue(newPlate);
            }

            Stack<int> trojans = new Stack<int>(currentWaveInput);
            trojansAlive = trojans;

            while (trojans.Count > 0 && defenseOfSpartans.Count > 0)
            {
                int currentSpartan = defenseOfSpartans.Peek();
                int lastTrojan = trojans.Pop();

                if (lastTrojan > currentSpartan)
                {

                }
            }
        }

        if (isWinSpartans)
        {
            Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
            Console.WriteLine($"Plates left: {string.Join(", ", defenseOfSpartans)}");
        }
        else
        {
            Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
            Console.WriteLine($"Warriors left: {string.Join(", ", trojansAlive)}");
        }
    }
}