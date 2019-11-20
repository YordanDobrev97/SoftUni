using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animal
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
            this.EatFoods = new List<Type>();
            this.EatFoods.Add(typeof(Vegetable));
            this.EatFoods.Add(typeof(Meat));

        }

        public override List<Type> EatFoods { get; }
        public override double DefaultValue => 0.30;

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
            return "Meow";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
