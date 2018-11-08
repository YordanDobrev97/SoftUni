using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int numberOfSnowballs = int.Parse(Console.ReadLine());

        BigInteger maxSnowballValue = 0;
        long snowBallSnowValue = 0;
        long snowBallTimeValue = 0;
        long snowBallPowerValue = 0;
        for (int i = 0; i < numberOfSnowballs; i++)
        {
            long snowballSnow = long.Parse(Console.ReadLine());
            long snowballTime = long.Parse(Console.ReadLine());
            long snowballQuality = long.Parse(Console.ReadLine());

            BigInteger snowballValue = snowballSnow / snowballTime;
            snowballValue = Power(snowballValue, snowballQuality);

            if (snowballValue > maxSnowballValue)
            {
                maxSnowballValue = snowballValue;
                snowBallSnowValue = snowballSnow;
                snowBallTimeValue = snowballTime;
                snowBallPowerValue = snowballQuality;
            }
        }

        Console.WriteLine($"{snowBallSnowValue} : {snowBallTimeValue} = {maxSnowballValue} ({snowBallPowerValue})");
    }
    static BigInteger Power(BigInteger d, long n)
    {
        BigInteger power = 1;
        for (int i = 0; i < n; i++)
        {
            power *=d;
        }
        return power;
    }
}

