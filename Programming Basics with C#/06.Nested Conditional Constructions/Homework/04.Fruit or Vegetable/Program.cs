using System;

namespace _04.Fruit_or_Vegetable
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();

            if (product == "banana" ||
                product == "apple" ||
                product == "cherry" ||
                product == "kiwi" ||
                product == "lemon" ||
                product == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "tomato"  ||
                    product == "cucumber" ||
                    product == "pepper"   ||
                    product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
