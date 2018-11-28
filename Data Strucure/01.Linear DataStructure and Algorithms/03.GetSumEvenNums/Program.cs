using System;
using System.Diagnostics;
class Program
{
    static int totalSteps = 0;
    static void Main()
    {
        Console.Write("Enter your size of array: ");
        int sizeArray = int.Parse(Console.ReadLine());
        int[] array = new int[sizeArray];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        var time = Stopwatch.StartNew();
        int sumEvenArray = GetSumEven(array);
        time.Stop();
        Console.WriteLine($"Sum of even numbers in array is: {sumEvenArray}");
        Console.WriteLine($"Numbers total step: {totalSteps}");
        Console.WriteLine($"Execution time: {time.ElapsedMilliseconds}");
    }
    static int GetSumEven(int[] array)
    {
        int sum = 0;
        totalSteps++;
        //initialization of variable sum 1 step

        totalSteps+=2; 
        //initialization of variable i and a check of i 2 steps
        for (int i = 0; i < array.Length; i++)
        {
            totalSteps+=3;
            //get item to index, remainder and a check even num
            if (array[i] % 2 == 0)
            {
                totalSteps += 2;
                //increment of value and get item to index 2 steps
                sum += array[i];
            }
            totalSteps++;//increment i++ 1 step
        }

        return sum;
    }
}
