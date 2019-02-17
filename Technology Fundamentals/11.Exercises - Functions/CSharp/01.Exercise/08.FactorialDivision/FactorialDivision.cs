using System;

namespace _08.FactorialDivision
{
    public class FactorialDivision
    {
        public static void Main()
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            
            decimal firstFactoriel = Factoriel(firstNumber);
            decimal secondFactoriel = Factoriel(secondNumber);

            Console.WriteLine($"{firstFactoriel / secondFactoriel:f2}");

        }
        public static decimal Factoriel(decimal number)
        {
            decimal factoriel = 1;

            for (decimal i = 1; i <=number; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
    }
}
