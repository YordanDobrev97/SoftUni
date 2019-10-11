using System;

namespace CustomList
{
    public class CustomList<T>
    {
        private const int DefaultValue = 2;
        private T[] array;

        public CustomList()
        {
            this.array = new T[DefaultValue];
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                if (index < 0)
                {
                    throw new IndexOutOfRangeException("You have a negative index");
                }

                if (index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index too large!");
                }

                return this.array[index];
            }
            set
            {
                if (index < 0)
                {
                    throw new IndexOutOfRangeException("You have a negative index");
                }

                if (index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Index too large!");
                }

                this.array[index] = value;
            }
        }

        public void Add(T element)
        {
            if (this.Count >= this.array.Length)
            {
                Resize();
            }

            this.array[this.Count] = element;
            this.Count++;
        }

        public T RemoveAt(int index)
        {
            ValidateIndex(index);
            T element = this.array[index];
            Shift(index);
            this.Count--;
            return element;
        }

        public void Insert(int index, T element)
        {
            if (this.Count == this.array.Length)
            {
                Resize();
            }

            int lastIndex = this.Count - 1;
            int nextIndex = lastIndex + 1;
            for (int i = index; i < this.Count; i++)
            {
                this.array[nextIndex] = this.array[lastIndex];
                lastIndex--;
                nextIndex--;
            }

            this.array[index] = element;

            this.Count++;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.array[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int lastIndex)
        {
            if (!IsRange(firstIndex) || !IsRange(lastIndex))
            {
                throw new ArgumentOutOfRangeException("Invalid first or last index");
            }

            T temp = this.array[firstIndex];
            this.array[firstIndex] = this.array[lastIndex];
            this.array[lastIndex] = temp;
        }

        private bool IsRange(int index)
        {
            return index >= 0 && index <= this.array.Length - 1;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.array.Length - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }

        private void ValidateIndex(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("You have a negative index");
            }

            if (index >= this.Count)
            {
                throw new IndexOutOfRangeException("Index too large!");
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
