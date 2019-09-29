using System;
using System.Collections.Generic;

namespace _04.CitiesContinentCountry
{
    public class StartUp
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            var continentsCountryCites = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continentsCountryCites.ContainsKey(continent))
                {
                    continentsCountryCites[continent] = new Dictionary<string, List<string>>();
                }

                if (!continentsCountryCites[continent].ContainsKey(country))
                {
                    continentsCountryCites[continent][country] = new List<string>();
                }

                continentsCountryCites[continent][country].Add(city);

            }

            foreach (var continent in continentsCountryCites)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    var citites = country.Value;
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", citites)}");
                }
            }
        }
    }
}
