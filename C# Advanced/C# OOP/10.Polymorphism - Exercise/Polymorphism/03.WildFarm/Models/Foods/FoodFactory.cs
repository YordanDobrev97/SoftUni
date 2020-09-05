using System;
using WildFarm.Enums;

namespace WildFarm.Models.Foods
{
    public class FoodFactory
    {
        public Food Create(string type, params string[] elements)
        {
            int quantity = int.Parse(elements[1]);
            switch (type)
            {
                case "Vegetable":
                    return new Vegetable(quantity);
                case "Fruit":
                    return new Fruit(quantity);
                case "Meat":
                    return new Meat(quantity);
                case "Seeds":
                    return new Seeds(quantity);
                default:
                    throw new ArgumentException("Invalid creation!");
            }
        }
    }
}
