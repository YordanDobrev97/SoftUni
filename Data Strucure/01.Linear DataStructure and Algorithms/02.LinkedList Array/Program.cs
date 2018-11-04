using System;
class Program
{
    static void Main()
    {
        LinkedListArray<int> linkedListArray = new LinkedListArray<int>();
        linkedListArray.Add(1);
        linkedListArray.Add(2);
        linkedListArray.Add(3);
        linkedListArray.Add(4);
        linkedListArray.Add(5);
        linkedListArray.Add(6);

        foreach (var item in linkedListArray)
        {
            Console.WriteLine(item);
        }
    }
}

