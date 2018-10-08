using System;

namespace _01.Old_Books
{
    class Program
    {
        static void Main()
        {
            string findBook = Console.ReadLine();
            int capacityLibraly = int.Parse(Console.ReadLine());

            bool foundBook = false;
            int numBook = 0;
            int currentCapacity = 1;
            while (!foundBook && currentCapacity <= capacityLibraly)
            {
                string book = Console.ReadLine();

                if (book == findBook)
                {
                    foundBook = true;
                }
                else
                {
                    numBook++;
                }
                currentCapacity++;
            }

            if (foundBook)
            {
                Console.WriteLine($"You checked {numBook} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {numBook} books.");
            }
        }
    }
}
