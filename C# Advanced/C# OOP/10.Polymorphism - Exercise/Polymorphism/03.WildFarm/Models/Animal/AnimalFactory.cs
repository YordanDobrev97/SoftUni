using System;
using WildFarm.Enums;

namespace WildFarm.Models.Animal
{
    public class AnimalFactory
    {
        public Animal Create(string type, params string[] elements)
        {
            switch (type)
            {
                case "Cat":
                    return new Cat(elements[1], double.Parse(elements[2]), elements[3], elements[4]);
                case "Dog":
                    return new Dog(elements[1], double.Parse(elements[2]), elements[3]);
                case "Hen":
                    return new Hen(elements[1], double.Parse(elements[2]), double.Parse(elements[3]));
                case "Mouse":
                    return new Mouse(elements[1], double.Parse(elements[2]), elements[3]);
                case "Owl":
                    return new Owl(elements[1], double.Parse(elements[2]), int.Parse(elements[3]));
                case "Tiger":
                    return new Tiger(elements[1], double.Parse(elements[2]), elements[3], elements[4]);
                default:
                    throw new ArgumentException("Invalid creation!");
            }
        }
    }
}
