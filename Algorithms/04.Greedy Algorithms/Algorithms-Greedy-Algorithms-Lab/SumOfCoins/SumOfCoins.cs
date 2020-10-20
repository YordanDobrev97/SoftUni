namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumOfCoins
    {
        public static void Main(string[] args)
        {
            var availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
            var targetSum = 923;

            var selectedCoins = ChooseCoins(availableCoins, targetSum);

            Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
            foreach (var selectedCoin in selectedCoins)
            {
                Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            var choosedCoins = new Dictionary<int, int>();

            var reversedCoins = coins.OrderByDescending(x => x).ToList();
            int i = 0;
            int sum = 0;

            while (i < reversedCoins.Count && sum != targetSum)
            {
                int currentCoin = reversedCoins[i];

                if (currentCoin + sum <= targetSum)
                {
                    //example
                    //(targetSum) 923 - (currentCoin)50 = 873
                    //873 / 50 = 17 coins to take
                    int remaining = targetSum - sum;
                    int coinToTake = remaining / currentCoin;

                    if (coinToTake > 0)
                    {
                        choosedCoins[currentCoin] = coinToTake;
                        sum += coinToTake * currentCoin;
                    }
                }
                else
                {
                    i++;
                }
            }

            if (sum != targetSum)
            {
                throw new InvalidOperationException("Cannot reach desired sum with these coin values");
            }

            return choosedCoins;
        }
    }
}