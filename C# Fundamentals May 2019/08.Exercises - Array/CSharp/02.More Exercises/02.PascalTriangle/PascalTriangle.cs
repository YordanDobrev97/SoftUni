using System;

namespace _02.PascalTriangle
{
    public class PascalTriangle
    {
        public static void Main()
        {
            int trianglePascalSize = int.Parse(Console.ReadLine());

            int[] lastValuesArray = null;
            for (int i = 0; i < trianglePascalSize; i++)
            {
                int[] numbers = new int[i + 1];
                numbers[0] = 1;

                int currentIndexSave = 3;

                if (currentIndexSave <=numbers.Length)
                {
                    //TODO...
                    int lastValue = lastValuesArray[i - 2];

                }
                else if (numbers.Length == 2)
                {
                    numbers[1] = 1;
                }

                lastValuesArray = numbers;

                foreach (var number in numbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
