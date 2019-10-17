using System;
using _01.GenericBoxOfString;

namespace _01.GenericBoxOfString
{
    public class Program
    {
        public static void Main()
        {
            string[] nameAddress = Console.ReadLine().Split(" ");
            string[] nameAmountBeer = Console.ReadLine().Split(" ");
            string[] thrdLine = Console.ReadLine().Split(" ");

            string firstName = nameAddress[0];
            string secondName = nameAddress[1];
            string address = nameAddress[2];
            string town = nameAddress[3];

            string name = nameAmountBeer[0];
            int littersBeer = int.Parse(nameAmountBeer[1]);
            bool drunkOrNot = nameAmountBeer[2] == "drunk";

            string nameThirdLine = thrdLine[0];
            double doubleValue = double.Parse(thrdLine[1]);
            string bankName = thrdLine[2];

            string fullName = $"{firstName} {secondName}";

            var personData = new Threeuple<string, string, string>(fullName, address, town);
            var nameLittersDrunkOrNot = new Threeuple<string, int, bool>(name, littersBeer, drunkOrNot);
            var integerDoubleBank = new Threeuple<string, double, string>(nameThirdLine, doubleValue, bankName);

            Console.WriteLine(personData);
            Console.WriteLine(nameLittersDrunkOrNot);
            Console.WriteLine(integerDoubleBank);
        }
    }
}
