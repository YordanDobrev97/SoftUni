namespace _02.GreedyAlgorithms
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] coins = { 10, };

            int targetSum = 18;
            int currentSum = 0;

            Array.Sort(coins);
            Array.Reverse(coins);

            int counter = 0;

            while (currentSum < targetSum)
            {
                if (counter == coins.Length)
                {
                    break;
                }

                if (coins[counter] + currentSum <= targetSum)
                {
                    currentSum += coins[counter];
                }

                counter++;
            }

            if (currentSum == targetSum)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
