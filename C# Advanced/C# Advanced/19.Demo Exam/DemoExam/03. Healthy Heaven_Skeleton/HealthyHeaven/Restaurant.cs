using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Restaurant
    {
        private List<Salad> salads;

        public Restaurant(string name)
        {
            this.Name = name;
            this.salads = new List<Salad>();
        }

        public string Name { get; set; }

        public void Add(Salad salad)
        {
            this.salads.Add(salad);
        }

        public bool Buy(string name)
        {
            //var salad = this.salads.Where(x => x.Name == name).FirstOrDefault();
            Salad salad = null;
            foreach (var item in this.salads)
            {
                if (item.Name == name)
                {
                    salad = item;
                    break;
                }
            }

            return this.salads.Remove(salad);
        }

        public Salad GetHealthiestSalad()
        {
            Salad salad = new Salad(string.Empty);

            int minCalories = int.MaxValue;
            foreach (var item in this.salads)
            {
                int sum = item.GetTotalCalories();
                
                if (sum <= minCalories)
                {
                    minCalories = sum;
                    salad = item;
                }
            }

            return salad;
        }

        public string GenerateMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} have {this.salads.Count} salads:");

            foreach (var item in this.salads)
            {
                sb.Append($"{item.ToString()}");
            }
            return sb.ToString();
        }
    }
}
