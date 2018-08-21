using System;

namespace _05.Cat_Food_Meow
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintPoint(n);
            PrintPaip();

            for (int i = 0; i < n; i++)
            {
                Console.Write("\\");
                Console.Write("/");
            }
            PrintPaip();
            PrintPoint(n);
            Console.WriteLine();

            PrintPoint(n);
            PrintPaip();

            Console.Write(new string('~', n * 2));
            PrintPaip();
            PrintPoint(n);
            Console.WriteLine();

            int brackets = n;
            int space = 0;
            for (int i = 0; i < n; i++)
            {
                PrintPoint(n);
                PrintPaip();
                PrintBrackets(brackets, space);
                PrintPaip();
                PrintPoint(n);

                brackets--;
                space++;
                Console.WriteLine();
            }

            PrintPoint(n);
            PrintPaip();
            Console.Write(new string(' ', n - 2));
            Console.Write("MEOW");
            Console.Write(new string(' ', n - 2));
            PrintPaip();
            PrintPoint(n);
            Console.WriteLine();

            PrintPoint(n);
            PrintPaip();
            Console.Write(new string(' ', n - 2));
            Console.Write("FOOD");
            Console.Write(new string(' ', n - 2));
            PrintPaip();
            PrintPoint(n);
            Console.WriteLine();

            space = n - 1;
            for (int i = 0; i < n; i++)
            {
                PrintPoint(n);
                PrintPaip();
                PrintBrackets(i + 1, space);
                PrintPaip();
                PrintPoint(n);
                space--;
                Console.WriteLine();
            }

            PrintPoint(n);
            PrintPaip();
            Console.Write(new string('~', n * 2));
            PrintPaip();
            PrintPoint(n);
            

            Console.WriteLine();
            PrintPoint(n);
            PrintPaip();
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("\\");
                Console.Write("/");
            }
            PrintPaip();
            PrintPoint(n);
           
            Console.WriteLine();
        }

        private static void PrintBrackets(int brackets, int space)
        {
            Console.Write(new string(' ', space));
            for (int i = 0; i < brackets; i++)
            {
                Console.Write("{");
                Console.Write("}");
            }
            Console.Write(new string(' ', space));
        }

        private static void PrintPaip()
        {
            Console.Write("|");
        }

        private static void PrintPoint(int n)
        {
            Console.Write(new string('.', n - 1));
        }
    }
}
