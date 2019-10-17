using System;

namespace Workshop
{
    public class DoubleLinkedList<T>
    {
        private class ListNode<T>
        {
            public ListNode(T value)
            {
                this.Value = value;
            }

            public ListNode<T> NextNode { get; set; }

            public ListNode<T> PreviousNode { get; set; }

            public T Value { get; set; }
        }

        private ListNode<T> head;
        private int a;
        private ListNode<T> tail;

        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            var newHead = new ListNode<T>(element);

            if (this.Count == 0)
            {
                this.head = this.tail = newHead;
            }
            else
            {
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void AddLast(T element)
        {
            ListNode<T> newTail = new ListNode<T>(element);

            if (this.Count == 0)
            {
                this.tail = this.head = newTail;
            }
            else
            {
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("DoublyLinkedList is empty!");
            }

            T removedElement = this.head.Value;

            ListNode<T> newHead = this.head.NextNode;

            if (this.Count == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                newHead.PreviousNode = null;
                this.head = newHead;
            }

            this.Count--;

            return removedElement;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("DoublyLinkedList is empty!");
            }

            T removedElement = this.tail.Value;

            ListNode<T> newTail = this.tail.PreviousNode;

            if (this.Count == 1)
            {
                this.tail = this.head = null;
            }
            else
            {
                newTail.NextNode = null;
                this.tail = newTail;
            }

            this.Count--;

            return removedElement;
        }

        public void ForEach(Action<T> action, bool shouldStartFromHead = true)
        {
            ListNode<T> currentNode = this.head;

            if (!shouldStartFromHead)
            {
                currentNode = this.tail;
            }

            while (currentNode != null)
            {
                action(currentNode.Value);

                if (!shouldStartFromHead)
                {
                    currentNode = currentNode.PreviousNode;
                }
                else
                {
                    currentNode = currentNode.NextNode;
                }
            }
        }

        public void Clear()
        {
            this.head = null;
            this.tail = null;

            this.Count = 0;
        }

        public T[] ToArray()
        {
            T[] array = new T[this.Count];

            var currentNode = this.head;

            for (int i = 0; i < this.Count; i++)
            {
                array[i] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return array;
        }
    }
}
