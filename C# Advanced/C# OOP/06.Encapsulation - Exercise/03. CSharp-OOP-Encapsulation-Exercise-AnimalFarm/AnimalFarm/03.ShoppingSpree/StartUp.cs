using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class StartUp
    {
        public static void Main()
        {
            var persons = Console.ReadLine().Split(new[] {' ',';'}, StringSplitOptions.RemoveEmptyEntries);
            var products = Console.ReadLine().Split(new[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);

            ExecutorCommand executorCommand = new ExecutorCommand();
            executorCommand.Execute(persons, products);
        }
    }
}
