using System;
using System.Collections.Generic;

namespace _01.ClubParty
{
    public class Program
    {
        static void AddHalls(string[] input, Stack<string> halls)
        {
            foreach (var item in input)
            {
                if (!int.TryParse(item, out int result))
                {
                    halls.Push(item);
                }
            }
        }

        static void AddPersonCapacity(string[] hallsWithCountPersons, Stack<int> personCapacity)
        {
            foreach (var item in hallsWithCountPersons)
            {
                if (int.TryParse(item, out int result))
                {
                    personCapacity.Push(result);
                }
            }
        }

        static void Main()
        {
            int maxCapacity = int.Parse(Console.ReadLine());
            string[] hallsWithCountPersons = Console.ReadLine()
                .Split();

            Stack<string> halls = new Stack<string>();
            Stack<int> personCapacity = new Stack<int>();

            AddHalls(hallsWithCountPersons, halls);
            AddPersonCapacity(hallsWithCountPersons, personCapacity);

            int currentCapacityHall = 0;
            List<int> reservations = new List<int>();
            while (halls.Count > 0 && personCapacity.Count > 0)
            {
                int countPerson = personCapacity.Peek();

                if ((currentCapacityHall + countPerson) <= maxCapacity)
                {
                    reservations.Add(countPerson);
                    currentCapacityHall += countPerson;
                    personCapacity.Pop();
                }
                else if ((currentCapacityHall + countPerson) > maxCapacity)
                {
                    currentCapacityHall = 0;
                    string currentHall = halls.Pop();
                    Console.WriteLine($"{currentHall} -> {string.Join(", ", reservations)}");
                    reservations.Clear();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
