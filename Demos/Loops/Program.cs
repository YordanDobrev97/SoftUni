using System;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            //while loop
            //string data;
            //while ((data = Console.ReadLine()) != "END")
            //{
            //    Console.WriteLine("Hello {0}", data);
            //}

            //for loop
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("Index {0} - Value {1}", i -1, i);
            }

            Console.WriteLine(new string('-', 20));

            //do-while loop
            int num = 1;
            do
            {
                Console.WriteLine("Index {0} - Value {1}", num-1, num);
                num++;

            } while (num <= 10);

            Console.WriteLine(new string('-', 20));

            //nested loops

            for (int i1 = 1; i1 < 10; i1++)
            {
                for (int i2 = 2; i2 <=10; i2++)
                {
                    if (i1 % 2 == 0 && i2 % 2 == 1)
                    {
                        Console.WriteLine("{0} {1}", i1, i2);
                    }
                }
            }

            Console.WriteLine(new string('-', 20));

            //print even numbers to 20
            for (int i = 1; i <=20; i++)
            {
                if (i > 15)
                {
                    break;
                }
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
