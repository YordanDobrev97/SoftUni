using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    public class KeyRevolver
    {
        public static void Main()
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfBarrel = int.Parse(Console.ReadLine());
            List<int> bulletsInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> locksInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Stack<int> bullets = new Stack<int>(bulletsInput);
            Queue<int> locks = new Queue<int>(locksInput);
            int valueOfIntelligence = int.Parse(Console.ReadLine());

            int shoots = 0;
            while (bullets.Count > 0 && locks.Count > 0)
            {
                int currentLastBullet = bullets.Pop();
                int currentLock = locks.Peek();

                if (currentLastBullet <= currentLock)
                {
                    Console.WriteLine($"Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                shoots++;

                if (shoots % sizeOfBarrel == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                }
                
            }
            if (locks.Count <= 0)
            {
                int bulletCost = shoots * priceOfBullet;
                int earned = valueOfIntelligence - bulletCost;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
