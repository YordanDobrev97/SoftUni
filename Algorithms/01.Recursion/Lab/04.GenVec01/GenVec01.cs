using System;

namespace _04.GenVec01
{
    class GenVec01
    {
        static void Main()
        {
            //Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int index = 0;

            GenVector01(n, array, index);
        }

        public static void GenVector01(int n, int[] array, int index)
        {
            if (index == array.Length)
            {
                foreach (var item in array)
                {
                    Console.Write($"{item}");
                }

                Console.WriteLine();
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
    }
}
