using System;
using System.Linq;

namespace _04.FisherYatesShuffle
{
    class FisherYatesShuffle
    {
        static void Main()
        {
            Console.WriteLine("Read numbers:");
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine("Read something strings:");
            string[] strings = Console.ReadLine().Split();
            
            Shuffle(numbers);
            Shuffle(strings);

            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(string.Join(" ", strings));
        }

        public static void Shuffle<T>(T[] numbers)
        {
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                int randomElementIndex = random.Next(i, numbers.Length);
                T temp = numbers[i];
                numbers[i] = numbers[randomElementIndex];
                numbers[randomElementIndex] = temp;
            }
        }
    }
}
