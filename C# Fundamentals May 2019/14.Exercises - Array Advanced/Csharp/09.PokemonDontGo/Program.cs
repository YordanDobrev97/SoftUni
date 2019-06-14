using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDontGo
{
    class Program
    {
        static void Main()
        {

            // 4, 5, 3
            //increase 
            // all element += 5

            // decrease 
            // all element > 5 => elements-= 5

            // if index < 0 remove first item and copy last item
            // if index > count remove last and copy first item

            List<int> pokemons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int lastElement = pokemons.Last();
                    pokemons[0] = lastElement;
                }
                else if (index > pokemons.Count)
                {
                    int firstElement = pokemons.First();
                    pokemons[pokemons.Count - 1] = firstElement;
                }

                int element = pokemons[index];
                sum += element;
                pokemons.RemoveAt(index);

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= element)
                    {
                        pokemons[i] += element;
                    }
                }

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] > element)
                    {
                        pokemons[i] -= element;
                    }
                }
            }
        }
    }
}
