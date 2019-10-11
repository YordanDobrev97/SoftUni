using System;

namespace CustomStack
{
    public class CustomStack<T>
    {
        private const int DefaultValue = 4;
        private T[] array;

        public CustomStack()
        {
            this.array = new T[DefaultValue];
        }

        public int Count { get; private set; }

        public void Push(T element)
        {
            if (this.Count >= this.array.Length)
            {
                Resize();
            }

            this.array[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new ArgumentOutOfRangeException("Stack empty");
            }

            T lastElement = this.array[this.Count - 1];
            this.Count--;
            return lastElement;
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new ArgumentOutOfRangeException("Stack empty");
            }

            T lastElement = this.array[this.Count - 1];
            return lastElement;
        }

        public void ForEach(Action<T> action)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                action(this.array[i]);
            }
        }

        private void Resize()
        {
            T[] newArray = new T[this.array.Length * 2];
            Array.Copy(this.array, newArray, this.array.Length);
            this.array = newArray;
        }
    }
}
