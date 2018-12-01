
using System;
using System.Collections;
using System.Collections.Generic;

public class MyLinkedList<T> : IEnumerable<T>
{
    private class Node
    {
        private T value;
        private Node next;

        public Node(T value)
        {
            this.value = value;
        }

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
        public Node Next
        {
            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }
    }

    private Node head;
    private Node tail;

    public int Count { get; set; }

    public void AddFirst(T value)
    {
        if (this.Count == 0)
        {
            Node newNode = new Node(value);
            head = newNode;
            tail = newNode; 
        }
        else
        {
            Node oldNode = head;
            Node newNode = new Node(value);
            head = newNode;
            head.Next = oldNode;
        }
        this.Count++;
    }

    public void AddLast(T value)
    {
        Node newNode = new Node(value);
        if (this.Count == 0)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            Node oldTail = this.tail;
            this.tail = newNode;
            oldTail.Next = this.tail;
        }
        this.Count++;
    }

    public T RemoveFirst()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("Empty list");
        }
        Node old = this.head;
        head = this.head.Next;
        this.Count--;

        if (this.Count == 0)
        {
            this.tail = null;
        }

        return old.Value;
    }

    public T RemoveLast()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("Empty list");
        }
        Node nodeTail = this.tail;

        if (this.Count == 1)
        {
            this.head = tail = null;
        }
        else
        {
            Node node = GetSecondToLast();
            node.Next = null;
            this.tail = node;
            this.Count--;
        }

        return nodeTail.Value;
    }

    private Node GetSecondToLast()
    {
        Node current = this.head;
        while (current.Next != this.tail)
        {
            current = current.Next;
        }
        return current;
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

