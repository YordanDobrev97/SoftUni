using System;

namespace GenerateVector01
{
   public class GenVec01
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int index = 0;

            GenVector01(n, array, index);
        }

        private static void GenVector01(int n, int[] array, int index)
        {
            if (index == array.Length)
            {
                Print(array);
            }
            else
            {
                for (int i = 0; i <=1; i++)
                {
                    array[index] = i;
                    GenVector01(n, array, index + 1);
                }
            }
        }

        private static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item}");
            }

            Console.WriteLine();
        }
    }
}
