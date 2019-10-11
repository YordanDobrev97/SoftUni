using System;

namespace CustomList
{
    public class StartUp
    {
        public static void Main()
        {
            CustomList<int> numberList = new CustomList<int>();
            numberList.Add(0);
            numberList.Add(1);
            numberList.Add(2);

            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);
            }

            Console.WriteLine("Contains:" + numberList.Contains(200000)); // False
            Console.WriteLine("After swap");
            numberList.Swap(1, 2); // 0, 2, 1

            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);
            }
        }
    }
}
