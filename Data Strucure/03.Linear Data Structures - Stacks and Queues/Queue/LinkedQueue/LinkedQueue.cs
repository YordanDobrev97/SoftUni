using System;

public class MyLinkedQueue<T>
{
    private class Node
    {
        public T Value { get; set; }
        public Node Next { get; set; }
        public Node(T value)
        {
            this.Value = value;
        }
    }

    private Node head;
    private Node tail;

    public int Count { get; set; }

    public void Enqueue(T item)
    {
        Node newNode = new Node(item);
        if (this.Count == 0)
        {
            this.head = newNode;
            this.tail = newNode;
        }
        else
        {
            Node old = this.tail;
            old.Next = newNode;
            this.tail = newNode;
        }
        this.Count++;
    }

    public T Dequeue()
    {
        if (this.Count <=0)
        {
            throw new InvalidOperationException("Empty queue");
        }
        Node currentHead = this.head;
        this.head = currentHead.Next;
        this.Count--;

        return currentHead.Value;
    }

    public T Peek()
    {
        return this.head.Value;
    }
}

