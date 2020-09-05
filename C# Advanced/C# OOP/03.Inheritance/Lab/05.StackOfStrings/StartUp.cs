using System;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main()
        {
            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine(stack.IsEmpty());
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");
            stack.Push("5");
            stack.Push("6");
            Console.WriteLine(stack.IsEmpty());

            StackOfStrings secondStack = new StackOfStrings();
            secondStack.AddRange(stack);

            Console.WriteLine(string.Join(", ", secondStack));
        }
    }
}
