using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main()
        {
            RandomList list = new RandomList();
            list.Add("Pesho");
            list.Add("Gosho");
            list.Add("Ivo");
            list.Add("Mariika");
            list.Add("Goshka");
            list.Add("Petkanka");
            list.Add("Ivanka");
            list.Add("Draganka");
            list.Add("Yordanka");


            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());

        }
    }
}
