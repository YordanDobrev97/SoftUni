using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();

            var companies = new Dictionary<string, HashSet<string>>();

            while (line != "End")
            {
                string[] elements = line.Split(" -> ");
                string companyName = elements[0];
                string id = elements[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new HashSet<string>());
                }
                companies[companyName].Add(id);

                line = Console.ReadLine();
            }

            foreach (var item in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var id in item.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
