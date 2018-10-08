using System;

namespace _04.Coins
{
    class Program
    {
        static void Main()
        {
            double coin = double.Parse(Console.ReadLine());

            double penny = coin * 100;
            int count = 0;
            int[] validPenny = new int[] { 200,100,50,20,10,5,2,1};

            for (int i = 0; i < validPenny.Length; i++)
            {
                int value = validPenny[i];
                while (penny > 0)
                {
                    if (penny >= value)
                    {
                        count++;
                        penny -= value;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
