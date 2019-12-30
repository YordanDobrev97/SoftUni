using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDontGo
{
    class Program
    {
        static void Main()
        {
            List<int> pokemons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            int element = 0;
            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int lastElement = pokemons.Last();
                    element = pokemons[0];
                    sum += pokemons[0];
                    pokemons[0] = lastElement;
                }
                else if (index >=pokemons.Count)
                {
                    int firstElement = pokemons.First();
                    sum += pokemons[pokemons.Count - 1];
                    element = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = firstElement;
                }
                else
                {
                    element = pokemons[index];
                    sum += element;
                    pokemons.RemoveAt(index);
                }

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= element)
                    {
                        pokemons[i] += element;
                    }
                    else if (pokemons[i] > element)
                    {
                        pokemons[i] -= element;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
