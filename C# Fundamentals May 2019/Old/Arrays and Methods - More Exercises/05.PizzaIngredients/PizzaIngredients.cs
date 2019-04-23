using System;

namespace _05.PizzaIngredients
{
    public class PizzaIngredients
    {
        public static void Main()
        {
            string[] ingredients = Console.ReadLine()
                .Split();

            int lengthOfIngredients = int.Parse(Console.ReadLine());

            int count = 0;
            foreach (var ingredient in ingredients)
            {
                if (ingredient.Length == lengthOfIngredients)
                {
                    count++;
                }

                if (count == 10)
                {
                    break;
                }
            }

            string[] resultIngredients = new string[count];
            int index = 0;
            int size = count >= 10 ? count : ingredients.Length;

            for (int i = 0; i < size; i++)
            {
                if (ingredients[i].Length == lengthOfIngredients)
                {
                    resultIngredients[index] = ingredients[i];
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    index++;
                }
            }
            
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", resultIngredients)}.");
        }
    }
}
