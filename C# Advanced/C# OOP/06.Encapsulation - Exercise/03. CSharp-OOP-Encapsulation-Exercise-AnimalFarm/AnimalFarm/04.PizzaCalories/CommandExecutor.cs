using System;

namespace PizzaCalories
{
    public class CommandExecutor
    {
        public void Execute()
        {
            string[] pizzaItems = Console.ReadLine().Split();
            string namePizza = pizzaItems[1];

            Pizza pizza = new Pizza(namePizza);

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                string[] elements = line.Split();

                if (elements[0] == "Dough")
                {
                    string type = elements[1];
                    string technique = elements[2];
                    double weight = double.Parse(elements[3]);
                    Dough dough = new Dough(type, technique, weight);
                    pizza.AddDough(dough);
                }
                else if (elements[0] == "Topping")
                {

                }
            }
        }
    }
}