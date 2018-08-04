using System;
using System.Collections;
using System.Collections.Generic;

public class LinkedStack<T> : IEnumerable<T>
{
    private class Node
    {
        public Node(T value, Node next)
        {
            this.Value = value;
            this.Next = next;
        }
        public T Value { get; set; }

        public Node Next { get; set; }
    }

    private Node top;
   
    public int Count { get; set; }

    public void Push(T item)
    {
        this.top = new Node(item, this.top);

        this.Count++;
    }

    public T Pop()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("Empty stack");
        }
        var top = this.top;
        this.top = this.top.Next;

        this.Count--;
        return top.Value;
    }

    public T Peek()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("Empty stack");
        }
        var top = this.top;
        return top.Value;
    }

    public T[] ToArray()
    {
        T[] array = new T[this.Count];

        var current = top;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = current.Value;
            current = current.Next;
        }

        return array;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node current = this.top;
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

