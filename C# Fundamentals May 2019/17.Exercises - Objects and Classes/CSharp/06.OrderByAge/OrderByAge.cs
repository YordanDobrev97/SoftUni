using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.OrderByAge
{
    class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }

        public Person(string name, int id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
    }

    public class OrderByAge
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<Person> persons = new List<Person>();

            while (input != "End")
            {
                string[] inputParams = input.Split();
                string name = inputParams[0];
                int id = int.Parse(inputParams[1]);
                int age = int.Parse(inputParams[2]);

                Person person = new Person(name, id, age);
                persons.Add(person);

                input = Console.ReadLine();
            }

            persons = persons.OrderBy(x => x.Age).ToList();

            foreach (var item in persons)
            {
                Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");
            }
        }
    }
}
