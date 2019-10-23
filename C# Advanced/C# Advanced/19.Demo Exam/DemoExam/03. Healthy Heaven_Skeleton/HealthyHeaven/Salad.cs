using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Salad
    {
        private List<Vegetable> vegetables;

        public Salad(string name)
        {
            this.Name = name;
            this.vegetables = new List<Vegetable>();
        }

        public string Name { get; set; }

        public int GetTotalCalories()
        {
            var sum = 0;

            foreach (var item in this.vegetables)
            {
                sum += item.Calories;
            }

            return sum;
        }

        public int GetProductCount() => this.vegetables.Count;

        public void Add(Vegetable product)
        {
            this.vegetables.Add(product);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"* Salad {Name} is {GetTotalCalories()} calories and have {GetProductCount()} products:");

            foreach (var item in this.vegetables)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}