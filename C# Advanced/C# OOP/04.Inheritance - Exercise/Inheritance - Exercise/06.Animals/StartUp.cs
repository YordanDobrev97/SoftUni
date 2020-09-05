using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Beast!")
                {
                    break;
                }

                string type = line;
                string[] animalItems = Console.ReadLine()
                    .Split();

                string name = animalItems[0];
                int age = int.Parse(animalItems[1]);
                string gender = animalItems[2];
                Animal animal = null;

                switch (type)
                {
                    case "Cat":
                        animal = new Cat(name, age, gender);
                        break;
                    case "Dog":
                        animal = new Dog(name, age, gender);
                        break;
                    case "Frog":
                        animal = new Frog(name, age, gender);
                        break;
                    case "Kitten":
                        animal = new Kitten(name, age, gender);
                        break;
                    case "Tomcat":
                        animal = new Tomcat(name, age, gender);
                        break;
                }

                animals.Add(animal);
            }
        }
    }
}
