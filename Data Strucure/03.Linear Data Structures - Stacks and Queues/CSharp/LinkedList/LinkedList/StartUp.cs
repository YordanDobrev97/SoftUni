using System;
using System.Collections.Generic;
using System.Linq;
namespace LinkedList
{
    class StartUp
    {
        static void Main()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            list.AddFirst(0);
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddLast(3);
            list.AddLast(10);
            // 2 1 0 3 10
            list.RemoveFirst();
            //1 0 3 10
            list.RemoveLast();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
