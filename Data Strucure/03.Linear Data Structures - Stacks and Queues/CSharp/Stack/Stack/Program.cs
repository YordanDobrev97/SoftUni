using System;
using StackExtensionJoin;
namespace Stack
{
    class Program
    {
        static void Main()
        {
            LinkedStack<int> stack = new LinkedStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.ToArray().StrJoin();
        }
        private static void StaticStack()
        {
            StaticStack<int> stack = new StaticStack<int>();

            for (int i = 0; i < 100; i++)
            {
                stack.Push(i);
            }
            int last = stack.Peek();
            stack.Pop();
            Console.WriteLine(last);
            Console.WriteLine(stack.Peek());
        }
    }
}
