using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int personCount = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < personCount; i++)
            {
                string[] inputPerson = Console.ReadLine().Split();
                string name = inputPerson[0];
                int age = int.Parse(inputPerson[1]);

                Person person = new Person(name, age);
                family.Add(person);
            }

            var persons = family.Persons.Where(x => x.Age > 30).OrderBy(x => x.Name);

            foreach (var item in persons)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
