using System;

namespace _04.FisherYatesShuffle
{
    class FisherYatesShuffle
    {
        static void Main()
        {
            int[] numbers = { 1,2,3,4,5,6 };
            Shuffle(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        public static void Shuffle(int[] numbers)
        {
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                int randomElementIndex = random.Next(i, numbers.Length);
                int temp = numbers[i];
                numbers[i] = numbers[randomElementIndex];
                numbers[randomElementIndex] = temp;
            }
        }
    }
}
