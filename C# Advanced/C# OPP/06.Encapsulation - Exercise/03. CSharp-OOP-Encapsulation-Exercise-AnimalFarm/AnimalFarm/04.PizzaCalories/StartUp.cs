using System;

namespace PizzaCalories
{
    public class StartUp
    {
        public static void Main()
        {
            CommandExecutor executor = new CommandExecutor();
            executor.Execute();
        }
    }
}
