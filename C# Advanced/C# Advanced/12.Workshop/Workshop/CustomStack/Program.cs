using System;

namespace CustomStack
{
    public class Program
    {
        public static void Main()
        {
            CustomStack<int> numberStack = new CustomStack<int>();
            numberStack.Push(1);
            numberStack.Push(2);
            numberStack.Push(3);
            numberStack.Push(4);
            numberStack.Push(5);

            numberStack.ForEach(x => Console.WriteLine(x));
        }
    }
}
