namespace _03.SortingAlgorithms
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = {-10, 100, 300, -50, 0};
            SelectionSort(array);
            BubbleSort(array);
            Console.WriteLine(string.Join(" ", array));
        }

        private static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        private static void SelectionSort(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                int minIndex = index;

                for (int currentIndex = index + 1; currentIndex < array.Length; currentIndex++)
                {
                    if (array[minIndex] < array[currentIndex])
                    {
                        minIndex = currentIndex;
                    }
                }
                
                int temp = array[index];
                array[index] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }
}
