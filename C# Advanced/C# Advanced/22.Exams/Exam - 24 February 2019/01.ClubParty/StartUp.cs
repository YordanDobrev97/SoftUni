using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        int maxCapacity = int.Parse(Console.ReadLine());
        List<string> data = Console.ReadLine().Split(" ", 
            StringSplitOptions.RemoveEmptyEntries).ToList();

        Stack<string> halls = new Stack<string>();
        bool isEmptyData = false;
        for (int i = data.Count - 1; i > 0; i--)
        {
            char last = data[i][0];

            if (char.IsLetter(last))
            {
                string hall = data[i];
                halls.Push(hall);

                int currentCapacity = 0;
                List<int> people = new List<int>();
                data.RemoveAt(i);
                int index = data.Count - 1;
                while (true)
                {
                    if (data.Count == 0)
                    {
                        isEmptyData = true;
                        break;
                    }
                    var value = data[index];

                    if (int.TryParse(value, out int num))
                    {
                        if (currentCapacity + num > maxCapacity)
                        {
                            break;
                        }

                        currentCapacity += num;
                        people.Add(num);
                        data.RemoveAt(index);
                        index = data.Count - 1;
                    }
                    else
                    {
                        index--;
                    }
                }

                if (!isEmptyData)
                {
                    Console.WriteLine($"{hall} -> {string.Join(", ", people)}");
                }
                
            }
            else
            {
                data.RemoveAt(i);
            }
            i = data.Count;
        }
        
    }
}