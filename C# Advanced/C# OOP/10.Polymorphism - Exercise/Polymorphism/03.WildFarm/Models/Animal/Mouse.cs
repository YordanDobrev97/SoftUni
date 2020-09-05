using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
            this.EatFoods = new List<Type>();
            this.EatFoods.Add(typeof(Vegetable));
            this.EatFoods.Add(typeof(Fruit));
        }

        public override List<Type> EatFoods { get; }

        public override double DefaultValue => 0.10;

        public override bool Food(Food food)
        {
            if (!this.EatFoods.Contains(food.GetType()))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            return true;
        }

        public override string ProducingSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
