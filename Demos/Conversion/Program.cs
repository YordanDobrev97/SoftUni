using System;

namespace Conversion
{
    class Program
    {
        static void Main()
        {
            double d = 123.323921;
            Console.WriteLine("Value: {0}", d);

            int i = (int)d;// cast 
            Console.WriteLine("Cast value to int: {0}", i);

            int value = 1;
            Console.WriteLine("Default value to int: {0}", value);

            bool b = Convert.ToBoolean(value);
            Console.WriteLine("Convert default value to int to bool: {0}", b);

            string s = "D";
            //Console.WriteLine("Value of s: {0}", s);

            //byte num = Convert.ToByte(s);
            //Console.WriteLine("Convert value of s to byte: {0}", num);//Exception

            char c = Convert.ToChar(s);
            Console.WriteLine("Convert value s to char: {0}", c);

            const int number = 100;
            Console.WriteLine("Value of Const number: {0}", number);

            //number = 20;invalid value, not change const 

            Console.WriteLine("\"Pesho\"");
        }
    }
}
