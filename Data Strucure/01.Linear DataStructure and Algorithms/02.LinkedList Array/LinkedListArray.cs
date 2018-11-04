using System.Collections;
using System.Collections.Generic;

public class LinkedListArray<T> : IEnumerable<T>
{
    private class Node
    {
        public Node(T item)
        {
            this.Value = item;
            this.Next = null;
        }

        public T Value { get; set; }

        public Node Next { get; set; }
    }

    private Node head;
    private Node next;

    public int Count { get; set; }

    public LinkedListArray()
    {
        this.head = null;
    }

    public void Add(T item)
    {
        if (this.Count == 0)
        {
            this.head = this.next = new Node(item);
        }
        else
        {
            Node node = new Node(item);
            this.next.Next = node;
            this.next = node;
        }

        this.Count++;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node current = this.head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

