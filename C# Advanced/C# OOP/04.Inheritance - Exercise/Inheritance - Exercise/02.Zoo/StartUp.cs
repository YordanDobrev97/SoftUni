using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main()
        {
            Snake snake = new Snake("Pesho");
            Gorilla gorilla = new Gorilla("Gosho");

            Console.WriteLine(snake.Name);
            Console.WriteLine(gorilla.Name);
        }
    }
}
