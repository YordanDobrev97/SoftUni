using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    public class FashionBoutique
    {
        public static void Main()
        {
            int[] clothesInBox = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int capacityBox = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(clothesInBox);

            int currentCapacity = 0;
            int numberBox = 0;
            while (clothes.Count > 0)
            {
                int value = 0;
                while (currentCapacity < capacityBox)
                {
                    if (clothes.Count == 0)
                    {
                        numberBox++;
                        break;
                    }
                    value = clothes.Pop();
                    currentCapacity += value;
                }

                if (currentCapacity > capacityBox)
                {
                    numberBox++;
                    clothes.Push(value);
                    currentCapacity = 0;
                }
                else if(currentCapacity == capacityBox)
                {
                    numberBox++;
                    currentCapacity = 0;
                }
            }

            Console.WriteLine(numberBox);
        }
    }
}
