using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string[] vegetablesInput = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        int[] saladsCalories = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Stack<int> calories = new Stack<int>(saladsCalories);
        Queue<string> vegetables = new Queue<string>(vegetablesInput);

        List<int> finishSalads = new List<int>();
        while (calories.Count > 0 && vegetables.Count > 0)
        {
            string vegetable = vegetables.Peek();
            int currentCalories = calories.Peek();

            int caloriesValue = 0;
            switch (vegetable)
            {
                case "tomato":
                    caloriesValue = 80;
                    break;
                case "carrot":
                    caloriesValue = 136;
                    break;
                case "lettuce":
                    caloriesValue = 109;
                    break;
                case "potato":
                    caloriesValue = 215;
                    break;
            }

            int left = Math.Abs(currentCalories - caloriesValue);
            finishSalads.Add(currentCalories);
            if (left == 0)
            {
                calories.Pop();
            }
            else
            {
                calories.Pop();
                vegetables.Dequeue();
            }
        }

        Console.WriteLine(string.Join(" ", finishSalads));

        if (calories.Count > 0)
        {
            Console.WriteLine(string.Join(" ", calories));
        }
        else
        {
            Console.WriteLine(string.Join(" ", vegetables));
        }
    }
}